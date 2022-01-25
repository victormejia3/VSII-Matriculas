using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Matricula_Det
    {
        public int Matricula_DetId { get; set; }
        // Relaciones con Matricula y Curso
        public int MatriculaId { get; set; }
        public Matricula Matricula { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        // Relación Uno a Uno
        public Calificacion Calificacion { get; set; }
    }
}
