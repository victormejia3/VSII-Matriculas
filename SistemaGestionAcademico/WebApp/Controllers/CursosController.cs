using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;

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
            IEnumerable<Curso> listaCursos = 
                db.cursos
                    .Include(curso => curso.Carrera)
                    .Include(curso => curso.Materia)
                    .Include(curso => curso.Periodo);

            // Lista de carreras
            List<Carrera> listaCarreras = db.carreras.ToList();
            listaCarreras.Insert(0, new Carrera() { CarreraId = 0, Nombre = "Elije una carrera..." });

            ViewBag.ListofCarreras = listaCarreras;

            return View(listaCursos);
        }
    }
}
