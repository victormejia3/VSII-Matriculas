using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    public class CursosController : Controller
    {
        readonly AcademiaDB db;

        public CursosController(AcademiaDB db)
        {
            this.db = db;
        }


        // Obtiene la lista de cursos y lo envía a la vista
        public IActionResult Index()
        {
            IEnumerable<Curso> listaCursos = db.cursos;

            return View(listaCursos);
        }
    }
}
