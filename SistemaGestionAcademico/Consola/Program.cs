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
                        curso.Materia.Nombre + "\t\t\t" +
                        curso.Periodo.Nombre + "\t" +
                        curso.Nombre
                    );
                }
            }
        }
    }
}
