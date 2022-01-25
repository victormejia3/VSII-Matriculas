﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloDB;

namespace ModeloDB.Migrations
{
    [DbContext(typeof(AcademiaDB))]
    partial class AcademiaDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.Entidades.Calificacion", b =>
                {
                    b.Property<int>("CalificacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Matricula_DetId")
                        .HasColumnType("int");

                    b.Property<float>("Nota1")
                        .HasColumnType("real");

                    b.Property<float>("Nota2")
                        .HasColumnType("real");

                    b.Property<float>("Nota3")
                        .HasColumnType("real");

                    b.HasKey("CalificacionId");

                    b.HasIndex("Matricula_DetId")
                        .IsUnique();

                    b.ToTable("calificaciones");
                });

            modelBuilder.Entity("Modelo.Entidades.Carrera", b =>
                {
                    b.Property<int>("CarreraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CostoCredito")
                        .HasColumnType("real");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarreraId");

                    b.ToTable("carreras");
                });

            modelBuilder.Entity("Modelo.Entidades.Configuracion", b =>
                {
                    b.Property<string>("EscuelaNombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CreditoMaximo")
                        .HasColumnType("int");

                    b.Property<float>("NotaMinima")
                        .HasColumnType("real");

                    b.Property<int>("PeriodoVigenteId")
                        .HasColumnType("int");

                    b.Property<float>("PesoNota1")
                        .HasColumnType("real");

                    b.Property<float>("PesoNota2")
                        .HasColumnType("real");

                    b.Property<float>("PesoNota3")
                        .HasColumnType("real");

                    b.HasKey("EscuelaNombre");

                    b.HasIndex("PeriodoVigenteId");

                    b.ToTable("configuracion");
                });

            modelBuilder.Entity("Modelo.Entidades.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Jornada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeriodoId")
                        .HasColumnType("int");

                    b.HasKey("CursoId");

                    b.HasIndex("CarreraId");

                    b.HasIndex("MateriaId");

                    b.HasIndex("PeriodoId");

                    b.ToTable("cursos");
                });

            modelBuilder.Entity("Modelo.Entidades.Estudiante", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstudianteId");

                    b.ToTable("estudiantes");
                });

            modelBuilder.Entity("Modelo.Entidades.Malla", b =>
                {
                    b.Property<int>("MallaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<int?>("MallaPadreId")
                        .HasColumnType("int");

                    b.Property<int?>("MateriaId")
                        .HasColumnType("int");

                    b.Property<string>("Nivel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MallaId");

                    b.HasIndex("CarreraId");

                    b.HasIndex("MallaPadreId");

                    b.HasIndex("MateriaId")
                        .IsUnique()
                        .HasFilter("[MateriaId] IS NOT NULL");

                    b.ToTable("mallas");
                });

            modelBuilder.Entity("Modelo.Entidades.Materia", b =>
                {
                    b.Property<int>("MateriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Creditos")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MateriaId");

                    b.ToTable("materias");
                });

            modelBuilder.Entity("Modelo.Entidades.Matricula", b =>
                {
                    b.Property<int>("MatriculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("PeriodoId")
                        .HasColumnType("int");

                    b.HasKey("MatriculaId");

                    b.HasIndex("CarreraId");

                    b.HasIndex("EstudianteId");

                    b.HasIndex("PeriodoId");

                    b.ToTable("matriculas");
                });

            modelBuilder.Entity("Modelo.Entidades.Matricula_Det", b =>
                {
                    b.Property<int>("Matricula_DetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<int>("MatriculaId")
                        .HasColumnType("int");

                    b.HasKey("Matricula_DetId");

                    b.HasIndex("CursoId");

                    b.HasIndex("MatriculaId");

                    b.ToTable("matriculas_Det");
                });

            modelBuilder.Entity("Modelo.Entidades.Nivel", b =>
                {
                    b.Property<int>("MallaId")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.HasKey("MallaId", "MateriaId");

                    b.HasIndex("MateriaId");

                    b.ToTable("niveles");
                });

            modelBuilder.Entity("Modelo.Entidades.Periodo", b =>
                {
                    b.Property<int>("PeriodoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.HasKey("PeriodoId");

                    b.ToTable("periodos");
                });

            modelBuilder.Entity("Modelo.Entidades.Prerequisito", b =>
                {
                    b.Property<int>("MallaId")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.HasKey("MallaId", "MateriaId");

                    b.HasIndex("MateriaId");

                    b.ToTable("prerequisitos");
                });

            modelBuilder.Entity("Modelo.Entidades.Calificacion", b =>
                {
                    b.HasOne("Modelo.Entidades.Matricula_Det", "Matricula_Det")
                        .WithOne("Calificacion")
                        .HasForeignKey("Modelo.Entidades.Calificacion", "Matricula_DetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Matricula_Det");
                });

            modelBuilder.Entity("Modelo.Entidades.Configuracion", b =>
                {
                    b.HasOne("Modelo.Entidades.Periodo", "PeriodoVigente")
                        .WithMany()
                        .HasForeignKey("PeriodoVigenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PeriodoVigente");
                });

            modelBuilder.Entity("Modelo.Entidades.Curso", b =>
                {
                    b.HasOne("Modelo.Entidades.Carrera", "Carrera")
                        .WithMany("Cursos")
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Materia", "Materia")
                        .WithMany("Cursos")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Periodo", "Periodo")
                        .WithMany("Cursos")
                        .HasForeignKey("PeriodoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");

                    b.Navigation("Materia");

                    b.Navigation("Periodo");
                });

            modelBuilder.Entity("Modelo.Entidades.Malla", b =>
                {
                    b.HasOne("Modelo.Entidades.Carrera", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Malla", "MallaPadre")
                        .WithMany("SubMallas")
                        .HasForeignKey("MallaPadreId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Modelo.Entidades.Materia", "Materia")
                        .WithOne("Malla")
                        .HasForeignKey("Modelo.Entidades.Malla", "MateriaId");

                    b.Navigation("Carrera");

                    b.Navigation("MallaPadre");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("Modelo.Entidades.Matricula", b =>
                {
                    b.HasOne("Modelo.Entidades.Carrera", "Carrera")
                        .WithMany("Matriculas")
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Estudiante", "Estudiante")
                        .WithMany("Matriculas")
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Periodo", "Periodo")
                        .WithMany("Matriculas")
                        .HasForeignKey("PeriodoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");

                    b.Navigation("Estudiante");

                    b.Navigation("Periodo");
                });

            modelBuilder.Entity("Modelo.Entidades.Matricula_Det", b =>
                {
                    b.HasOne("Modelo.Entidades.Curso", "Curso")
                        .WithMany("Matricula_Dets")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Matricula", "Matricula")
                        .WithMany("Matricula_Dets")
                        .HasForeignKey("MatriculaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Matricula");
                });

            modelBuilder.Entity("Modelo.Entidades.Nivel", b =>
                {
                    b.HasOne("Modelo.Entidades.Malla", "Malla")
                        .WithMany()
                        .HasForeignKey("MallaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Malla");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("Modelo.Entidades.Prerequisito", b =>
                {
                    b.HasOne("Modelo.Entidades.Malla", "Malla")
                        .WithMany("PreRequisitos")
                        .HasForeignKey("MallaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Materia", "Materia")
                        .WithMany("Prerequisitos")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Malla");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("Modelo.Entidades.Carrera", b =>
                {
                    b.Navigation("Cursos");

                    b.Navigation("Matriculas");
                });

            modelBuilder.Entity("Modelo.Entidades.Curso", b =>
                {
                    b.Navigation("Matricula_Dets");
                });

            modelBuilder.Entity("Modelo.Entidades.Estudiante", b =>
                {
                    b.Navigation("Matriculas");
                });

            modelBuilder.Entity("Modelo.Entidades.Malla", b =>
                {
                    b.Navigation("PreRequisitos");

                    b.Navigation("SubMallas");
                });

            modelBuilder.Entity("Modelo.Entidades.Materia", b =>
                {
                    b.Navigation("Cursos");

                    b.Navigation("Malla");

                    b.Navigation("Prerequisitos");
                });

            modelBuilder.Entity("Modelo.Entidades.Matricula", b =>
                {
                    b.Navigation("Matricula_Dets");
                });

            modelBuilder.Entity("Modelo.Entidades.Matricula_Det", b =>
                {
                    b.Navigation("Calificacion");
                });

            modelBuilder.Entity("Modelo.Entidades.Periodo", b =>
                {
                    b.Navigation("Cursos");

                    b.Navigation("Matriculas");
                });
#pragma warning restore 612, 618
        }
    }
}
