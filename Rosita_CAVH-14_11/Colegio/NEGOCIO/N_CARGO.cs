using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;
using System.Data.SqlClient;


namespace Colegio.NEGOCIO
{
    class N_CARGO

    {
        CARGO cargo = new CARGO();
        public void insertar(String id_cargo, String descrip, int prio)
        {

            cargo.setIDcargo(id_cargo);
            cargo.SEtdesripcion(descrip);
            cargo.SETprioridad(prio);

            cargo.insertar();
        }

        public void modificar(String id_cargo, String descrip, int prio)
        {
          
            cargo.setIDcargo(id_cargo);
            cargo.SEtdesripcion(descrip);
            cargo.SETprioridad(prio);
   
            cargo.modificar();
        }

        public void eliminar(String id_not)
        {
            cargo.setIDcargo(id_not);
            cargo.eliminar();
        }

        public void buscar(String ID)
        {
            cargo.setIDcargo(ID);
            cargo.buscar();
        }

        /* public DataTable listar()
         {

             return certificado.Listar();
         }*/
        public DataTable MOSTRAR()
        {
            return cargo.mostrarCARGO();
        }
    }
}
