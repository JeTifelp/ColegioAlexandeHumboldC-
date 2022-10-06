using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;


namespace Colegio.NEGOCIO
{
    class N_TRIMESTRE

    {
        private TRIMESTRE BOLETIN = new TRIMESTRE();

        public void INSERTAR(String ID_T, String NOMBRE_T, String ID_A, String ID_C , String ID_M,int PROM_C, int DPS, int PROM_T, String ID_L )
        {
            BOLETIN.setIdTrimestral(ID_T);
            BOLETIN.setNombretrimestre(NOMBRE_T);
            BOLETIN.getID_ALUMNO().setID_alumno(ID_A);
            BOLETIN.getIdCURSO().setID_CURSO(ID_C);
            BOLETIN.getIdMATERIA().setID_MATERIA(ID_M);
            BOLETIN.setPuntajeconocimiento(PROM_C);
            BOLETIN.setPuntajeDps(DPS);
            BOLETIN.setPuntajetrimestre(PROM_T);
            BOLETIN.GET_IDLIBRETA().setIdLibreta(ID_L);
        }

        public void MODIFICAR (String ID_T, String NOMBRE_T, String ID_A, String ID_C, String ID_M, int PROM_C, int DPS, int PROM_T, String ID_L)
        {
            BOLETIN.setIdTrimestral(ID_T);
            BOLETIN.setNombretrimestre(NOMBRE_T);
            BOLETIN.getID_ALUMNO().setID_alumno(ID_A);
            BOLETIN.getIdCURSO().setID_CURSO(ID_C);
            BOLETIN.getIdMATERIA().setID_MATERIA(ID_M);
            BOLETIN.setPuntajeconocimiento(PROM_C);
            BOLETIN.setPuntajeDps(DPS);
            BOLETIN.setPuntajetrimestre(PROM_T);
            BOLETIN.GET_IDLIBRETA().setIdLibreta(ID_L);
            BOLETIN.modificar();
        }


        public void eliminar(String id_TRIM)
        {
            BOLETIN.setIdTrimestral(id_TRIM);
            BOLETIN.eliminar();
            //libreta.setIdLibreta(id_Libreta);
            //libreta.eliminar();
        }

        public void buscar(String ID_TRIM)
        {
            BOLETIN.setIdTrimestral(ID_TRIM);
            
            //libreta.setIdLibreta(IDLIb);
            //libreta.buscar();
        }

        public DataTable MOSTRAR()
        {
            return BOLETIN.MOSTRAR();
        }

    }
}


  