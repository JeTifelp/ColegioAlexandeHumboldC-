using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;

namespace amyclass
{
    class materias
    {
       private string ID_MATERIA ;// VARCHAR (10) NOT NULL,
       private string NOMBRE;// VARCHAR (20),
       private ManejadorDeDatos cnx = new ManejadorDeDatos(); 

       public materias() { }
        public materias(string ID_MATERIA ,string NOMBRE){
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
            //String sql = "UPDATE GESTION SET DESCRIPCION='" + DESCRIPCION + "',FECHA_INICIO='" + cnx.fechaSQL(FECHA_INICIO) + "',FECHA_FIN='" + cnx.fechaSQL(FEHCA_FIN) + " WHERE ID_GESTION='" + ID_GESTION + "'";
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


       
        

    }
}
