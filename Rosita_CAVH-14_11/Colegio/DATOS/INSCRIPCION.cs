using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Servidor;
//using System.Data;

namespace Colegio.DATOS
{
    class INSCRIPCION
    {
        private String ID_INSCRIPCION;
        private DateTime FECHA;
        private GESTION ID_GESTION = new GESTION();
    //    private string NOMBRE;
        private ALUMNO ID_ALUMNO = new ALUMNO();
        private PARALELOS ID_PARALELOS = new PARALELOS();
        private EMPLEADO ID_EMPLEADO = new EMPLEADO();
        private ManejadorDeDatos cnx = new ManejadorDeDatos();


        public void setID_INSCRIPCION(String INSCR)
        {
            ID_INSCRIPCION = INSCR;
        }

   /*     public void set_NOMBRE(String NOM)
        {
            NOMBRE = NOM;
        }
    * */

        public void setFECHA(DateTime fech)
        {
            FECHA = fech;
        }
        public void setID_ALUMNO(ALUMNO AL)
        {
            ID_ALUMNO = AL;
        }
        public void setID_GESTION(GESTION IDGES)
        {
            ID_GESTION = IDGES;
        }
        public void setID_PARALELO(PARALELOS IDPALEO)
        {
            ID_PARALELOS = IDPALEO;
        }
        public void setID_EMPLEADO(EMPLEADO EMPL)
        {
            ID_EMPLEADO = EMPL;
        }

        /*
         
ID_INSCRIPCION VARCHAR (10) NOT NULL,
FECHA DATE ,
ID_GESTION VARCHAR (10) NOT NULL,
ID_ALUMNO VARCHAR (10)NOT NULL,
ID_PARALELO VARCHAR (10) NOT NULL,
ID_EMPLEADO VARCHAR (10) NOT NULL,
         */
        public string getID_INSCRIPCION()
        {
            return ID_INSCRIPCION;
        }

       /* public string get_NOMBRE()
        {
            return NOMBRE;
        }
        * */

        public DateTime getFECHA()
        {
            return FECHA;
        }
        public GESTION getID_GESTION()
        {
            return ID_GESTION;
        }
        public ALUMNO getID_ALUMNO()
        {
            return ID_ALUMNO;
        }
        public EMPLEADO getID_EMPLEADO()
        {
            return ID_EMPLEADO;
        }
        public PARALELOS getID_PARALELOS()
        {
            return ID_PARALELOS;
        }
        //_____________________________


        public void insertar()
        {
            cnx.AbrirConexion();//"','"  + LO QUE CORTOOÓ
            String sql = "INSERT INTO INSCRIPCION1 VALUES ('" + ID_INSCRIPCION + "','" + cnx.fechaSQL(FECHA) + "','"
                + ID_GESTION.getID_GESTION() + "','" + ID_ALUMNO.GETID_alumno() + "','" + ID_PARALELOS.GETID_paralelo() +
                "','" + ID_EMPLEADO.getID_EMPLEADO() + "')";

            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
            String sql = "UPDATE INSCRIPCION1 SET FECHA= '" + cnx.fechaSQL(FECHA) + "',ID_GESTION='"
                + ID_GESTION.getID_GESTION() +"',ID_ALUMNO='" + ID_ALUMNO.GETID_alumno() + "',ID_PARALELO'" + ID_PARALELOS.GETID_paralelo() +
                "',ID_EMPLEADO='" + ID_EMPLEADO.getID_EMPLEADO() + "' WHERE ID_INSCRIPCION='" + ID_INSCRIPCION + "' ";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }
        /*
         
ID_INSCRIPCION VARCHAR (10) NOT NULL,
FECHA DATE ,
ID_GESTION VARCHAR (10) NOT NULL,
ID_ALUMNO VARCHAR (10)NOT NULL,
ID_PARALELO VARCHAR (10) NOT NULL,
ID_EMPLEADO VARCHAR (10) NOT NULL,
  */

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM INSCRIPCION1  WHERE ID_INSCRIPCION='" + ID_INSCRIPCION + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM INSCRIPCION1  WHERE ID_INSCRIPCION='" + ID_INSCRIPCION + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_INSCRIPCION = dr.GetString(0);
                FECHA = dr.GetDateTime(1);
                ID_GESTION.setID_GESTION(dr.GetString(2));
                ID_GESTION.buscar();
             //   NOMBRE = dr.GetString(3);
                ID_ALUMNO.setID_alumno(dr.GetString(3));
                ID_ALUMNO.buscar();
                ID_PARALELOS.setID_paralelo(dr.GetString(4));
                ID_PARALELOS.buscar();
                ID_EMPLEADO.SETID_EMPLEADO(dr.GetString(5));
                ID_EMPLEADO.buscar();

                //___________________MANEJO DE LLAVE FORANEA

                /*
         
ID_INSCRIPCION VARCHAR (10) NOT NULL,
FECHA DATE ,
ID_GESTION VARCHAR (10) NOT NULL,
ID_ALUMNO VARCHAR (10)NOT NULL,
ID_PARALELO VARCHAR (10) NOT NULL,
ID_EMPLEADO VARCHAR (10) NOT NULL,
*/
            }
            dr.Close();
            cnx.CerrarConexion();
        }



        public DataTable mostrar()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from INSCRIPCION1 ";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
          
            return table;
        }
        public string ContarCantidad_d_Tuplas_Inscripcion()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select count(*)from INSCRIPCION1";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            string d =Convert.ToString(dr.FieldCount);
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
            //return table;
            return d;
        }


    }
}
