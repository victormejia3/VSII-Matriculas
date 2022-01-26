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

        // GET
        //  Presenta el formulario vacio listo para crear una entidad
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST
        //  Guarda una materia
        [HttpPost]
        public IActionResult Create(Materia materia)
        {
            db.materias.Add(materia);
            db.SaveChanges();
            
            TempData["mensaje"] = "La materia se ha creado correctamente";

            return RedirectToAction("Index");
        }
    }
}
