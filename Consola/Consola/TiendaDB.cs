using Microsoft.EntityFrameworkCore;

namespace Consola
{
    public class TiendaDB : DbContext
    {
        public DbSet<Products> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opciones)
        {
            opciones.UseSqlServer(
                "Server=victor-pc\\sql2012; initial catalog=TiendaDB; trusted_connection=true;"
            );
        }
    }
}
