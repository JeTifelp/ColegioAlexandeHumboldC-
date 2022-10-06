using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;
namespace Colegio.NEGOCIO
{
    class N_FOTOGRAFIA
    {
        private FOTOGRAFIA foto = new FOTOGRAFIA();

        public void insertar(String id_fot, String id_al, BadImageFormatException fot, DateTime fecha)
        {
            foto.setID_FOTO(id_fot);
            foto.getID_ALUMNO().setID_alumno(id_al);
        //    foto.setFOTO(fot);
            foto.setFECHA(fecha);
            foto.insertar();
        }

        public void modificar(String id_fot, String id_al, BadImageFormatException fot, DateTime fecha)
        {
            foto.setID_FOTO(id_fot);
            foto.getID_ALUMNO().setID_alumno (id_al);
         //   foto.setFOTO(fot);
            foto.setFECHA(fecha);
            foto.modificar();
        }

        public void eliminar(String id_fot)
        {
            foto.setID_FOTO(id_fot);
            foto.eliminar();
        }

        public void buscar(String ID_F)
        {
            foto.setID_FOTO(ID_F);
            foto.buscar();
        }

        public DataTable MOSTRAR()
        {
            return foto.mostrar();
        }
    }
}
