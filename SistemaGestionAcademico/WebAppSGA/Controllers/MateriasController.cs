using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System.Collections;
using System.Collections.Generic;

namespace WebAppSGA.Controllers
{
    public class MateriasController : Controller
    {
        private readonly AcademiaDB db;

        public MateriasController( AcademiaDB db )
        {
            this.db = db;
        }

        // Listar las materias
        public IActionResult Index()
        {
            IEnumerable<Materia> listaMaterias = db.materias;

            return View(listaMaterias);
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
