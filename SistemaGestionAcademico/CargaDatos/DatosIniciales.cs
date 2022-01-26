﻿using Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListasTipo { 
            Periodos, Estudiantes, Materias, 
            Carreras, SubMallas, Mallas , 
            Configuracion, Niveles, Cursos,
            Matriculas, Matriculas_Dets, Calificaciones,
            Prerequisitos
        }

        public Dictionary<ListasTipo, object> Carga()
        {

            // --------------------------------------------
            // Lista de Periodos
            // --------------------------------------------
            #region
            // Periodo 2020-PA=2
            Periodo p2020_PAO1 = new Periodo()
            {
                FechaInicio = new DateTime(2020, 3, 1),
                FechaFin = new DateTime(2020, 9, 30),
                Estado = "Ejecutado"
            };
            // Periodo 2020-PA=2
            Periodo p2020_PAO2 = new Periodo()
            {
                FechaInicio = new DateTime(2020, 9, 1),
                FechaFin = new DateTime(2021, 3, 31),
                Estado = "Ejecutado"
            };
            // Periodo 2021-PA=1
            Periodo p2021_PAO1 = new Periodo()
            {
                FechaInicio = new DateTime(2021, 4, 1),
                FechaFin = new DateTime(2021, 9, 1),
                Estado = "Ejecutado"
            };
            // Periodo 2020-PA=2
            Periodo p2021_PAO2 = new Periodo()
            {
                FechaInicio = new DateTime(2021, 9, 30),
                FechaFin = new DateTime(2022, 3, 31),
                Estado = "Ejecutado"
            };

            List<Periodo> listaPeriodos = new List<Periodo>()
            {
                p2020_PAO2,p2021_PAO1,p2021_PAO2
            };
            #endregion
            // --------------------------------------------
            // Configuracion
            // --------------------------------------------
            #region
            Configuracion config = new Configuracion()
            {
                EscuelaNombre = "Instituto ITQ",
                CreditoMaximo = 24,
                NotaMinima = 7.0f,
                PesoNota1 = 0.30f,
                PesoNota2 = 0.35f,
                PesoNota3 = 0.35f,
                PeriodoVigente = p2021_PAO2
            };

            List<Configuracion> listaConfiguracion = new List<Configuracion>()
            {
                config
            };
            #endregion
            // --------------------------------------------
            // Lista de Materias
            // --------------------------------------------
            #region
            // Nivel 1
            Materia matMarkDig = new Materia()
            {
                Area = "Marketing",
                Creditos = 3,
                Nombre = "Marketing Digital"
            };

            Materia matApliInter = new Materia()
            {
                Area = "Programación",
                Creditos = 2,
                Nombre = "Aplicaciones de Internet"
            };

            Materia matAutoCon = new Materia()
            {
                Area = "Transversal",
                Creditos = 2,
                Nombre = "Autoconocimiento"
            };

            Materia matConta = new Materia()
            {
                Area = "Tramsversañ",
                Creditos = 3,
                Nombre = "Contabilidad"
            };

            // Nivel 2
            Materia matDisenioWeb = new Materia()
            {
                Area = "Programación",
                Creditos = 3,
                Nombre = "Diseño Web"
            };

            Materia matComunicacionWeb = new Materia()
            {
                Area = "Diseño",
                Creditos = 3,
                Nombre = "Comuniciación Web"
            };

            Materia matNeuroventas = new Materia()
            {
                Area = "Transversal",
                Creditos = 3,
                Nombre = "Neuroventas"
            };

            Materia matAdminDB = new Materia()
            {
                Area = "Bases de Datos",
                Creditos = 2,
                Nombre = "Administración de Bases de Datos"
            };

            // Nivel 3
            Materia matLogProg = new Materia()
            {
                Area = "Programación",
                Creditos = 3,
                Nombre = "Lógica de Programación"
            };

            Materia matProdDig = new Materia()
            {
                Area = "Diseño",
                Creditos = 2,
                Nombre = "Productos Digitales"
            };

            Materia matFotoRedes = new Materia()
            {
                Area = "Diseño",
                Creditos = 2,
                Nombre = "Fotografía para redes sociales"
            };

            Materia matVideoMark = new Materia()
            {
                Area = "Transversal",
                Creditos = 2,
                Nombre = "Video Marketing"
            };

            // Nivel 4
            Materia matProgWeb = new Materia()
            {
                Area = "Programación",
                Creditos = 3,
                Nombre = "Programación Web"
            };

            Materia matELearning = new Materia()
            {
                Area = "Diseño",
                Creditos = 3,
                Nombre = "E-Learning"
            };

            Materia matNeuroMark = new Materia()
            {
                Area = "Transversal",
                Creditos = 2,
                Nombre = "Neuromarketing"
            };

            Materia matEdicVideo = new Materia()
            {
                Area = "Diseño",
                Creditos = 3,
                Nombre = "Edición de Video"
            };

            // Nivel 5
            Materia matSegWeb = new Materia()
            {
                Area = "Programación",
                Creditos = 3,
                Nombre = "Seguridad Web"
            };

            Materia matGoogle = new Materia()
            {
                Area = "Marketing",
                Creditos = 3,
                Nombre = "Google Adwords y Analytics"
            };

            Materia matManualCorp = new Materia()
            {
                Area = "Marketing",
                Creditos = 3,
                Nombre = "Manual Corporativo"
            };

            Materia matPlatDig = new Materia()
            {
                Area = "Programación",
                Creditos = 3,
                Nombre = "Plataformas Digitales"
            };

            List<Materia> listaMaterias = new List<Materia>()
            {
                // Nivel 1
                matMarkDig, matApliInter, matAutoCon, matConta,
                // Nivel 2
                matDisenioWeb, matComunicacionWeb, matNeuroventas, matAdminDB,
                // Nivel 3
                matLogProg,matProdDig, matFotoRedes, matVideoMark,
                // Nivel 4
                matProgWeb, matELearning, matNeuroMark,matEdicVideo,
                // Nivel 5
                matSegWeb, matGoogle, matManualCorp, matPlatDig
            };
            #endregion
            // --------------------------------------------
            // Lista de Carreras
            // --------------------------------------------
            #region
            Carrera carComercio = new Carrera()
            {
                CostoCredito = 23.45f,
                Nombre = "Comercio Electróncio"
            };
            Carrera carSistemas = new Carrera()
            {
                CostoCredito = 28.50f,
                Nombre = "Análisis de Sistemas"
            };

            List<Carrera> listaCarreras = new List<Carrera>()
            {
                carComercio, carSistemas
            };
            #endregion
            // Estudiantes
            #region
            Estudiante estPedro = new Estudiante()
            {
                Nombre = "Pedro Navaja",
                Cedula = "1706856566",
                Email = "pedro234@g.com"
            };
            Estudiante estMaria = new Estudiante()
            {
                Nombre = "María Del Barrio",
                Cedula = "1856214569",
                Email = "mbarrio@h.com"
            };
            Estudiante estJose = new Estudiante()
            {
                Nombre = "José de Arimatea",
                Cedula = "1702185456",
                Email = "belen999@g.com"
            };
            Estudiante estKarla = new Estudiante()
            {
                Nombre = "Karla Sanchez",
                Cedula = "1706564782",
                Email = "karlasanchez123@h.com"
            };

            List<Estudiante> listaEstudiantes = new List<Estudiante>()
            {
                estJose, estKarla, estMaria,estPedro
            };
            #endregion
            // --------------------------------------------
            // Malla de Comercio Electrónico
            // --------------------------------------------
            #region
            // Los prerrequisitos de las mallas
            // Pre requisitos de ProgWeb
            Malla malProgWeb = new Malla()
            {
                Carrera = carComercio,
                Materia = matProgWeb,
                Nivel = "Nivel 4"
            };

            Prerequisito preProgWeb_DisWeb = new Prerequisito()
            {
                Malla = malProgWeb,
                Materia = matDisenioWeb
            };

            Prerequisito preProgWeb_LogProg = new Prerequisito()
            {
                Malla = malProgWeb,
                Materia = matLogProg
            };

            Prerequisito preProgWeb_AdminDB = new Prerequisito()
            {
                Malla = malProgWeb,
                Materia = matAdminDB
            };

            // Pre requisitos de Elearning
            Malla malELearning = new Malla()
            {
                Carrera = carComercio,
                Materia = matELearning,
                Nivel = "Nivel 4"
            };

            Prerequisito preELearning_ProdDig = new Prerequisito()
            {
                Malla = malProgWeb,
                Materia = matProdDig
            };

            Prerequisito preELearning_VidMark = new Prerequisito()
            {
                Malla = malProgWeb,
                Materia = matVideoMark
            };

            // Pre requisitos de ProdDig
            Malla malProdDig = new Malla()
            {
                Carrera = carComercio,
                Materia = matProdDig,
                Nivel = "Nivel 3"
            };

            Prerequisito preProdDig_ComWeb = new Prerequisito()
            {
                Malla = malProgWeb,
                Materia = matComunicacionWeb
            };

            List<Malla> listaSubMallas = new List<Malla>()
            {
                malELearning, malProdDig,malProgWeb
            };
            // Malla padre
            Malla mallaComerio = new Malla()
            {
                Carrera = carComercio,
                SubMallas = listaSubMallas
            };

            List<Malla> listaMallas = new List<Malla>()
            {
                mallaComerio
            };
            #endregion
            // --------------------------------------------
            // Niveles
            // --------------------------------------------
            #region
            // Nivel 1 ************************************
            Nivel nivel10 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 1",
                Orden = 10,
                Materia = matMarkDig
            };

            Nivel nivel11 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 1",
                Orden = 11,
                Materia = matApliInter
            };
            Nivel nivel12 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 1",
                Orden = 12,
                Materia = matAutoCon
            };
            Nivel nivel13 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 1",
                Orden = 13,
                Materia = matConta
            };
            // Nivel 2 ************************************
            Nivel nivel20 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 2",
                Orden = 20,
                Materia = matDisenioWeb
            };

            Nivel nivel21 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 2",
                Orden = 21,
                Materia = matComunicacionWeb
            };
            Nivel nivel22 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 2",
                Orden = 22,
                Materia = matNeuroventas
            };
            Nivel nivel23 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 2",
                Orden = 23,
                Materia = matAdminDB
            };
            // Nivel 3 ************************************
            Nivel nivel30 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 3",
                Orden = 30,
                Materia = matLogProg
            };

            Nivel nivel31 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 3",
                Orden = 31,
                Materia = matProdDig
            };
            Nivel nivel32 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 3",
                Orden = 32,
                Materia = matFotoRedes
            };
            Nivel nivel33 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 3",
                Orden = 33,
                Materia = matVideoMark
            };
            // Nivel 4 ************************************
            Nivel nivel40 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 4",
                Orden = 40,
                Materia = matProgWeb
            };

            Nivel nivel41 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 4",
                Orden = 41,
                Materia = matELearning
            };
            Nivel nivel42 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 4",
                Orden = 42,
                Materia = matNeuroMark
            };
            Nivel nivel43 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 4",
                Orden = 43,
                Materia = matEdicVideo
            };
            // Nivel 5 ************************************
            Nivel nivel50 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 5",
                Orden = 50,
                Materia = matSegWeb
            };

            Nivel nivel51 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 5",
                Orden = 51,
                Materia = matGoogle
            };
            Nivel nivel52 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 5",
                Orden = 52,
                Materia = matManualCorp
            };
            Nivel nivel53 = new Nivel()
            {
                Malla = mallaComerio,
                Nombre = "Nivel 5",
                Orden = 53,
                Materia = matPlatDig
            };

            List<Nivel> listaNiveles = new List<Nivel>()
            {
                nivel10, nivel11, nivel12, nivel13,
                nivel20, nivel21, nivel22, nivel23,
                nivel30, nivel31, nivel32, nivel33,
                nivel40, nivel41, nivel42, nivel43,
                nivel50, nivel51, nivel52, nivel53
            };
            #endregion
            // --------------------------------------------
            // Cursos
            // --------------------------------------------
            #region
            Curso cur2020_1 = new Curso()
            {
                Carrera = carComercio,
                Periodo = p2020_PAO1,
                Jornada = "Matutino",
                Materia = matMarkDig,
                Nombre = "COM-2020-1-MAT Marketing Digital",
                FechaInicio = new DateTime(2020, 3, 1),
                FechaFin = new DateTime(2020, 4, 15)
            };

            #endregion
            // --------------------------------------------
            // Diccionario contiene todas las listas
            // --------------------------------------------
            Dictionary<ListasTipo, object> dicListasDatos = new Dictionary<ListasTipo, object>()
            {
                { ListasTipo.Periodos, listaPeriodos },
                { ListasTipo.Estudiantes, listaEstudiantes },
                { ListasTipo.Materias, listaMaterias },
                { ListasTipo.Carreras, listaCarreras },
                { ListasTipo.SubMallas, listaSubMallas},
                { ListasTipo.Mallas,listaMallas },
                { ListasTipo.Configuracion, listaConfiguracion},
                { ListasTipo.Niveles, listaNiveles}
            };

            return dicListasDatos;
        }
    }
}
