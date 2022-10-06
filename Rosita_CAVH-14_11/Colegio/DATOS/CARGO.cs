using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Servidor;


namespace Colegio.DATOS
{
    class CARGO

    {
        private String ID_CARGO;
        private String DESCRIPCION;
        private int PRIORIDAD;

        private ManejadorDeDatos cnx = new ManejadorDeDatos(); 

        public String GETID_CARGO()
        {
            return ID_CARGO;
        }
         public String  GETDESCRIPCION()
        {
            return  DESCRIPCION;
        }
         public int GETPRIORIDAD()
        {
            return PRIORIDAD ;
        }

        public void setIDcargo(String ID )
        {
            ID_CARGO = ID;
        }
        public void SEtdesripcion(String DES) { DESCRIPCION = DES; }
        public void SETprioridad(int PRIO) { PRIORIDAD = PRIO; }



        /*
ID_CARGO VARCHAR (10)NOT NULL,
DESCRIPCION VARCHAR (30),
PRIORIDAD INT,
         */
        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO CARGO VALUES ('" + ID_CARGO + "','" + DESCRIPCION+  "','" + PRIORIDAD+ "')";

            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
           //String sql = "UPDATE GESTION SET DESCRIPCION='" + DESCRIPCION + "',FECHA_INICIO='" + cnx.fechaSQL(FECHA_INICIO) + "',FECHA_FIN='" + cnx.fechaSQL(FEHCA_FIN) + " WHERE ID_GESTION='" + ID_GESTION + "'";
            String sql = "UPDATE CARGO SET DESCRIPCION = '" + DESCRIPCION + "',PRIORIDAD='" + PRIORIDAD + "' WHERE ID_CARGO='" + ID_CARGO + "' ";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM CARGO  WHERE ID_CARGO='" + ID_CARGO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM CARGO  WHERE ID_CARGO='" + ID_CARGO + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_CARGO = dr.GetString(0);
                DESCRIPCION = dr.GetString(1);
                PRIORIDAD = dr.GetInt32(2);
 

            }
            dr.Close();
            cnx.CerrarConexion();
        }
        public DataTable mostrarCARGO()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from CARGO ";
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



    }
}
