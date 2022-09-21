using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos
{
    public class ProMatriculas
    {
        public AcademiaDB db { get; set; }

        public ProMatriculas(AcademiaDB db)
        {
            this.db = db;
        }

        public bool Validar(Matricula matricula)
        {
            bool res= true;

            var tmpMatricula = db.matriculas
                .Include(matr => matr.Matricula_Dets)
                    .ThenInclude(det => det.Curso)
                        .ThenInclude(curso => curso.Materia)
                .Single(matr => matr.MatriculaId == matricula.MatriculaId);

            Estudiante estudiante = new Estudiante() { EstudianteId = tmpMatricula.EstudianteId};

            var ProcPreReqs = new ProPrerequisitos(db);
            var ProcMateria = new ProMaterias(db);

            foreach(var det in tmpMatricula.Matricula_Dets)
            {
                var listaPreReq = ProcPreReqs.Prerequisitos(det.Curso.Materia);
                foreach(var matprereq in listaPreReq)
                {
                    bool aprobo = ProcMateria.Aprobo(estudiante, matprereq);
                    Console.WriteLine($"{matprereq.Nombre} {det.MatriculaId} {det.Matricula_DetId} {det.Curso.Nombre}");
                    if (!aprobo) return false;
                }
            }
            return res;
        }
    }
}
