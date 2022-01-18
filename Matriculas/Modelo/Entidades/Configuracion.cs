using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Configuracion
    {
        public int CreditosMaximo { get; set; }
        public string EscuelaNombre { get; set; }
        public float NotaMinima { get; set; }
        public float PesoNota1 { get; set; }
        public float PesoNota2 { get; set; }
        public float PesoNota3 { get; set; }

        // Propiedades para la relación con Periodo
        public Periodo PeriodoVigente { get; set; }
        public int PeriododVigenteId { get; set; }
    }
}
