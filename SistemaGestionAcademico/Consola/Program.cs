using Microsoft.EntityFrameworkCore;
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
                // Operación de proyección
                var listaCarreras = db.carreras
                    .Select(carrera =>
                     new {
                        carrera.CarreraId,
                        carrera.Nombre
                    });

                foreach(var carrera in listaCarreras)
                {
                    Console.WriteLine(carrera.CarreraId + " " +carrera.Nombre );
                }
            }
        }
    }
}
