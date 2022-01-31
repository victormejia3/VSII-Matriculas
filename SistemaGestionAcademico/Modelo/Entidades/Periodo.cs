using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum EstadosPeriodo { Abierto, Cerrado}

    public class Periodo : IEntidad
    {
        public int PeriodoId { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime FechaInicio { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaFin { get; set; }
        
        public EstadosPeriodo Estado { get; set; } // ABRierto CERrado

        // Relación con los cursos abiertos en un período
        public List<Curso> Cursos { get; set; }
        // Relación con las matrículas realizadas en un período
        public List<Matricula> Matriculas { get; set; }
    }
}
