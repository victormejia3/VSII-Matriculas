using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Malla
    {
        public int MallaId { get; set; }
        public string Nivel { get; set; }
        // Relación con la Carrera
        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }
        // Relación con la Materia
        public int? MateriaId { get; set; }
        public Materia Materia { get; set; }
        // Grafo: Materias pre-requisitos
        public List<Prerequisito> PreRequisitos { get; set; }
        // Malla padre
        public Malla MallaPadre { get; set; }
        public int? MallaPadreId { get; set; }
        // Sub mallas
        public List<Malla> SubMallas { get; set; }
    }
}
