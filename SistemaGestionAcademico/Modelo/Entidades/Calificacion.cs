using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Calificacion
    {
        public int CalificacionId { get; set; }
        // Relación Uno a Uno
        public int Matricula_DetId { get; set; }
        public Matricula_Det Matricula_Det { get; set; }
        // Composición de las notas
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }

        // Cálculo de la nota final
        public float NotaFinal(float peso1, float peso2, float peso3)
        {
            // Cálculo
            float suma = 0;

            // Modificado por Víctor Mejía
            // 29/01/2021 - 18:45
            // Motivo: resultado negativo de pruebas unitarias
            //suma += MathF.Round(Nota1 * peso1 , 2) ;
            //suma += MathF.Round(Nota2 * peso2 , 2);
            //suma += MathF.Round(Nota3 * peso3 , 2);

            suma += Nota1 * peso1;
            suma += Nota2 * peso2;
            suma += Nota3 * peso3;
            suma = MathF.Round(suma, 2);
            return suma;
        }
        // Verifica si cumple el mínimo
        public bool Aprueba(float peso1, float peso2, float peso3, float NotaMinima)
        {
            bool res;
            res = NotaFinal(peso1, peso2, peso3) >= NotaMinima;
            return res;
        }
    }
}
