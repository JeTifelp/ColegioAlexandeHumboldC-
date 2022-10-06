using System;
using Servidor;
using System.Data.SqlClient;
using System.Data;

namespace Colegio.DATOS
{
    class GESTION
    {
        private String ID_GESTION;
        private String DESCRIPCION;
        private DateTime FECHA_INICIO;
        private DateTime FEHCA_FIN;
        private ManejadorDeDatos cnx = new ManejadorDeDatos(); 



        public void setID_GESTION(String id_gestion){
            ID_GESTION= id_gestion;
        }

        public void setDESCRIPCION(String descripcion)
        {
            DESCRIPCION = descripcion;
        }

        public void setFECHA_INICIO(DateTime fechaini) {
            FECHA_INICIO = fechaini;
        }

        public void setFECHA_FIN(DateTime FECHAF) {
            FEHCA_FIN = FECHAF;
        }

        public String getID_GESTION()
        {
        return    ID_GESTION;
        }

        public String getDESCRIPCION()
        {
           return DESCRIPCION;
        }

        public DateTime getFECHA_INICIO()
        {
        return    FECHA_INICIO ;
        }

        public DateTime getFECHA_FIN()
        {
        return    FEHCA_FIN ;
        }


        public void insertar() {
            cnx.AbrirConexion();
            String sql = "INSERT INTO GESTION VALUES ('"+ID_GESTION+"','"+DESCRIPCION+"','"+cnx.fechaSQL( FECHA_INICIO)+"','"+cnx.fechaSQL( FEHCA_FIN)+"')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar() {
            cnx.AbrirConexion();
            String sql = "UPDATE GESTION SET DESCRIPCION='" + DESCRIPCION + "',FECHA_INICIO='" + cnx.fechaSQL(FECHA_INICIO) + "',FECHA_FIN='" + cnx.fechaSQL(FEHCA_FIN) + " WHERE ID_GESTION='" + ID_GESTION + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar() {
            cnx.AbrirConexion();
            String sql = "DELETE FROM GESTION  WHERE ID_GESTION='" + ID_GESTION + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar() {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM GESTION  WHERE ID_GESTION='" + ID_GESTION + "'";    
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_GESTION = dr.GetString(0);
                DESCRIPCION = dr.GetString(1);
                FECHA_INICIO = dr.GetDateTime(2);
                FEHCA_FIN = dr.GetDateTime(3);           

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
        //___________________
        public DataTable mostrargestion()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from GESTION ";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();        
            return table;
        }
        //_____________________________

        public int ContarCantidad_d_Tuplas_Gestion()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select count(*)from GESTION";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
            //return table;
            return d;
        }



    }
}
