using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Consultar
            Repositorio repos = new Repositorio();

            List<Estudiante> listaEstudiante = repos.Estudiantes.ToList();

            // Reporte de estudiantes

            foreach(Estudiante est in listaEstudiante)
            {
                Console.WriteLine(" - "+ est.nombre+ " "+est.email);
            }
        }
    }
}
