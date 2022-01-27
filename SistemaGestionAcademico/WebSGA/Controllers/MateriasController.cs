using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;

namespace WebSGA.Controllers
{
    public class MateriasController : Controller
    {
        private readonly AcademiaDB db;

        public MateriasController(AcademiaDB db)
        {
            this.db = db;
        }

        // Recupera la lista de materias y envía hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Materia> listaMaterias = db.materias;

            return View(listaMaterias);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
