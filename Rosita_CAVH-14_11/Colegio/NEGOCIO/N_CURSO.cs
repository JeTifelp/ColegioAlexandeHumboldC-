using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;


namespace Colegio.NEGOCIO
{
    class N_CURSO
    {
        private CURSO curso = new CURSO();

        public void insertar(String ID_C, String NOMBB,String ID_NI)
        {
            curso.setID_Curso(ID_C);
            curso.setNombre(NOMBB);
            curso.GETID_Nivel().SETID_NIVEL(ID_NI);
            //  LLAVE FORANEA___________
            curso.insertar();
        }
        public void modificar(String ID_C, String NOMBB, String ID_NI)
        {
            curso.setID_Curso(ID_C);
            curso.setNombre(NOMBB);
            curso.GETID_Nivel().SETID_NIVEL(ID_NI);
            //  LLAVE FORANEA___________
            curso.modificar();
        }
        public void eliminar(String id_c)
        {
            curso.setID_Curso(id_c);
            curso.eliminar();

        }
        public void buscar(String id_c)
        {
            curso.setID_Curso(id_c);
            curso.buscar();

        }

        public DataTable MOSTRAR()
        {
            return curso.mostrar();
        }
    }
}
