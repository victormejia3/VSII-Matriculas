using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Estudiante
    {
        // Atributos
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        // Relación con matrículas
        public List<Matricula> Matriculas { get; set; }
    }
}
