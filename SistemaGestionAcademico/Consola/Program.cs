using Microsoft.EntityFrameworkCore;
using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grabar grabar = new Grabar();
            grabar.DatosIni();

            using(var db = AcademiaDBBuilder.Crear())
            {
                var listaCursos = db.cursos
                    .Include(curso => curso.Carrera)
                    .Include(curso => curso.Materia)
                    .Include(curso => curso.Periodo)
                    ;

                Console.WriteLine("Listado de cursos");
                foreach (var curso in listaCursos)
                {
                    Console.WriteLine(
                        curso.Carrera.Nombre + " " +
                        curso.Periodo.Nombre + " " +
                        curso.Periodo.Estado + " " +
                        curso.Jornada + " " +
                        curso.Materia.Nombre + " " +
                        curso.Nombre
                        
                    );
                }

                var listaMatriculas = db.matriculas                    
                    .Include(matricula => matricula.Estudiante)
                    .Include(matricula => matricula.Periodo)
                    .Include(matricula => matricula.Matricula_Dets)
                        .ThenInclude(matricula_dets => matricula_dets.Curso)
                    .Include(matricula => matricula.Matricula_Dets)
                        .ThenInclude(matricula_dets => matricula_dets.Calificacion)
                    ;

                Console.WriteLine("Lista de Matrículas");
                foreach(var matricula in listaMatriculas)
                {
                    Console.WriteLine(
                        matricula.MatriculaId + " "+
                        matricula.EstudianteId + " " +
                        matricula.Estudiante.Nombre + " " +
                        matricula.Periodo.Nombre
                        );
                    foreach(var dets in matricula.Matricula_Dets)
                    {
                        Console.WriteLine(
                            " - " +
                            dets.Matricula_DetId + " " +
                            dets.CursoId + " " +
                            dets.Curso.Nombre+ " " +
                            (dets.Calificacion != null ? 
                                "   - "+dets.Calificacion.Nota1 + " " + dets.Calificacion.Nota2+ " "+ dets.Calificacion.Nota3 
                                : "   - - - -" )
                        );
                    }
                }
            }
        }
    }
}
