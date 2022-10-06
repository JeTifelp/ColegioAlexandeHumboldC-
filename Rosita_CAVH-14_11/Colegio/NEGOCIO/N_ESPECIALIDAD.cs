using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data.SqlClient;

namespace Colegio.NEGOCIO
{
    class N_ESPECIALIDAD
    {
        private ESPECIALIDAD especil = new ESPECIALIDAD();

        public void insertar(String id_especialidad, String descri)
        {
            especil.setID_ESPECIALIDAD(id_especialidad);
            especil.setDESCRIPCION(descri);
            especil.insertar();
        }
        public void modificar(String id_especialidad, String descri)
        {
            especil.setID_ESPECIALIDAD(id_especialidad);
            especil.setDESCRIPCION(descri);
            especil.modificar();
        }

        public void eliminar(String id_esp)
        {
            especil.setID_ESPECIALIDAD(id_esp);
            especil.eliminar();
        }

        public void buscar(String id_esp)
        {
            especil.setID_ESPECIALIDAD(id_esp);
            especil.buscar();
        }


    }
}
