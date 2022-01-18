using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace ModeloDB
{
    public class AcademiaDB : DbContext
    {
        // Declaración de las entidades del modelo
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Malla> Mallas { get; set; }
        public DbSet<Materia> Materias { get; set; }
        // Configuración de la conección
    }
}
