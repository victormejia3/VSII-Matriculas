using Procesos;
using System;
using System.Linq;

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
                var tmpMateria = db.materias
                    .Single(materia => materia.Nombre== "Programación Web");

                ProPrerequisitos opPrerequisitos = new ProPrerequisitos(db);

                var lista = opPrerequisitos.Prerequisitos(tmpMateria);



                Console.WriteLine("Los prerequisitos de: "+ tmpMateria.Nombre + " son:");
                if (lista == null)
                {
                    Console.WriteLine("No tiene prerequisitos");
                } 
                else
                {
                    foreach (var item in lista)
                    {
                        Console.WriteLine(item.MateriaId + " " + item.Nombre);
                    }
                }                
            }
        }
    }
}
