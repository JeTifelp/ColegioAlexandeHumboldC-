using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using  Colegio.DATOS;
namespace Colegio.NEGOCIO
{
    class N_LUGARDENACIMIENTO
    {
        protected LUGARDENACIMIENTO lugarN = new LUGARDENACIMIENTO ();

        public void insertar(String id_ln, String pais_nacimiento,String dpto, String prov_estado,String cuidad)
        {
            lugarN.setID_LN(id_ln);
            lugarN.setPAIS_NACIMIENTO(pais_nacimiento);
            lugarN.setDEPARTAMENTO(dpto);
            lugarN.setPROVINCIA_ESTADO(prov_estado);
            lugarN.setCIUDAD(cuidad);
            lugarN.insertar();
            
           
        }

        public void modificar(String id_ln, String pais_nacimiento, String dpto, String prov_estado, String cuidad)
        {
            lugarN.setID_LN(id_ln);
            lugarN.setPAIS_NACIMIENTO(pais_nacimiento);
            lugarN.setDEPARTAMENTO(dpto);
            lugarN.setPROVINCIA_ESTADO(prov_estado);
            lugarN.setCIUDAD(cuidad);
            lugarN.modificar();
        }

        public void eliminar(String id_LN)
        {
            lugarN.setID_LN(id_LN);
            lugarN.eliminar();
        }

        public void buscar(String ID)
        {
            lugarN.setID_LN(ID);
            lugarN.buscar();
        }
        public DataTable MOSTRAR()
        {
            return lugarN.mostrarLUGARDENACIMIENTO();
        }
  
    }
}
