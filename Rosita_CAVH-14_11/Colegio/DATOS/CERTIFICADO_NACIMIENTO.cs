using System;
using Servidor;
using System.Data.SqlClient;
using System.Data;


namespace Colegio.DATOS
{
    class CERTIFICADO_NACIMIENTO
    {
        private String ID_CERTIFICADO;
        private int NRO_FOLIO ;
        private int NRO_LIBRO;
        private int NRO_OFICIALIA;
        private int NRO_PARTIDA;
        private DateTime FECHA_NACIMIENTO;
        /// <summary>
        /// ///// DECLARACION DE LA LLAVE FORANEA 
        /// </summary>
        private ALUMNO ID_AL= new ALUMNO();

        private ManejadorDeDatos cnx = new ManejadorDeDatos();



        public void setID_CERTIFICADO(String id_certificado)
        {
            ID_CERTIFICADO = id_certificado;
        }

        public void setNRO_FOLIO(int nro_folio)
        {
           NRO_FOLIO = nro_folio;
        }

        public void setNRO_LIBRO(int nro_libro)
        {
           NRO_LIBRO = nro_libro;
        }

        public void setNRO_OFICIALIA(int  nro_oficialia)
        {
            NRO_OFICIALIA = nro_oficialia;
        }

        public void setNRO_PARTIDA(int nro_partida)
        {
            
            NRO_PARTIDA = nro_partida;
        }

        public void setFECHA_NACIMIENTO(DateTime fecha_nacimiento)
        {
            FECHA_NACIMIENTO= fecha_nacimiento;
        }

        public void setID_ALUMNO(ALUMNO id_alumno)
        {
            ID_AL = id_alumno;
        }



        public String getID_CERTIFICADO()
        {
            return ID_CERTIFICADO;
        }

        public int getNRO_FOLIO()
        {
            return NRO_FOLIO;
        }

        public int getNRO_LIBRO()
        {
            return NRO_LIBRO;
        }

        public int getNRO_OFICIALIA()
        {
            return NRO_OFICIALIA;
        }

        public int getNRO_PARTIDA()
        {
            return NRO_PARTIDA;
        }

        public DateTime getFECHA_NACIMIENTO()
        {
            return FECHA_NACIMIENTO;
        }

        public ALUMNO getID_ALUMNO()
        {
            return ID_AL;
        }


        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO CERTIFICADO_NACIMIENTO VALUES ('" + ID_CERTIFICADO + "','" + NRO_FOLIO + "','" + NRO_LIBRO + "','" + NRO_OFICIALIA + "','" + NRO_PARTIDA + "','" + cnx.fechaSQL(FECHA_NACIMIENTO) + "','" + ID_AL.GETID_alumno()+ "')"; 
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
          ///  String sql = "UPDATE GESTION SET DESCRIPCION='" + DESCRIPCION + "',FECHA_INICIO='" + cnx.fechaSQL(FECHA_INICIO) + "',FECHA_FIN='" + cnx.fechaSQL(FEHCA_FIN) + " WHERE ID_GESTION='" + ID_GESTION + "'";
            String sql = "UPDATE CERTIFICADO_NACIMIENTO SET ID_CERTIFICADO='" + ID_CERTIFICADO + "',NRO_FOLIO='" + NRO_FOLIO + "',NRO_LIBRO='" + NRO_LIBRO + "',NRO_OFICIALIA='" + NRO_OFICIALIA + "',NRO_PARTIDA='" + NRO_PARTIDA + "','" + ID_AL.GETID_alumno() + " WHERE ID_CERTIFICADO='" + ID_CERTIFICADO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM CERTIFICADO_NACIMIENTO  WHERE ID_CERTIFICADO='" + ID_CERTIFICADO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM CERTIFICADO_NACIMIENTO  WHERE ID_CERTIFICADO='" + ID_CERTIFICADO + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_CERTIFICADO = dr.GetString(0);
                NRO_FOLIO = dr.GetInt32(1);
                NRO_LIBRO = dr.GetInt32(2);
                NRO_OFICIALIA = dr.GetInt32(3);
                NRO_PARTIDA = dr.GetInt32(4);
                FECHA_NACIMIENTO = dr.GetDateTime(5);

                ID_AL.setID_alumno(dr.GetString(6));
                ID_AL.buscar();
            }
            dr.Close();
            cnx.CerrarConexion();
        }

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

    }
}
