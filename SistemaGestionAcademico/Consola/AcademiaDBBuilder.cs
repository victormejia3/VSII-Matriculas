using Microsoft.EntityFrameworkCore;
using ModeloDB;
using System.Configuration;

namespace Consola
{
    public class AcademiaDBBuilder
    {
        const string DBTipo = "DBTipo";
        enum DBTipoConn { SqlServer, Postgres, Memoria }
        static AcademiaDB db ;

        public static AcademiaDB Crear()
        {
            //if (db == null)
            //{
                string dbtipo = ConfigurationManager.AppSettings[DBTipo];
                string conn = ConfigurationManager.ConnectionStrings[dbtipo].ConnectionString;

                DbContextOptions<AcademiaDB> contextOptions;

                switch (dbtipo)
                {
                    case "SqlServer":
                        contextOptions = new DbContextOptionsBuilder<AcademiaDB>()
                            .UseSqlServer(conn)
                            .Options;
                        break;
                    case "Postgres":
                        contextOptions = new DbContextOptionsBuilder<AcademiaDB>()
                            .UseNpgsql(conn)
                            .Options;
                        break;
                    default: // Por defecto usa la memoria como base de datos
                        contextOptions = new DbContextOptionsBuilder<AcademiaDB>()
                            .UseInMemoryDatabase(conn)
                            .Options;
                        break;
                }

                db = new AcademiaDB(contextOptions);
            //}            

            return db;
        }
        
}
}
