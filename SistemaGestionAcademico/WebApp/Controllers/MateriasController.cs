using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    public class MateriasController : Controller
    {
        private readonly AcademiaDB db;

        public MateriasController(AcademiaDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Materia> listaMaterias = db.materias;
            return View(listaMaterias);
        }
    }
}
