using System;
using Servidor;
using System.Data.SqlClient;
using System.Data;
using Colegio.DATOS;

namespace Colegio
{
    class CURSO
    {
        private string ID_CURSO ;       //ID_CURSO VARCHAR(10) NOT NULL,
        private string NOMBRE;        //NOMBRE VARCHAR (30),
        private  NIVEL ID_NIVEL=new NIVEL() ;      //ID_NIVEL VARCHAR (10) NOT NULL,
        private ManejadorDeDatos cnx = new ManejadorDeDatos(); 

/*
        public CURSO(string ID_CURSO, string NOMBRE, string ID_NIVEL)
        {
            this.ID_CURSO = ID_CURSO;
            this.NOMBRE = NOMBRE;
            this.ID_NIVEL = ID_NIVEL;
        }
 */
        public string GETID_Curso() 
        {
            return ID_CURSO ;
        }
        public string GETNombre()
        {
            return NOMBRE; 
                    
        }
        public NIVEL GETID_Nivel() 
{
            return ID_NIVEL;
                    
        }
        public void setID_Curso(String ID_Curso)
        {
            ID_CURSO = ID_Curso;
        }

        public void setNombre(String Nombre)
        {
            NOMBRE = Nombre;
        }

        public void ID_Nivel(NIVEL ID_Nivel)
        {
            ID_NIVEL = ID_Nivel;
        }
        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO CURSO VALUES ('"+ID_CURSO + "','" + NOMBRE + "','" + ID_NIVEL.GETID_NIVEL() +"')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
            //String sql = "UPDATE GESTION SET DESCRIPCION='" + DESCRIPCION + "',FECHA_INICIO='" + cnx.fechaSQL(FECHA_INICIO) + "',FECHA_FIN='" + cnx.fechaSQL(FEHCA_FIN) + " WHERE ID_GESTION='" + ID_GESTION + "'";
            String sql = "UPDATE CURSO SET NOMBRE='" + NOMBRE + "',ID_NIVEL='" + ID_NIVEL.GETID_NIVEL() +
                " WHERE ID_CURSO='" + ID_CURSO + "'";                       
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM CURSO  WHERE ID_CURSO='" + ID_CURSO + "'";            
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }
        public void buscar()
        {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM CURSO  WHERE ID_CURSO='" + ID_CURSO + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_CURSO = dr.GetString(0);
                NOMBRE = dr.GetString(1);

                ID_NIVEL.SETID_NIVEL(dr.GetString(3));
                ID_NIVEL.buscar();
                    
                //___________________MANEJO DE LLAVE FORANEA
              
            }
            dr.Close();
            cnx.CerrarConexion();
        }

        public DataTable mostrar()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from CURSO ";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
            return table;
        }

    }
}
