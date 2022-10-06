using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;

namespace Colegio.NEGOCIO
{
    class N_GESTION
    {
        private GESTION gestion = new GESTION();

        public void insertar(String id_gestion,String descri, DateTime fechaini, DateTime fechafi){
            gestion.setID_GESTION(id_gestion);
            gestion.setDESCRIPCION(descri);
            gestion.setFECHA_INICIO(fechaini);
            gestion.setFECHA_FIN(fechafi);
            gestion.insertar();
        }

        public void modificar(String id_gestion, String descri, DateTime fechaini, DateTime fechafi)
        {
            gestion.setID_GESTION(id_gestion);
            gestion.setDESCRIPCION(descri);
            gestion.setFECHA_INICIO(fechaini);
            gestion.setFECHA_FIN(fechafi);
            gestion.modificar();
        }

        public void eliminar(String id_gestion)
        {
            gestion.setID_GESTION(id_gestion);
            gestion.eliminar();
        }

        public void buscar(String ID) {
            gestion.setID_GESTION(ID);
            gestion.buscar();
        }

        public DataTable listar()
        {

            return gestion.Listar();
        }
        public DataTable MOSTRAGESTION() {
            return gestion.mostrargestion();       
        }
        public int Contar_CantTuplas_Gestion()
        {
            return gestion.ContarCantidad_d_Tuplas_Gestion();
        }
    }
}
