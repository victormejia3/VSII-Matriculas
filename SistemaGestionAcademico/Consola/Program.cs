

using Modelo.Entidades;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        enum tipo {Periodos, Estudiantes, Materias};



        static void Main(string[] args)
        {
            tipo tipolista;

            tipolista = tipo.Periodos;

            var listas = cargadatos();
            

            var x = listas["Periodos"];   


        }






        // ----------------------------------
        static Dictionary<string, object>  cargadatos ()
        {
            List<Estudiante> listaEst = new List<Estudiante>();
            List<Periodo> listaPer = new List<Periodo>();
            List<Materia> listaMat = new List<Materia>();

            Dictionary<string, object> glosario = new Dictionary<string, object>()
            {
                {"Estudiantes", listaEst },
                {"Períodos", listaPer },
                {"Materias", listaMat }
            };

            return glosario;
        }
    }
}
