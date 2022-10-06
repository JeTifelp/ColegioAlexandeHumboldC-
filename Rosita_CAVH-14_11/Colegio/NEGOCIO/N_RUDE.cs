using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;

namespace Colegio.CONEXION
                            //______COMPLETO_______
{
   public class N_RUDE
    {
         RUDE rrude = new RUDE();

        public void insertar(String codrude, String nombreue,int codsie, int codprocde,String dependenciaue,String nombreUEproced, String idalumno)
        {
            rrude.setCOD_RUDE(codrude);
            rrude.setNOMBRE_UE(nombreue);
            rrude.setCODIGO_SIE(codsie);
            rrude.setCODIGO_PROCEDENCIA(codprocde);
            rrude.setDEPENDENCIA_UE(dependenciaue);
            rrude.setNOMBRE_UE_PROCEDENCIA(nombreUEproced);
            rrude.getID_ALUMNO().setID_alumno(idalumno);
           // rrude.getID_ALUMNO().setIDAlumno(idalumno);
            rrude.insertar();


        }

        public void modificar(String codrude, String nombreue, int codsie, int codprocde, String dependenciaue, String nombreUEproced, String idalumno)
        {
            rrude.setCOD_RUDE(codrude);
            rrude.setNOMBRE_UE(nombreue);
            rrude.setCODIGO_SIE(codsie);
            rrude.setCODIGO_PROCEDENCIA(codprocde);
            rrude.setDEPENDENCIA_UE(dependenciaue);
            rrude.setNOMBRE_UE_PROCEDENCIA(nombreUEproced);
            rrude.getID_ALUMNO().setID_alumno(idalumno);
            // rrude.getID_ALUMNO().setIDAlumno(idalumno);
            rrude.modificar();

        }

        public void eliminar(String COD)
        {
            rrude.setCOD_RUDE(COD);
            rrude.eliminar();
          //  lugarN.setID_LN(id_LN);
          //  lugarN.eliminar();
        }

        public void buscar(String ID)
        {
            rrude.setCOD_RUDE(ID);
            rrude.buscar();
           // lugarN.setID_LN(ID);
           // lugarN.buscar();
        }

        public DataTable MOSTRAR()
        {
            return rrude.mostrar();
        }

    }
}
