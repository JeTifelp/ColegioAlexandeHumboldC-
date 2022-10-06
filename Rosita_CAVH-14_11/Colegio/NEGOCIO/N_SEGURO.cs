using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;

namespace Colegio.NEGOCIO
{
    class N_SEGURO
    {
        private SEGURO seguro = new SEGURO();

        public void insertar(String id_seg, String id_alum,String estado ,DateTime fecha, String id_ges)
        {

            seguro.setID_SEGURO(id_seg);
            seguro.getID_ALUMNO().setID_alumno (id_alum);

          //  seguro.getID_ALUMNO.setID_ALUMNO(id_alum);
            seguro.setESTADO(estado) ;
            seguro.setFECHA(fecha);
            seguro.getID_GESTION().setID_GESTION(id_ges);
            seguro.insertar();
        }

        public void modificar(String id_seg, String id_alum, String estado, DateTime fecha, String id_ges)
        {
            seguro.setID_SEGURO(id_seg);
            seguro.getID_ALUMNO().setID_alumno (id_alum);
            seguro.setESTADO(estado);
            seguro.setFECHA(fecha);
            seguro.getID_GESTION().setID_GESTION(id_ges);
            seguro.modificar();
        }

        public void eliminar(String id_seg)
        {
            seguro.setID_SEGURO(id_seg);
            seguro.eliminar();
        }

        public void buscar(String ID)
        {
            seguro.setID_SEGURO(ID);
            seguro.buscar();
        }

        public DataTable listar()
        {

            return seguro.Listar();
        }
        public DataTable MOSTRAR()
        {
            return seguro.MOSTRAR();
        }
    }
}
