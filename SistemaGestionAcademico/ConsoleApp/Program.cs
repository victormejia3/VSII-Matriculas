using Modelo.Entidades;
using ModeloBD;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante Pedro = new Estudiante() { };
            Configuracion Config = new Configuracion()
            {
                NotaMinima = 7.0f,
                EscuelaNombre="ITQ"
            };

            Repositorio repos;
        }
    }
}
