using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class Repositorio : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        override protected void OnConfiguring (DbContextOptionsBuilder opciones)
        {
            opciones.UseSqlServer("server=victor-pc\\sql2012;initial catalog=Insti; trusted_connection=true;");
        }
    }
}
