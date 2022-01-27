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

        //  Creación de materia
        //  Presenta el formulario vacio listo para crear una entidad
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //  Guarda una materia
        [HttpPost]
        public IActionResult Create(Materia materia)
        {
            db.materias.Add(materia);
            db.SaveChanges();

            TempData["mensaje"] = $"La materia {materia.Nombre} ha sido creada exitosamente";

            return RedirectToAction("Index");
        }

        //  Edición de materia
        //  Presenta el formulario lleno con los datos de la materia seleccionada
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Consultar la materia por medio del id
            Materia materia = db.materias.Find(id);

            return View(materia);
        }

        //  Actualiza una materia
        [HttpPost]
        public IActionResult Edit(Materia materia)
        {
            db.materias.Update(materia);
            db.SaveChanges();

            TempData["mensaje"] = $"La materia {materia.Nombre} ha sido actualizada exitosamente";

            return RedirectToAction("Index");
        }

        //  Borrado de materia
        //  Presenta el formulario lleno con los datos de la materia seleccionada
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Consultar la materia por medio del id
            Materia materia = db.materias.Find(id);

            return View(materia);
        }

        //  Borrar una materia
        [HttpPost]
        public IActionResult Delete(Materia materia)
        {
            db.materias.Remove(materia);
            db.SaveChanges();

            TempData["mensaje"] = $"La materia {materia.Nombre} ha sido eliminada exitosamente";

            return RedirectToAction("Index");
        }
    }
}
