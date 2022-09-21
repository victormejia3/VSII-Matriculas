using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TiendaDB DB = new TiendaDB();
            Products esfero = DB.products.Find(3);

            esfero.Nombre = "Esfero de Negro";

            DB.SaveChanges();
        }
    }
}
