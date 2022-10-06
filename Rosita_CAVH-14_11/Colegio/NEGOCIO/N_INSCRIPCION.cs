using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data.SqlClient;

using System.Data;


namespace Colegio.NEGOCIO
{
    class N_INSCRIPCION
    {
        INSCRIPCION inscripcion = new INSCRIPCION();
        public void insertar(string id_insc, DateTime fecha, string idgestion, string idalumno, string idparaleo, string idempleado)
        {

            inscripcion.setID_INSCRIPCION(id_insc);
            inscripcion.setFECHA(fecha);
            inscripcion.getID_GESTION().setID_GESTION(idgestion);
        //    inscripcion.set_NOMBRE(nombre);
            inscripcion.getID_ALUMNO().setID_alumno(idalumno);
            inscripcion.getID_PARALELOS().setID_paralelo(idparaleo);
            inscripcion.getID_EMPLEADO().SETID_EMPLEADO(idempleado);
            inscripcion.insertar();


        }
        public void modificar(string id_insc, DateTime fecha, string idgestion, string idalumno, string idparaleo, string idempleado)
        {

            inscripcion.setID_INSCRIPCION(id_insc);
            inscripcion.setFECHA(fecha);
            inscripcion.getID_GESTION().setID_GESTION(idgestion);
            //inscripcion.set_NOMBRE(nombre);
            inscripcion.getID_ALUMNO().setID_alumno(idalumno);
            inscripcion.getID_PARALELOS().setID_paralelo(idparaleo);
            inscripcion.getID_EMPLEADO().SETID_EMPLEADO(idempleado);
            inscripcion.modificar();


        }
        /*
         
ID_INSCRIPCION VARCHAR (10) NOT NULL,
FECHA DATE ,
ID_GESTION VARCHAR (10) NOT NULL,
ID_ALUMNO VARCHAR (10)NOT NULL,
ID_PARALELO VARCHAR (10) NOT NULL,
ID_EMPLEADO VARCHAR (10) NOT NULL,
*/
        public void eliminar(String id_alumno)
        {
            inscripcion.setID_INSCRIPCION(id_alumno);

            inscripcion.eliminar();
        }
        public void buscar(String ID)
        {
            inscripcion.setID_INSCRIPCION(ID);
            inscripcion.buscar();

        }
        public DataTable MOSTRAR()
        {
            return inscripcion.mostrar();
        }

        public string Contar_tUPLAS_Inscripcion()
        {
            string cadena = "INS0";
            return cadena + inscripcion.ContarCantidad_d_Tuplas_Inscripcion();
        }


    }
}
