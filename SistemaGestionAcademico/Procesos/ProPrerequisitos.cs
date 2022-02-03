using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;

namespace Procesos
{
    public class ProPrerequisitos
    {
        public AcademiaDB db { get; set; }

        public ProPrerequisitos(AcademiaDB db)
        {
            this.db = db;
        }

        public List<Materia> Prerequisitos(Materia materia) 
        {
            var prerequisitos = new List<Materia>();

            var tmpMateria = db.materias
                .Include(mat => mat.Malla)
                .Single(mat => mat.MateriaId == materia.MateriaId);

            if( tmpMateria.Malla == null) return null;

            var tmpMalla = db.mallas
                .Include(malla => malla.PreRequisitos)
                    .ThenInclude(prerequisitos => prerequisitos.Materia)
                .Single(malla => malla.MallaId == tmpMateria.Malla.MallaId);

            if (tmpMalla.PreRequisitos == null) return null;

            foreach(var prereq in tmpMalla.PreRequisitos)
            {
                prerequisitos.Add(prereq.Materia);
            }
                
            return prerequisitos;
        }
    }
}
