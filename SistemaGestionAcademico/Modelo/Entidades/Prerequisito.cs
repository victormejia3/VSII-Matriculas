﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Prerequisito
    {
        public int MallaId { get; set; }
        public int MateriaId { get; set; }
        // Relaciones
        public Malla Malla { get; set; }
        public Materia Materia { get; set; }
    }
}
