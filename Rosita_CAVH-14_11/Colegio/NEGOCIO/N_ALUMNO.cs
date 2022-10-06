using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;

namespace Colegio.NEGOCIO
{
    class N_ALUMNO
        //______COMPLETO_______
    {
         private ALUMNO alumno = new ALUMNO();
      public void Insertar(string id_ALUMNO ,string ap_PATERNO, string ap_MATERNO, string noMBRE,
          string diRECCION, string seXO, string id_LN) {
          alumno.setID_alumno(id_ALUMNO);
          alumno.setAP_paterno(ap_PATERNO);
           alumno.setAP_materno(ap_MATERNO);
           alumno.setNombre(noMBRE);
           alumno.setDireccion(diRECCION);
           alumno.setSexo(seXO);
           alumno.GETID_ln().setID_LN(id_LN);//  preguntar____________
           alumno.insertar();
       }

      public void modificar(string id_ALUMNO, string ap_PATERNO, string ap_MATERNO, string noMBRE, string diRECCION, string seXO, string id_LN)
      {
          alumno.setID_alumno(id_ALUMNO);
          alumno.setAP_paterno(ap_PATERNO);
          alumno.setAP_materno(ap_MATERNO);
          alumno.setNombre(noMBRE);
          alumno.setDireccion(diRECCION);
          alumno.setSexo(seXO);
          alumno.GETID_ln().setID_LN(id_LN);//___MANEJO DE LLAVE FORANEA_________
          alumno.modificar();
      }
      public void eliminar(String id_alumno)
      {
          alumno.setID_alumno(id_alumno);

          alumno.eliminar();
      }
      public void buscar(String ID)
      {
          alumno.setID_alumno(ID);
          alumno.buscar();

      }
      public DataTable MOSTRAR()
      {
          return alumno.mostrar();
      }

      public DataTable buscar_alumno_por_nombre(ALUMNO Par)
      {

          return alumno.Buscar_ALUMNO_POR_NOMBRE(Par);// PARALELOS.Buscar_Cupo(P);

      }
        //__________________________
      public string buscar_algun_ID_Alumno(String nnombre,string app_paternno,string app_materno)
      {
          return alumno.Obtiene_un_ID_Alumno(nnombre, app_paternno, app_materno);
      }


        //__________________________
    }
}
