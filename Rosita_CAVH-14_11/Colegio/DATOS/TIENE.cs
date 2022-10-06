using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;

namespace Colegio.DATOS
{
    class TIENE
    {

        private ALUMNO ID_ALUMNO = new ALUMNO();
        private APODERADO ID_APODERADO = new APODERADO();

        private ManejadorDeDatos cnx = new ManejadorDeDatos();
        /// <summary>
        /// //
        /// </summary>
        /// <param name="idAlumno"></param>
        public void setID_ALUMNO(ALUMNO idAlumno)
        {
            ID_ALUMNO = idAlumno;
        }

        public void setID_APODERADO(APODERADO idApoderado)
        {
            ID_APODERADO = idApoderado;
        }
        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
        public ALUMNO getID_ALUMNO()
        {
            return this.ID_ALUMNO;
        }
        public APODERADO getID_APODERADO()
        {
            return this.ID_APODERADO;
        }

        /// <summary>
        /// 
        /// </summary>
        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO TIENE VALUES ('" + ID_ALUMNO.GETID_alumno() + "','" + ID_APODERADO.getIDApoderado() + "'    )";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
            String sql = "UPDATE TIENE SET NOMBRE_UE=',ID_ALUMNO'" + ID_ALUMNO.GETID_alumno() + "',ID_APODERADO'" + ID_APODERADO.getIDApoderado() + " WHERE ID_ALUMNO='" + ID_ALUMNO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM TIENE  WHERE ID_ALUMNO='" + ID_ALUMNO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM TIENE  WHERE ID_ALUMNO='" + ID_ALUMNO + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {

                ID_ALUMNO.setID_alumno(dr.GetString(0));
                ID_ALUMNO.buscar();
                ID_APODERADO.setID_Apoderado(dr.GetString(1));
                ID_APODERADO.buscar();

            }
            dr.Close();
            cnx.CerrarConexion();
        }
    }
}



