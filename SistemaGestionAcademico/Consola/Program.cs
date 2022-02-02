using Procesos;
using System.Linq;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grabar grabar = new Grabar();
            grabar.DatosIni();

            using(var db = AcademiaDBBuilder.Crear())
            {
                var matProgWeb = db.materias
                    .Single(materia => materia.Nombre=="Programación Web");

                ProPrerequisitos opPrerequisitos = new ProPrerequisitos();

                var lista = opPrerequisitos.Prerequisitos(matProgWeb);
            }
        }
    }
}
