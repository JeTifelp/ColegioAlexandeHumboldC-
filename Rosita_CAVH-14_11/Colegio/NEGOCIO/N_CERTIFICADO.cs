using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;

namespace Colegio.NEGOCIO
{
    class N_CERTIFICADO
    {
          private CERTIFICADO_NACIMIENTO certificado = new  CERTIFICADO_NACIMIENTO();

        public void insertar(String id_certificado,int nroFolio,int nroLibro, int nroOficialia ,int nroPartida, DateTime fechaNac, String id_alumno){
           
            certificado.setID_CERTIFICADO(id_certificado);
            certificado.setNRO_FOLIO(nroFolio);
            certificado.setNRO_LIBRO (nroLibro);
            certificado.setNRO_OFICIALIA (nroOficialia);
            certificado.setNRO_PARTIDA (nroPartida);
            certificado.setFECHA_NACIMIENTO(fechaNac);
            certificado.getID_ALUMNO().setID_alumno(id_alumno);
            certificado.insertar();
        }

        public void modificar(String id_certificado, int nroFolio, int nroLibro, int nroOficialia, int nroPartida, DateTime fechaNac, String id_alumno)
        {
            certificado.setID_CERTIFICADO(id_certificado);
            certificado.setNRO_FOLIO(nroFolio);
            certificado.setNRO_LIBRO (nroLibro);
            certificado.setNRO_OFICIALIA (nroOficialia);
            certificado.setNRO_PARTIDA (nroPartida);
            certificado.setFECHA_NACIMIENTO(fechaNac);
            certificado.getID_ALUMNO().setID_alumno(id_alumno);
            certificado.modificar();
        }

        public void eliminar(String id_certificado)
        {
            certificado.setID_CERTIFICADO(id_certificado);
            certificado.eliminar();
        }

        public void buscar(String ID) {
            certificado.setID_CERTIFICADO(ID);
            certificado.buscar();
        }

      
        public DataTable MOSTRAR() {
            return certificado.mostrar();       
        }


    }
}
