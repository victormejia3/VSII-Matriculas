﻿using CargaDatos;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;
using static CargaDatos.DatosIniciales;

namespace Consola
{
    public class Grabar
    {
        public void DatosIni()
        {
            DatosIniciales datos = new DatosIniciales();
            var listas = datos.Carga();

            // Extraer del diccionario las listas
            var listaConfiguracion = (List<Configuracion>)listas[ListasTipo.Configuracion];
            var listaPeriodos = (List<Periodo>)listas[ListasTipo.Periodos];
            var listaMaterias = (List<Materia>)listas[ListasTipo.Materias];
            var listaCarreras = (List<Carrera>)listas[ListasTipo.Carreras];
            var listaSubMallas = (List<Malla>)listas[ListasTipo.SubMallas];
            var listaMallas = (List<Malla>)listas[ListasTipo.Mallas];
            var listaNiveles = (List<Nivel>)listas[ListasTipo.Niveles];
            var listaCursos = (List<Curso>)listas[ListasTipo.Cursos];

            // Prepara la base de datos
            AcademiaDB db = new AcademiaDB();
            db.PreparaDB();

            // Guarda los datos iniciales
            db.carreras.AddRange(listaCarreras);
            db.periodos.AddRange(listaPeriodos);
            db.materias.AddRange(listaMaterias);
            db.configuracion.AddRange(listaConfiguracion);
            db.mallas.AddRange(listaSubMallas);
            db.mallas.AddRange(listaMallas);
            db.niveles.AddRange(listaNiveles);
            db.cursos.AddRange(listaCursos);

            db.SaveChanges();
        }
        
    }
}
