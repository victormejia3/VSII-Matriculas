using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Modelo.Entidades;
using System;

namespace ModeloDB
{
    public class AcademiaDB : DbContext
    {

        // Declaración de las entidades del modelo
        public DbSet<Estudiante> estudiantes { get; set; }
        public DbSet<Curso> cursos { get; set; }
        public DbSet<Materia> materias { get; set; }
        public DbSet<Matricula> matriculas { get; set; }
        public DbSet<Matricula_Det> matriculas_Det { get; set; }
        public DbSet<Calificacion> calificaciones { get; set; }
        public DbSet<Carrera> carreras { get; set; }
        public DbSet<Malla> mallas { get; set; }
        public DbSet<Nivel> niveles { get; set; }
        public DbSet<Prerequisito> prerequisitos { get; set; }
        public DbSet<Periodo> periodos { get; set; }
        public DbSet<Configuracion> configuracion { get; set; }

        // Configuración de la conección
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=victor-pc\\sql2012; Initial Catalog=SGA; trusted_connection=true;")
                .LogTo(Console.WriteLine, LogLevel.Information);
        }

        // Configurar el modelo de clases
        protected override void OnModelCreating(ModelBuilder model)
        {
            // Configuración de Matriculas
            // - Matricula y carrera
            model.Entity<Matricula>()
                .HasOne(matricula => matricula.Carrera)
                .WithMany(carrera => carrera.Matriculas)
                .HasForeignKey(matricula => matricula.CarreraId);
            // - Matricula y estudiante
            model.Entity<Matricula>()
                .HasOne(matricula => matricula.Estudiante)
                .WithMany(estudiante => estudiante.Matriculas)
                .HasForeignKey(matricula => matricula.EstudianteId);
            // - Matricula y período
            model.Entity<Matricula>()
                .HasOne(matricula => matricula.Periodo)
                .WithMany(periodo => periodo.Matriculas)
                .HasForeignKey(matricula => matricula.PeriodoId);

            // Configuración de Matriculas_Det
            // Matricula_Det con Matricula
            model.Entity<Matricula_Det>()
                .HasOne(matricula_det => matricula_det.Matricula)
                .WithMany(matricula => matricula.Matricula_Dets)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(matricula_det => matricula_det.MatriculaId);

            // Matricula_Det con Calificación
            model.Entity<Matricula_Det>()
                .HasOne(matricula_det => matricula_det.Calificacion)
                .WithOne(calificacion => calificacion.Matricula_Det)
                .HasForeignKey<Calificacion>(calificacion => calificacion.Matricula_DetId);

            // Matricula_Det con Curso
            model.Entity<Matricula_Det>()
                .HasOne(matricula_det => matricula_det.Curso)
                .WithMany(curso => curso.Matricula_Dets)
                .HasForeignKey(matricula_det => matricula_det.CursoId);

            // Configuración de Prerequisito
            // Clave primaria compuesta
            model.Entity<Prerequisito>()
                .HasKey(prerequisito => new
                {
                    prerequisito.MallaId,
                    prerequisito.MateriaId
                });

            // Prerequisitos y malla (Desactivar Delete OnCascade)
            model.Entity<Prerequisito>()
                .HasOne(prerequisito => prerequisito.Malla)
                .WithMany(malla => malla.PreRequisitos)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(prerequisito => prerequisito.MallaId);

            model.Entity<Prerequisito>()
                .HasOne(prerequisito => prerequisito.Materia)
                .WithMany(materia => materia.Prerequisitos)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(prerequisito => prerequisito.MateriaId);

            // Malla
            // Materia Relación de Uno a Uno
            model.Entity<Malla>()
                .HasOne(malla => malla.Materia)
                .WithOne(materia => materia.Malla)
                .HasForeignKey<Malla>(malla => malla.MateriaId);
            // Relación de Malla consigo misma - Una malla tiene submallas
            model.Entity<Malla>()
                .HasOne(malla => malla.MallaPadre)
                .WithMany(malla => malla.SubMallas)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(malla => malla.MallaPadreId);

            // Configuracion
            // La clase configuración tiene clave primaria de tipo distinta que int
            model.Entity<Configuracion>()
                .HasKey(configuracion => configuracion.EscuelaNombre);

            // Niveles
            // La clase con clave primaria formada por dos atributos
            model.Entity<Nivel>()
                .HasKey(nivel => new { nivel.MallaId, nivel.MateriaId });
            // Relación con Malla
            model.Entity<Nivel>()
                .HasOne(nivel => nivel.Malla)
                .WithMany()
                .HasForeignKey(nivel => nivel.MallaId);
            // Relación con Materia
            model.Entity<Nivel>()
                .HasOne(nivel => nivel.Materia)
                .WithMany()
                .HasForeignKey(nivel => nivel.MateriaId);

        }
    }
}
