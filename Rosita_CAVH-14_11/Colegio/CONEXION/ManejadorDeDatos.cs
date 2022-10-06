using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

using System.Data;

namespace Servidor
{
    public class ManejadorDeDatos
    {

        private SqlConnection cnx = null;
        private SqlCommand cmd = null;
        private SqlTransaction tr = null;
        private SqlDataReader dr = null;
        private SqlCommand comando = null;

        private static ManejadorDeDatos mds;
        public ManejadorDeDatos()
        {
            //cnx = new SqlConnection("Data Source=DAVICHO;Initial Catalog=CAVH;Integrated Security=True");
           // cnx = new SqlConnection("Data Source=ELIOD-PC;Initial Catalog=CAVH;Integrated Security=True");


            cnx = new SqlConnection("server=DESKTOP-527KSAI ; database=CAVH3 ; integrated security = true");
            //Data Source=ELIOD-PC;Initial Catalog=CAVH;Integrated Security=True
            cmd = new SqlCommand();            
            cmd.Connection = cnx;
        }

        public void AbrirConexion()
        {
            try
            {
                cnx.Open();
                //MessageBox.Show("conecto");
            }
            catch (Exception e)
            {
                throw e; 
            }
        }

        public void CerrarConexion()
        {
            try
            {
                cnx.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public   void EjecutarComando(String sql)
        {
            
            try
            {
                tr = cnx.BeginTransaction();
                cmd.Transaction = tr;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();                
                tr.Commit();
            }
            catch (Exception)
            {
                tr.Rollback();
                throw;
            }
        }
      
       
        public SqlDataReader EjecutarConsulta(String consulta)
        {
            SqlDataReader rd = null;
            try
            {                                
                cmd.CommandText = consulta;
                rd = cmd.ExecuteReader();

                return rd;
                
            }
            catch (Exception)
            {                
                return rd;
                throw;
                
            }

        }
     
            
       
      

        public string ObtenerTupla(string sql)
        {
            string cadena = "";
            SqlDataReader dr = EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                for (int i = 0; i < d; i++)
                {
                    cadena = cadena + dr.GetValue(i) + "|";
                }

            }
            dr.Close();
            return cadena;
        }

        public  string fechaSQL(DateTime fechaHora)
        {
            return "" +
                    fechaHora.Year + "-" +
                    fechaHora.Month + "-" +
                    fechaHora.Day + " " +
                    fechaHora.Hour + ":" +
                    fechaHora.Minute + ":" +
                    fechaHora.Second + "";
        }




        ///////////______________________________________

        public void ejecutar_operacion(string sql, List<SqlParameter> parametro)
        {
            AbrirConexion();
            comando = new SqlCommand(sql, cnx);
            comando.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter iten in parametro)
            {
                comando.Parameters.Add(iten);

            }
            comando.ExecuteNonQuery();
            cnx.Close();

        }
        public static SqlConnection ObtnerCOnexion()
        {
            //SqlConnection Conn = new SqlConnection("Data Source=ELIOD-PC;Initial Catalog=CAVH3;Integrated Security=True"); // inicial 26
            SqlConnection Conn = new SqlConnection("server=DESKTOP-527KSAI ; database=CAVH3 ; integrated security = true");
            Conn.Open();
             
            return Conn;

        }
        public String obtennerCaminoConexion()
        {
            // return ConfigurationManager.ConnectionStrings["siVeterinaria.Properties.Settings.db_VeterinariaConnectionString"].ConnectionString;
           // string cadeni = "Data Source=ELIOD-PC;Initial Catalog=CAVH3;Integrated Security=True"; /// 26 inicial
            string cadeni = "server=DESKTOP-527KSAI ; database=CAVH3 ; integrated security = true";
            return cadeni;
            //return ConfigurationManager.ConnectionStrings["siVeterinaria
            //.Properties.Settings.db_VeterinariaConnectionString"].ConnectionString;

        }

        public DataTable consultar(String sql)
        {
            AbrirConexion();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, cnx);
            adaptador.Fill(tabla);


            return tabla;

        }

        //////////////_________________________________________
 

    }
}
      

