using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;

namespace Colegio.NEGOCIO
{
    class N_NIVEL
    {
        private NIVEL nivel = new NIVEL();

        public void Insertar(String idnivel, String descri) {
            nivel.SETID_NIVEL(idnivel);
            nivel.SET_DESCRIPCION(descri);

            nivel.insertar();
        }
        //____
        public void Modificar(String idnivel,String descrip) {
            nivel.SETID_NIVEL(idnivel);
            nivel.SET_DESCRIPCION(descrip);
            nivel.modificar();
        }

        //__
        public void Eliminar( string idnivel) {
            nivel.SETID_NIVEL(idnivel);
            nivel.eliminar();
        }
        //_-
        public void Buscar(string idnivel) {
            nivel.SETID_NIVEL(idnivel);
            nivel.buscar();
        }

        public DataTable MOSTRAR()
        {
            return nivel.mostrar();
        }

        //__________________________
    }
}
