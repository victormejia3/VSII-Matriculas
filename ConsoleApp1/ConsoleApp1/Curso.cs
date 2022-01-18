using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Curso
    {
        public int id { get; set; }
        public string materia { get; set; }
        public string jornada { get; set; }

        // Propiedad para implementar la relación 1-n con estudiantes
        public ICollection<Estudiante> Lista { get; set; }
    }
}
