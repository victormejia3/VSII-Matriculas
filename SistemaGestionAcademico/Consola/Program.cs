using Modelo.Entidades;
using Procesos;
using System;
using System.Collections.Generic;
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
                var tmpListaMatriculas = new List<Matricula>()
                {
                    new Matricula(){MatriculaId=3},
                    new Matricula(){MatriculaId=6},
                    new Matricula(){MatriculaId=9},
                    new Matricula(){MatriculaId=12}
                };

                ProMatriculas proMatr = new ProMatriculas(db);

                foreach(var mat in tmpListaMatriculas)
                {
                    var resultado = proMatr.Validar(mat);

                    Console.WriteLine(
                        (resultado ? " SI " : " NO ") 
                    );
                }                
            }
        }
    }
}
