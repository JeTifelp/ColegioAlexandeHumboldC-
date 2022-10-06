using System;
using Servidor;
using System.Data.SqlClient;
using System.Data;
namespace Colegio.DATOS
{
    class NIVEL
    {
        private String ID_NIVEL;
        private String DESCRIPCION;
        private ManejadorDeDatos cnx = new ManejadorDeDatos();



        public void SETID_NIVEL(String id_N)
        {
            this.ID_NIVEL = id_N;
        }

        public void SET_DESCRIPCION( String DES ) {
            this.DESCRIPCION = DES;
        }

        public String  GETID_NIVEL(){
            return this.ID_NIVEL;
        }

        public String GET_DESCRIPCION() {
            return this.DESCRIPCION;
        }

        //___________
        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO NIVEL VALUES ('" + ID_NIVEL + "', '" + this.DESCRIPCION + "')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
            String sql = " UPDATE NIVEL SET DESCRIPCION=    '" + DESCRIPCION +   " WHERE ID_NIVEL='"    + ID_NIVEL + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = " DELETE FROM NIVEL WHERE ID_NIVEL='" + ID_NIVEL + "' ";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            string sqll = "SELECT* FROM NIVEL WHERE ID_NIVEL='" + ID_NIVEL + "'";
            
            SqlDataReader dr = cnx.EjecutarConsulta(sqll);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_NIVEL  = dr.GetString(0);
                DESCRIPCION = dr.GetString(1);
               

            }
            dr.Close();
            cnx.CerrarConexion();
        }

        public DataTable mostrar()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from NIVEL ";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
            return table;
        }


//_______________________FIN CLAS
    }
}
