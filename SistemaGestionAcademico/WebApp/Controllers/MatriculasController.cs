using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModeloDB;
using System.Linq;

namespace WebApp.Controllers
{
    public class MatriculasController : Controller
    {
        // La instancia del DBContext
        private readonly AcademiaDB db;

        public MatriculasController(AcademiaDB db)
        {
            this.db = db;
        }

        // Listado de matrículas
        public IActionResult Index()
        {
            // Consultar la lista de matrículas
            var listaMatriculas = db.matriculas
                .Include(matricula => matricula.Carrera)
                .Include(matricula => matricula.Estudiante)
                .Include(matricula => matricula.Periodo);

            return View(listaMatriculas);
        }

        // Formulario de validación de matrículas
        [HttpGet]
        public IActionResult Validar(int id)
        {
            // Consultar la matrícula
            var modeloMatricula = db.matriculas
                .Include(matricula => matricula.Carrera)
                .Include(matricula => matricula.Estudiante)
                .Include(matricula => matricula.Periodo)
                .Include(matricula => matricula.Matricula_Dets)
                    .ThenInclude(matricula_dets => matricula_dets.Calificacion)
                .Include(matricula => matricula.Matricula_Dets)
                    .ThenInclude(matricula_dets => matricula_dets.Curso)
                        .ThenInclude(curso => curso.Materia)
                .Single(matricula => matricula.MatriculaId == id);

            return View(modeloMatricula);
        }
    }
}
