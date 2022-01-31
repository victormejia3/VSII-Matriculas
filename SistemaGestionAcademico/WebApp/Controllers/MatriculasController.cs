using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    public class MatriculasController : Controller
    {
        private readonly AcademiaDB db;

        public MatriculasController(AcademiaDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Matricula> listaMatriculas = db.matriculas
                .Include(matricula => matricula.Estudiante)
                .Include(matricula => matricula.Periodo);

            return View(listaMatriculas);
        }
    }
}
