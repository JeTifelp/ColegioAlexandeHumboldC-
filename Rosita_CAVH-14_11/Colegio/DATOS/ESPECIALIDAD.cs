using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Servidor;

namespace Colegio.DATOS
{
    class ESPECIALIDAD
    {
        private  String ID_ESPECIALIDAD;
        private String DESCRIPCION;
        private ManejadorDeDatos cnx = new ManejadorDeDatos();

        public void setID_ESPECIALIDAD(String IDESPECI) {
            ID_ESPECIALIDAD = IDESPECI;
        }
        public void setDESCRIPCION( String DES) {
            DESCRIPCION = DES;
        }
        public String getID_ESPECIALIDAD() {
            return ID_ESPECIALIDAD;
        }
        public String getDESCRIPCION() {
                    return DESCRIPCION;
        }

        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO ESPECIALIDAD VALUES ('" + ID_ESPECIALIDAD+ "','" + DESCRIPCION + "')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
            String sql = "UPDATE ESPECIALIDAD SET DESCRIPCION='" + DESCRIPCION + " WHERE ID_ESPECIALIDAD='" + ID_ESPECIALIDAD + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM ESPECIALIDAD  WHERE ID_ESPECIALIDAD='" + ID_ESPECIALIDAD + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM ESPECIALIDAD  WHERE ID_ESPECIALIDAD='" + ID_ESPECIALIDAD + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_ESPECIALIDAD = dr.GetString(0);
                DESCRIPCION = dr.GetString(1);
                
            }
            dr.Close();
            cnx.CerrarConexion();
        }


    }
}
