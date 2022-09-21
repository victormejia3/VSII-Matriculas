using Modelo.Entidades;
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
            // -- 2019
            //    Periodo 2019-PAO1
            Periodo per2019_PAO1 = new Periodo()
            {
                Nombre = "2019 PAO1",
                Anio = 2019,
                FechaInicio = new DateTime(2019, 3, 1),
                FechaFin = new DateTime(2019, 9, 30),
                Estado = PeriodoEstado.Cerrado
            };
            //    Periodo 2019-PAO2
            Periodo per2019_PAO2 = new Periodo()
            {
                Nombre = "2019 PAO2",
                Anio = 2019,
                FechaInicio = new DateTime(2019, 9, 1),
                FechaFin = new DateTime(2019, 3, 31),
                Estado = PeriodoEstado.Cerrado
            };
            // -- 2020
            //    Periodo 2020-PAO1
            Periodo per2020_PAO1 = new Periodo()
            {
                Nombre = "2020 PAO1",
                Anio = 2020,
                FechaInicio = new DateTime(2020, 3, 1),
                FechaFin = new DateTime(2020, 9, 30),
                Estado = PeriodoEstado.Cerrado
            };
            //    Periodo 2020-PAO2
            Periodo per2020_PAO2 = new Periodo()
            {
                Nombre = "2020 PAO2",
                Anio = 2020,
                FechaInicio = new DateTime(2020, 9, 1),
                FechaFin = new DateTime(2021, 3, 31),
                Estado = PeriodoEstado.Cerrado
            };
            // -- 2021
            //    Periodo 2021-PAO1
            Periodo per2021_PAO1 = new Periodo()
            {
                Nombre = "2021 PAO1",
                Anio = 2021,
                FechaInicio = new DateTime(2021, 4, 1),
                FechaFin = new DateTime(2021, 9, 1),
                Estado = PeriodoEstado.Cerrado
            };
            //    Periodo 2021-PAO2
            Periodo per2021_PAO2 = new Periodo()
            {
                Nombre = "2021 PAO2",
                Anio = 2021,
                FechaInicio = new DateTime(2021, 9, 30),
                FechaFin = new DateTime(2022, 3, 31),
                Estado = PeriodoEstado.Abierto
            };

            List<Periodo> listaPeriodos = new List<Periodo>()
            {
                // 2019
                per2019_PAO1, per2019_PAO2,
                // 2020
                per2020_PAO1, per2020_PAO2,
                // 2021
                per2021_PAO1, per2021_PAO2
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
                PeriodoVigente = per2021_PAO2
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
                Malla = malELearning,
                Materia = matProdDig
            };

            Prerequisito preELearning_VidMark = new Prerequisito()
            {
                Malla = malELearning,
                Materia = matVideoMark
            };

            // Pre requisitos de ProdDig
            //Malla malProdDig = new Malla()
            //{
            //    Carrera = carComercio,
            //    Materia = matProdDig,
            //    Nivel = "Nivel 3"
            //};

            //Prerequisito preProdDig_ComWeb = new Prerequisito()
            //{
            //    Malla = malProdDig,
            //    Materia = matComunicacionWeb
            //};

            List<Malla> listaSubMallas = new List<Malla>()
            {
                malELearning, 
                //malProdDig,
                malProgWeb
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


            List<Prerequisito> listaPrerequisitos = new List<Prerequisito>()
            {
                preELearning_ProdDig, preELearning_VidMark, 
                //preProdDig_ComWeb,
                preProgWeb_AdminDB, preProgWeb_DisWeb, preProgWeb_LogProg
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
            // - Nivel 2
            Curso cur2020_2_DiseWeb = new Curso()
            {
                Carrera = carComercio,
                Periodo = per2020_PAO2,
                Jornada = JornadaTipo.Diurno,
                Materia = matDisenioWeb,
                Nombre = "COM-2020-2-MAT "+matDisenioWeb.Nombre,
                FechaInicio = new DateTime(2020, 3, 1),
                FechaFin = new DateTime(2020, 4, 30)
            };
            Curso cur2020_2_ComWeb = new Curso()
            {
                Carrera = carComercio,
                Periodo = per2020_PAO2,
                Jornada = JornadaTipo.Diurno,
                Materia = matComunicacionWeb,
                Nombre = "COM-2020-2-MAT " + matComunicacionWeb.Nombre,
                FechaInicio = new DateTime(2020, 3, 1),
                FechaFin = new DateTime(2020, 4, 30)
            };
            Curso cur2020_2_NeuroVen = new Curso()
            {
                Carrera = carComercio,
                Periodo = per2020_PAO2,
                Jornada = JornadaTipo.Diurno,
                Materia = matNeuroventas,
                Nombre = "COM-2020-2-MAT " + matNeuroventas.Nombre,
                FechaInicio = new DateTime(2020, 5, 1),
                FechaFin = new DateTime(2020, 6, 30)
            };
            Curso cur2020_2_AdminDB = new Curso()
            {
                Carrera = carComercio,
                Periodo = per2020_PAO2,
                Jornada = JornadaTipo.Diurno,
                Materia = matAdminDB,
                Nombre = "COM-2020-2-MAT " + matAdminDB.Nombre,
                FechaInicio = new DateTime(2020, 5, 1),
                FechaFin = new DateTime(2020, 6, 30)
            };
            // - Nivel 3 -----------------------------------
            Curso cur2021_1_LogProg = new Curso()
            {
                Carrera = carComercio,
                Periodo = per2021_PAO1,
                Jornada = JornadaTipo.Diurno,
                Materia = matLogProg,
                Nombre = "COM-2021-1-MAT " + matLogProg.Nombre,
                FechaInicio = new DateTime(2021, 3, 1),
                FechaFin = new DateTime(2021, 4, 30)
            };
            Curso cur2021_1_ProdDig = new Curso()
            {
                Carrera = carComercio,
                Periodo = per2021_PAO1,
                Jornada = JornadaTipo.Diurno,
                Materia = matProdDig,
                Nombre = "COM-2021-1-MAT " + matProdDig.Nombre,
                FechaInicio = new DateTime(2020, 3, 1),
                FechaFin = new DateTime(2020, 4, 30)
            };
            Curso cur2021_1_FotoRedes = new Curso()
            {
                Carrera = carComercio,
                Periodo = per2021_PAO1,
                Jornada = JornadaTipo.Diurno,
                Materia = matFotoRedes,
                Nombre = "COM-2021-1-MAT " + matFotoRedes.Nombre,
                FechaInicio = new DateTime(2020, 5, 1),
                FechaFin = new DateTime(2020, 6, 30)
            };
            Curso cur2021_1_VideoMark = new Curso()
            {
                Carrera = carComercio,
                Periodo = per2021_PAO1,
                Jornada = JornadaTipo.Diurno,
                Materia = matVideoMark,
                Nombre = "COM-2021-1-MAT " + matVideoMark.Nombre,
                FechaInicio = new DateTime(2020, 5, 1),
                FechaFin = new DateTime(2020, 6, 30)
            };
            // - Nivel 4 -----------------------------------
            Curso cur2021_2_ProgWeb = new Curso()
            {
                Carrera = carComercio,
                Periodo = per2021_PAO2,
                Jornada = JornadaTipo.Diurno,
                Materia = matProgWeb,
                Nombre = "COM-2021-2-MAT " + matProgWeb.Nombre,
                FechaInicio = new DateTime(2021, 7, 1),
                FechaFin = new DateTime(2021, 8, 30)
            };
            Curso cur2021_2_ELearning = new Curso()
            {
                Carrera = carComercio,
                Periodo = per2021_PAO2,
                Jornada = JornadaTipo.Diurno,
                Materia = matELearning,
                Nombre = "COM-2021-2-MAT " + matELearning.Nombre,
                FechaInicio = new DateTime(2020, 7, 1),
                FechaFin = new DateTime(2020, 8, 30)
            };
            Curso cur2021_2_NeuroMark = new Curso()
            {
                Carrera = carComercio,
                Periodo = per2021_PAO2,
                Jornada = JornadaTipo.Diurno,
                Materia = matNeuroMark,
                Nombre = "COM-2021-2-MAT " + matNeuroMark.Nombre,
                FechaInicio = new DateTime(2020, 9, 1),
                FechaFin = new DateTime(2020, 10, 30)
            };
            Curso cur2021_2_EdiVideo = new Curso()
            {
                Carrera = carComercio,
                Periodo = per2021_PAO2,
                Jornada = JornadaTipo.Diurno,
                Materia = matEdicVideo,
                Nombre = "COM-2021-12-MAT " + matEdicVideo.Nombre,
                FechaInicio = new DateTime(2020, 9, 1),
                FechaFin = new DateTime(2020, 10, 30)
            };

            List<Curso> listaCursos = new List<Curso>()
            {
                // Nivel 2
                cur2020_2_DiseWeb, cur2020_2_AdminDB, cur2020_2_ComWeb, cur2020_2_NeuroVen,
                // Nivel 3
                cur2021_1_FotoRedes, cur2021_1_LogProg, cur2021_1_ProdDig, cur2021_1_VideoMark,
                // Nivel 4
                cur2021_2_EdiVideo, cur2021_2_ELearning, cur2021_2_NeuroMark, cur2021_2_ProgWeb
            };
            #endregion

            // --------------------------------------------
            // Matrículas
            // --------------------------------------------
            #region
            // [] ---------------------------------------------------------------
            Matricula matPedro_2020_PAO2 = new Matricula()
            {
                Carrera = carComercio,
                Estado = MatriculaEstado.Aprobada,
                Estudiante = estPedro,
                Fecha = new DateTime(2020, 1, 1),
                Periodo = per2020_PAO2,
                Matricula_Dets = new List<Matricula_Det>()
                {
                    new Matricula_Det()
                    {
                        Curso=cur2020_2_DiseWeb,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 5.55f, Nota2 = 4.34f, Nota3 = 5.74f
                        }
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2020_2_AdminDB,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 8.78f, Nota2 = 7.12f, Nota3 = 6.25f
                        }
                    }
                }
            };
            // [] ---------------------------------------------------------------
            Matricula matPedro_2021_PAO1 = new Matricula()
            {
                Carrera = carComercio,
                Estado = MatriculaEstado.Aprobada,
                Estudiante = estPedro,
                Fecha = new DateTime(2021, 1, 1),
                Periodo = per2021_PAO1,
                Matricula_Dets = new List<Matricula_Det>()
                {
                    new Matricula_Det()
                    {
                        Curso=cur2021_1_LogProg,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 6.65f, Nota2 = 8.94f, Nota3 = 9.74f
                        }
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2021_1_ProdDig,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 7.84f, Nota2 = 9.12f, Nota3 = 8.50f
                        }
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2021_1_VideoMark,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 4.84f, Nota2 = 5.12f, Nota3 = 8.50f
                        }
                    }
                }
            };
            // [] ---------------------------------------------------------------
            Matricula matPedro_2021_PAO2 = new Matricula()
            {
                Carrera = carComercio,
                Estado = MatriculaEstado.Pendiente,
                Estudiante = estPedro,
                Fecha = new DateTime(2021, 1, 1),
                Periodo = per2021_PAO2,
                Matricula_Dets = new List<Matricula_Det>()
                {
                    new Matricula_Det()
                    {
                        Curso=cur2021_2_ProgWeb
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2021_2_ELearning
                    }
                }
            };
            // [] ---------------------------------------------------------------
            Matricula matJose_2020_PAO2 = new Matricula()
            {
                Carrera = carComercio,
                Estado = MatriculaEstado.Aprobada,
                Estudiante = estJose,
                Fecha = new DateTime(2020, 1, 1),
                Periodo = per2020_PAO2,
                Matricula_Dets = new List<Matricula_Det>()
                {
                    new Matricula_Det()
                    {
                        Curso=cur2020_2_DiseWeb,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 8.55f, Nota2 = 8.34f, Nota3 = 8.74f
                        }
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2020_2_AdminDB,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 8.78f, Nota2 = 9.33f, Nota3 = 6.27f
                        }
                    }
                }
            };
            // [] ---------------------------------------------------------------
            Matricula matJose_2021_PAO1 = new Matricula()
            {
                Carrera = carComercio,
                Estado = MatriculaEstado.Aprobada,
                Estudiante = estJose,
                Fecha = new DateTime(2021, 1, 1),
                Periodo = per2021_PAO1,
                Matricula_Dets = new List<Matricula_Det>()
                {
                    new Matricula_Det()
                    {
                        Curso=cur2021_1_LogProg,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 6.89f, Nota2 = 6.82f, Nota3 = 7.34f
                        }
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2021_1_ProdDig,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 7.84f, Nota2 = 4.12f, Nota3 = 5.50f
                        }
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2021_1_VideoMark,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 9.84f, Nota2 = 8.12f, Nota3 = 7.37f
                        }
                    }
                }
            };
            // [] ---------------------------------------------------------------
            Matricula matJose_2021_PAO2 = new Matricula()
            {
                Carrera = carComercio,
                Estado = MatriculaEstado.Pendiente,
                Estudiante = estJose,
                Fecha = new DateTime(2021, 1, 1),
                Periodo = per2021_PAO2,
                Matricula_Dets = new List<Matricula_Det>()
                {
                    new Matricula_Det()
                    {
                        Curso=cur2021_2_ProgWeb
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2021_2_ELearning
                    }
                }
            };
            // [] ---------------------------------------------------------------
            Matricula matMaria_2020_PAO2 = new Matricula()
            {
                Carrera = carComercio,
                Estado = MatriculaEstado.Aprobada,
                Estudiante = estMaria,
                Fecha = new DateTime(2020, 1, 1),
                Periodo = per2020_PAO2,
                Matricula_Dets = new List<Matricula_Det>()
                {
                    new Matricula_Det()
                    {
                        Curso=cur2020_2_DiseWeb,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 7.02f, Nota2 = 7.24f, Nota3 = 6.69f
                        }
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2020_2_AdminDB,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 7.48f, Nota2 = 6.42f, Nota3 = 8.27f
                        }
                    }
                }
            };
            // [] ---------------------------------------------------------------
            Matricula matMaria_2021_PAO1 = new Matricula()
            {
                Carrera = carComercio,
                Estado = MatriculaEstado.Aprobada,
                Estudiante = estMaria,
                Fecha = new DateTime(2021, 1, 1),
                Periodo = per2021_PAO1,
                Matricula_Dets = new List<Matricula_Det>()
                {
                    new Matricula_Det()
                    {
                        Curso=cur2021_1_LogProg,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 9.12f, Nota2 = 7.33f, Nota3 = 7.25f
                        }
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2021_1_VideoMark,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 7.84f, Nota2 = 7.12f, Nota3 = 8.50f
                        }
                    }
                }
            };
            // [] ---------------------------------------------------------------
            Matricula matMaria_2021_PAO2 = new Matricula()
            {
                Carrera = carComercio,
                Estado = MatriculaEstado.Pendiente,
                Estudiante = estMaria,
                Fecha = new DateTime(2021, 1, 1),
                Periodo = per2021_PAO2,
                Matricula_Dets = new List<Matricula_Det>()
                {
                    new Matricula_Det()
                    {
                        Curso=cur2021_2_ProgWeb
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2021_2_ELearning
                    }
                }
            };
            // [] ---------------------------------------------------------------
            Matricula matKarla_2020_PAO2 = new Matricula()
            {
                Carrera = carComercio,
                Estado = MatriculaEstado.Aprobada,
                Estudiante = estKarla,
                Fecha = new DateTime(2020, 1, 1),
                Periodo = per2020_PAO2,
                Matricula_Dets = new List<Matricula_Det>()
                {
                    new Matricula_Det()
                    {
                        Curso=cur2020_2_DiseWeb,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 6.02f, Nota2 = 6.24f, Nota3 = 6.69f
                        }
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2020_2_AdminDB,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 7.48f, Nota2 = 7.42f, Nota3 = 7.27f
                        }
                    }
                }
            };
            // [] ---------------------------------------------------------------
            Matricula matKarla_2021_PAO1 = new Matricula()
            {
                Carrera = carComercio,
                Estado = MatriculaEstado.Aprobada,
                Estudiante = estKarla,
                Fecha = new DateTime(2021, 1, 1),
                Periodo = per2021_PAO1,
                Matricula_Dets = new List<Matricula_Det>()
                {
                    new Matricula_Det()
                    {
                        Curso=cur2020_2_DiseWeb,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 8.02f, Nota2 = 8.24f, Nota3 = 7.69f
                        }
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2021_1_LogProg,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 6.12f, Nota2 = 7.33f, Nota3 = 8.25f
                        }
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2021_1_VideoMark,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 7.84f, Nota2 = 7.12f, Nota3 = 8.50f
                        }
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2021_1_ProdDig,
                        Calificacion = new Calificacion()
                        {
                            Nota1 = 8.41f, Nota2 = 7.12f, Nota3 = 7.50f
                        }
                    }
                }
            };
            // [] ---------------------------------------------------------------
            Matricula matKarla_2021_PAO2 = new Matricula()
            {
                Carrera = carComercio,
                Estado = MatriculaEstado.Pendiente,
                Estudiante = estKarla,
                Fecha = new DateTime(2021, 1, 1),
                Periodo = per2021_PAO2,
                Matricula_Dets = new List<Matricula_Det>()
                {
                    new Matricula_Det()
                    {
                        Curso=cur2021_2_ProgWeb
                    },
                    new Matricula_Det()
                    {
                        Curso=cur2021_2_ELearning
                    }
                }
            };

            var listaMatriculas = new List<Matricula>()
            {
                // Matrículas de Pedro
                matPedro_2020_PAO2, matPedro_2021_PAO1, matPedro_2021_PAO2,
                // Matrículas de José
                matJose_2020_PAO2, matJose_2021_PAO1, matJose_2021_PAO2,
                // Matrículas de María
                matMaria_2020_PAO2, matMaria_2021_PAO1, matMaria_2021_PAO2,
                // Matrículas de Karla
                matKarla_2020_PAO2, matKarla_2021_PAO1, matKarla_2021_PAO2
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
                { ListasTipo.Niveles, listaNiveles},
                { ListasTipo.Cursos, listaCursos },
                { ListasTipo.Matriculas, listaMatriculas },
                { ListasTipo.Prerequisitos, listaPrerequisitos }
                
            };

            return dicListasDatos;
        }
    }
}
