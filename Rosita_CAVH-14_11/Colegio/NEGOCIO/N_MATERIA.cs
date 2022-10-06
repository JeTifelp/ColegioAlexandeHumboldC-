using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;


namespace Colegio.NEGOCIO
{
    class N_MATERIA
    {
        MATERIA materia = new MATERIA();
        public DataTable MOSTRAR()
        {
            return materia.mostrar ();
        }

        public void insertar(String id_materia, String nombremateria) {
            
            materia.setID_materia(id_materia);
            materia.setNombre(nombremateria);
            materia.insertar();
        }
        public void mmodificar(String id_materia, String nombremateria)
        {

            materia.setID_materia(id_materia);
            materia.setNombre(nombremateria);
            materia.modificar();
        }
        public void eliminar(String id_materia)
        {
            materia.setID_materia(id_materia);
            materia.eliminar();
        }
        public void buscar(String id_materia)
        {
            materia.setID_materia(id_materia);
            materia.buscar();
        }

      
    }
}
