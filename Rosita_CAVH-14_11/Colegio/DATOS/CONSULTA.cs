using System;
using Servidor;
using System.Data.SqlClient;
using System.Data;
using Colegio.CONEXION;

namespace Colegio.DATOS
{
    class CONSULTA

    {
        private ManejadorDeDatos cnx = new ManejadorDeDatos(); 

        public DataTable mostrar()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from CERTIFICADO_NACIMIENTO ";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
            return table;
        }


        /*public DataTable MOSTRAR()
        {
            return certificado.mostrar();
        }*/

    }
}
