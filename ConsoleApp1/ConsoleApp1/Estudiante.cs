using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Estudiante
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string cedula { get; set; }

        // Propiedades de la relación 1-n con cursos
        public Curso CursoActual { get; set; }
    }
}
