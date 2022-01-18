using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace Modelo
{
    public class DbMatricula:DbContext
    {
        public DbSet<Calificacion> Calificaciones { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Malla> Mallas { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Matricula_Det> Matricula_Dets { get; set; }
        public DbSet<Periodo> Periodos { get; set; }
        public DbSet<Prerequisito> Prerequisitos { get; set; }

    }
}
