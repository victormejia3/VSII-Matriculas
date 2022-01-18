using Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Materia Matematicas1 = new Materia()
            {
                Area = "Ciencias Exactas",
                Nombre = "Matemáticas 1",
                Creditos = 4,
                Malla = new Malla(),
                Cursos = new List<Curso>() { new Curso() { } },
                Prerequisitos = new List<Prerequisito>() { new Prerequisito() { } }
            };

        }
    }
}
