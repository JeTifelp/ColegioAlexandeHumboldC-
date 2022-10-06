using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;

namespace Colegio.DATOS
{
    class DETALLES_DOCENTE_ESPECIALIDAD
    {
        private DOCENTE ID_DOCENTE = new DOCENTE();
        private ESPECIALIDAD ID_ESPECIALIDAD = new ESPECIALIDAD();

        private ManejadorDeDatos cnx = new ManejadorDeDatos();

        public void setID_ESPECIALIDAD(ESPECIALIDAD idEspecialidad)
        {
            ID_ESPECIALIDAD = idEspecialidad;

        }

        public void setID_DOCENTE(DOCENTE idDocente)
        {
            ID_DOCENTE = idDocente;
        }
        public ESPECIALIDAD getID_ESPECIALIDAD()
        {
            return this.ID_ESPECIALIDAD;
        }
        public DOCENTE getID_DOCENTE()
        {
            return this.ID_DOCENTE;
        }

        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO DETALLES_DOCENTE_ESPECIALIDAD VALUES ('" + ID_DOCENTE.getIDDocente() + "','"
                + ID_ESPECIALIDAD.getID_ESPECIALIDAD() + "'    )";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
            String sql = "UPDATE DETALLES_DOCENTE_ESPECIALIDAD SET NOMBRE_UE=',ID_DONCENTE'" + ID_DOCENTE.getIDDocente() +
                "',ID_ESPECIALIDAD'" + ID_ESPECIALIDAD.getID_ESPECIALIDAD() + " WHERE ID_DOCENTE='" + ID_DOCENTE + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM DETALLES_DOCENTE_ESPECIALIDAD WHERE ID_DOCENTE='" + ID_DOCENTE + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM DETALLES_DOCENTE_ESPECIALIDAD  WHERE ID_DOCENTE='" + ID_DOCENTE + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_DOCENTE.setIDDoc(dr.GetString(0));
                ID_DOCENTE.buscar();
                ID_ESPECIALIDAD.setID_ESPECIALIDAD(dr.GetString(1));
                ID_ESPECIALIDAD.buscar();


            }
            dr.Close();
            cnx.CerrarConexion();
        }

    }

}
