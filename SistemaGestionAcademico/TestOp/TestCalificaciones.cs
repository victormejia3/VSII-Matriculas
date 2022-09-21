using Consola;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using ModeloDB;
using Procesos;
using System;
using System.Linq;
using Xunit;

namespace TestOp
{
    public class TestCalificaciones
    {
        [Theory]
        [InlineData(1, 5.26f)]
        [InlineData(2, 7.27f)]
        [InlineData(3, 8.57f)]
        [InlineData(4, 8.49f)]
        [InlineData(5, 6.39f)]
        [InlineData(6, 8.56f)]
        [InlineData(7, 7.94f)]
        [InlineData(8, 7.05f)]
        [InlineData(9, 5.79f)]
        [InlineData(10, 8.34f)]
        [InlineData(11, 6.95f)]
        [InlineData(12, 7.48f)]
        [InlineData(13, 7.84f)]
        [InlineData(14, 7.89f)]
        [InlineData(15, 6.35f)]
        [InlineData(16, 7.38f)]
        [InlineData(17, 7.95f)]
        [InlineData(18, 7.34f)]
        [InlineData(19, 7.89f)]
        [InlineData(20, 7.66f)]
        public void TestCalcCalificacion_30_30_40(int califId, float resEsperado)
        {
            var db = DBBuilder.GetDB();
            
            var calificacion = db.calificaciones
                .Include( calif => calif.Matricula_Det)
                    .ThenInclude(det => det.Matricula)
                        .ThenInclude(matr => matr.Estudiante)
                .Single( calif => calif.CalificacionId == califId);
            
            var config = new Configuracion() {PesoNota1=0.3f, PesoNota2 = 0.3f, PesoNota3 = 0.4f,NotaMinima=7f };
            var calc = new CalcCalificaciones(config);
            float resCalculado = calc.NotaFinal(calificacion);

            string mensaje = $" {resEsperado} distinto {resCalculado}: {calificacion.Matricula_Det.Matricula.Estudiante.Nombre}";

            Assert.True(resEsperado == resCalculado,  mensaje);
        }


        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, true)]
        [InlineData(5, false)]
        [InlineData(6, true)]
        [InlineData(7, true)]
        [InlineData(8, true)]
        [InlineData(9, false)]
        [InlineData(10, true)]
        [InlineData(11, false)]
        [InlineData(12, true)]
        [InlineData(13, true)]
        [InlineData(14, true)]
        [InlineData(15, false)]
        [InlineData(16, true)]
        [InlineData(17, true)]
        [InlineData(18, true)]
        [InlineData(19, true)]
        [InlineData(20, true)]
        public void TestCalcCalificacion_30_30_40_Aprobado(int califId, bool resEsperado)
        {
            var db = DBBuilder.GetDB();

            var calificacion = db.calificaciones
                .Include(calif => calif.Matricula_Det)
                    .ThenInclude(det => det.Matricula)
                        .ThenInclude(matr => matr.Estudiante)
                .Single(calif => calif.CalificacionId == califId);

            var config = new Configuracion() { PesoNota1 = 0.3f, PesoNota2 = 0.3f, PesoNota3 = 0.4f, NotaMinima = 7f };
            var calc = new CalcCalificaciones(config);
            bool resCalculado = calc.Aprobado(calificacion);

            string mensaje = $" {resEsperado} distinto {resCalculado}: {calificacion.Matricula_Det.Matricula.Estudiante.Nombre}";

            Assert.True(resEsperado == resCalculado, mensaje);
        }

        [Theory]
        [InlineData(1, 5.26f)]
        [InlineData(2, 7.27f)]
        [InlineData(3, 8.57f)]
        [InlineData(4, 8.49f)]
        [InlineData(5, 6.39f)]
        [InlineData(6, 8.56f)]
        [InlineData(7, 7.94f)]
        [InlineData(8, 7.05f)]
        [InlineData(9, 5.79f)]
        [InlineData(10, 8.34f)]
        [InlineData(11, 6.95f)]
        [InlineData(12, 7.48f)]
        [InlineData(13, 7.84f)]
        [InlineData(14, 7.89f)]
        [InlineData(15, 6.35f)]
        [InlineData(16, 7.38f)]
        [InlineData(17, 7.95f)]
        [InlineData(18, 7.34f)]
        [InlineData(19, 7.89f)]
        [InlineData(20, 7.66f)]
        public void TestCalcCalificacion_35_35_30(int califId, float resEsperado)
        {
            var db = DBBuilder.GetDB();

            var calificacion = db.calificaciones
                .Include(calif => calif.Matricula_Det)
                    .ThenInclude(det => det.Matricula)
                        .ThenInclude(matr => matr.Estudiante)
                .Single(calif => calif.CalificacionId == califId);

            var config = new Configuracion() { PesoNota1 = 0.35f, PesoNota2 = 0.35f, PesoNota3 = 0.3f, NotaMinima = 7f };
            var calc = new CalcCalificaciones(config);
            float resCalculado = calc.NotaFinal(calificacion);

            string mensaje = $" {resEsperado} distinto {resCalculado}: {calificacion.Matricula_Det.Matricula.Estudiante.Nombre}";

            Assert.True(resEsperado == resCalculado, mensaje);
        }


        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, true)]
        [InlineData(5, false)]
        [InlineData(6, true)]
        [InlineData(7, true)]
        [InlineData(8, true)]
        [InlineData(9, false)]
        [InlineData(10, true)]
        [InlineData(11, false)]
        [InlineData(12, true)]
        [InlineData(13, true)]
        [InlineData(14, true)]
        [InlineData(15, false)]
        [InlineData(16, true)]
        [InlineData(17, true)]
        [InlineData(18, true)]
        [InlineData(19, true)]
        [InlineData(20, true)]
        public void TestCalcCalificacion_35_35_30_Aprobado(int califId, bool resEsperado)
        {
            var db = DBBuilder.GetDB();

            var calificacion = db.calificaciones
                .Include(calif => calif.Matricula_Det)
                    .ThenInclude(det => det.Matricula)
                        .ThenInclude(matr => matr.Estudiante)
                .Single(calif => calif.CalificacionId == califId);

            var config = new Configuracion() { PesoNota1 = 0.35f, PesoNota2 = 0.35f, PesoNota3 = 0.3f, NotaMinima = 7f };
            var calc = new CalcCalificaciones(config);
            bool resCalculado = calc.Aprobado(calificacion);

            string mensaje = $" {resEsperado} distinto {resCalculado}: {calificacion.Matricula_Det.Matricula.Estudiante.Nombre}";

            Assert.True(resEsperado == resCalculado, mensaje);
        }


        [Theory]
        [InlineData(1, 5.26f)]
        [InlineData(2, 7.27f)]
        [InlineData(3, 8.57f)]
        [InlineData(4, 8.49f)]
        [InlineData(5, 6.39f)]
        [InlineData(6, 8.56f)]
        [InlineData(7, 7.94f)]
        [InlineData(8, 7.05f)]
        [InlineData(9, 5.79f)]
        [InlineData(10, 8.34f)]
        [InlineData(11, 6.95f)]
        [InlineData(12, 7.48f)]
        [InlineData(13, 7.84f)]
        [InlineData(14, 7.89f)]
        [InlineData(15, 6.35f)]
        [InlineData(16, 7.38f)]
        [InlineData(17, 7.95f)]
        [InlineData(18, 7.34f)]
        [InlineData(19, 7.89f)]
        [InlineData(20, 7.66f)]
        public void TestCalcCalificacion_30_35_35(int califId, float resEsperado)
        {
            var db = DBBuilder.GetDB();

            var calificacion = db.calificaciones
                .Include(calif => calif.Matricula_Det)
                    .ThenInclude(det => det.Matricula)
                        .ThenInclude(matr => matr.Estudiante)
                .Single(calif => calif.CalificacionId == califId);

            var config = new Configuracion() { PesoNota1 = 0.30f, PesoNota2 = 0.35f, PesoNota3 = 0.35f, NotaMinima = 7f };
            var calc = new CalcCalificaciones(config);
            float resCalculado = calc.NotaFinal(calificacion);

            string mensaje = $" {resEsperado} distinto {resCalculado}: {calificacion.Matricula_Det.Matricula.Estudiante.Nombre}";

            Assert.True(resEsperado == resCalculado, mensaje);
        }


        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, true)]
        [InlineData(5, false)]
        [InlineData(6, true)]
        [InlineData(7, true)]
        [InlineData(8, true)]
        [InlineData(9, false)]
        [InlineData(10, true)]
        [InlineData(11, false)]
        [InlineData(12, true)]
        [InlineData(13, true)]
        [InlineData(14, true)]
        [InlineData(15, false)]
        [InlineData(16, true)]
        [InlineData(17, true)]
        [InlineData(18, true)]
        [InlineData(19, true)]
        [InlineData(20, true)]
        public void TestCalcCalificacion_30_35_35_Aprobado(int califId, bool resEsperado)
        {
            var db = DBBuilder.GetDB();

            var calificacion = db.calificaciones
                .Include(calif => calif.Matricula_Det)
                    .ThenInclude(det => det.Matricula)
                        .ThenInclude(matr => matr.Estudiante)
                .Single(calif => calif.CalificacionId == califId);

            var config = new Configuracion() { PesoNota1 = 0.30f, PesoNota2 = 0.35f, PesoNota3 = 0.35f, NotaMinima = 7f };
            var calc = new CalcCalificaciones(config);
            bool resCalculado = calc.Aprobado(calificacion);

            string mensaje = $" {resEsperado} distinto {resCalculado}: {calificacion.Matricula_Det.Matricula.Estudiante.Nombre}";

            Assert.True(resEsperado == resCalculado, mensaje);
        }
    }
}
