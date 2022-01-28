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

        // Creación de una nueva materia
        //  - Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //  - Grabar una materia
        [HttpPost]
        public IActionResult Create( Materia materia )
        {
            db.materias.Add(materia);
            db.SaveChanges();

            TempData["mensaje"] = $"La materia {materia.Nombre} ha sido creada exitosamente";

            return RedirectToAction("Index");
        }

        // Edición de una materia
        //  - Enviar a un formulario con los datos de la materia seleccionada
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Materia materia = db.materias.Find(id);

            return View(materia);
        }
        //  - Actualizar una materia
        [HttpPost]
        public IActionResult Edit(Materia materia)
        {
            db.materias.Update(materia);
            db.SaveChanges();

            TempData["mensaje"] = $"La materia {materia.Nombre} ha sido actualizada exitosamente";

            return RedirectToAction("Index");
        }

        // Borrado de una materia
        //  - Enviar a un formulario con los datos de la materia a eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Materia materia = db.materias.Find(id);

            return View(materia);
        }
        //  - Eliminar una materia
        [HttpPost]
        public IActionResult Delete(Materia materia)
        {
            db.materias.Remove(materia);
            db.SaveChanges();

            TempData["mensaje"] = $"La materia ha sido eliminada exitosamente";

            return RedirectToAction("Index");
        }

    }
}
