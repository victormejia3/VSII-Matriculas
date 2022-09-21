using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using ModeloDB;
using Procesos;
using System.Linq;

namespace WebApp.Controllers
{
    public class MatriculasController : Controller
    {
        // DbContext
        private readonly AcademiaDB db;

        public MatriculasController(AcademiaDB db)
        {
            this.db = db;
        }

        // Listado de matrículas
        public IActionResult Index()
        {
            var listaMatriculas = db.matriculas
                .Include(matricula => matricula.Carrera)
                .Include(matricula => matricula.Estudiante)
                .Include(matricula => matricula.Periodo)
                ;

            return View(listaMatriculas);
        }

        // Pantalla para la validación de la matrícula
        public IActionResult Validar(int id)
        {
            var matricula = db.matriculas
                .Include(matricula => matricula.Carrera)
                .Include(matricula => matricula.Estudiante)
                .Include(matricula => matricula.Periodo)
                .Include(matricula => matricula.Matricula_Dets)
                    .ThenInclude(matricula_dets => matricula_dets.Calificacion)
                .Include(matricula => matricula.Matricula_Dets)
                    .ThenInclude(matricula_dets => matricula_dets.Curso)
                        .ThenInclude(curso => curso.Materia)
                .Single(matricula => matricula.MatriculaId == id)   // Consulta la mátricula id
                ;

            // Preparar la clase para el cálculo de las calificaciones
            var configuracion = db.configuracion.Single();
            CalcCalificaciones calcCalificaciones = new CalcCalificaciones(configuracion);

            ViewBag.CalcCalificaciones = calcCalificaciones;

            return View(matricula);
        }

        //Proceso de validación
        [HttpPost]
        public IActionResult Validar(Matricula matricula)
        {
            string mensaje="";

            var procMatricula = new ProMatriculas(db);
            var tmpMatricula = db.matriculas.Find(matricula.MatriculaId);

            if (tmpMatricula.Estado == MatriculaEstado.Pendiente)
            {
                if (procMatricula.Validar(matricula))
                {
                    tmpMatricula.Estado = MatriculaEstado.Aprobada;
                    mensaje = $"La matrícula {matricula.MatriculaId} ha sido APROBADA";
                }
                else
                {
                    tmpMatricula.Estado = MatriculaEstado.Rechazada;
                    mensaje = $"La matrícula {matricula.MatriculaId} ha sido RECHAZADA";
                }
                db.SaveChanges();
            }
            else
            {
                mensaje = $"La matrícula {matricula.MatriculaId} no fue procesada porque no se encuentra en estado pendiente";
            }

            TempData["mensaje"] = mensaje;

            return RedirectToAction("Index");
        }
    }
}
