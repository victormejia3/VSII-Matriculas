﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Periodo : IEntidad
    {
        public int PeriodoId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; } // ABRierto CERrado
        // Relación con los cursos abiertos en un período
        public List<Curso> Cursos { get; set; }
        // Relación con las matrículas realizadas en un período
        public List<Matricula> Matriculas { get; set; }
    }
}
