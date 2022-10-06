using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;
using System.Data;


namespace Colegio.DATOS
{
    class SEGURO
    {
        private String ID_SEGURO;
        private String ESTADO;
        private DateTime FECHA;
  
        private ManejadorDeDatos cnx = new ManejadorDeDatos();

        /// ///// DECLARACION DE LA LLAVE FORANEA 
        /// </summary>
        private ALUMNO ID_ALUMNO;
        private GESTION ID_GESTION;

        public void setID_SEGURO(String id_seguro)
        {
            ID_SEGURO = id_seguro;
        }

        public void setESTADO(String estado)
        {
            ESTADO = estado;
        }

        public void setFECHA(DateTime fecha) {
            FECHA= fecha;
        }

        /*    public void setID_ALUMNO(ALUMNO id_alumno)
            {
                ID_ALUMNO = id_alumno;
            }
            public void setID_GESTION(GESTION id_gestion)
            {
                ID_GESTION = id_gestion;
            }
         * 
         *  public void setID_ALUMNO(string id_alum)
            {
                throw new NotImplementedException();
            }

            internal void setID_GESTION(string id_ges)
            {
                throw new NotImplementedException();
            } 

            */

        public void setID_ALUMNO(ALUMNO idAlumno)
        {
            ID_ALUMNO = idAlumno;
        }
        public void setID_GESTION(GESTION idGes)
        {
            ID_GESTION = idGes;
        }


       
 /*++++++++++++++++++++++++ g e t  ++++++++++++++++++++*/

        public String getID_SEGURO()
        {
        return    ID_SEGURO;
        }

        public String getESTADO()
        {
           return ESTADO;
        }

        public DateTime getFECHA()
        {
        return    FECHA ;
        }


        public ALUMNO getID_ALUMNO()
        {
            return ID_ALUMNO;
        }

        public GESTION getID_GESTION()
        {
            return ID_GESTION;
        }

        public void insertar() {
            cnx.AbrirConexion();
            String sql = "INSERT INTO SEGURO VALUES ('" + ID_SEGURO + "','" + ID_ALUMNO + "','" + ESTADO + "','" + FECHA + "','" + ID_GESTION + "')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar() {
            cnx.AbrirConexion();
            String sql = "UPDATE SEGURO SET ID_SEGURO='" + ID_SEGURO + "',ID_ALUMNO='" + ID_ALUMNO + "',ESTADO='" + ESTADO + "',FECHA='" + cnx.fechaSQL(FECHA) +  "',ID_GESTION='" + ID_GESTION + " WHERE ID_SEGURO='" + ID_SEGURO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar() {
            cnx.AbrirConexion();
            String sql = "DELETE FROM SEGURO  WHERE ID_SEGURO='" + ID_SEGURO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar() {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM SEGURO WHERE ID_SEGURO='" + ID_SEGURO + "'";    
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_SEGURO = dr.GetString(0);
               // ID_ALUMNO = dr.GetString(1);
                ESTADO = dr.GetString(2);
                FECHA = dr.GetDateTime(3);
              //  ID_GESTION = dr.GetString (3);           

            }
            dr.Close();
            cnx.CerrarConexion();
        }

        public DataTable Listar()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select a.*,al.* from APODERADO a,ALUMNO al,TIENE t where a.ID_APODERADO= t.ID_APODERADO and t.ID_ALUMNO= al.ID_ALUMNO AND al.ID_ALUMNO='AL001' ";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
           /* for (int i = 0; i < table.Rows.Count; i++)
            {
             table.DataSet.   
            }*/
            return table;
        }

        public  DataTable MOSTRAR()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from SEGURO ";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
            /* for (int i = 0; i < table.Rows.Count; i++)
             {
              table.DataSet.   
             }*/
            return table;
        }




     /*   */
    }
}
