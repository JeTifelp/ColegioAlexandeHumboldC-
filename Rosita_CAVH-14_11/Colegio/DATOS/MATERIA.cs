using System;
using Servidor;
using System.Data.SqlClient;
using System.Data;

namespace Colegio.DATOS
{
    class MATERIA{
       private string ID_MATERIA ;// VARCHAR (10) NOT NULL,
       private string NOMBRE;// VARCHAR (20),
       private ManejadorDeDatos cnx = new ManejadorDeDatos(); 

       public MATERIA() { }
        public MATERIA(string ID_MATERIA ,string NOMBRE){
            this.ID_MATERIA = ID_MATERIA;
            this.NOMBRE = NOMBRE;
        }
        public string GETID_materia()
        {
             return ID_MATERIA; 
        }
        public string GETNombre()
        {
             return NOMBRE; 
        }
        public void setID_materia(String ID_materia)
        {
            ID_MATERIA = ID_materia;
        }

        public void setNombre(String Nombre)
        {
            NOMBRE = Nombre;
        }
        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO MATERIA VALUES ('"+ ID_MATERIA + "','" +  NOMBRE + "')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
            String sql = "UPDATE MATERIA SET NOMBRE='" + NOMBRE +  " WHERE ID_MATERIA='" + ID_MATERIA + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM MATERIA  WHERE ID_MATERIA='" + ID_MATERIA + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            string sqll = "SELECT* FROM MATERIA WHERE ID_MATERIA='" + ID_MATERIA + "'";

            SqlDataReader dr = cnx.EjecutarConsulta(sqll);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_MATERIA = dr.GetString(0);
                NOMBRE = dr.GetString(1);


            }
            dr.Close();
            cnx.CerrarConexion();
        }


        public DataTable mostrar()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from MATERIA ";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
            return table;
        }
    

    }
}
