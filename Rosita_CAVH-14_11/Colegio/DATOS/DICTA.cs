
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;

namespace Colegio.DATOS
{
    class DICTA
    {

        private MATERIA ID_MATERIA = new MATERIA();
        private DOCENTE ID_DOCENTE = new DOCENTE();

        private ManejadorDeDatos cnx = new ManejadorDeDatos();
        //__________________________________________
        public void setID_MATERIA(MATERIA idMateria)
        {
            ID_MATERIA = idMateria;

        }

        public void setID_DOCENTE(DOCENTE idDocente)
        {
            ID_DOCENTE = idDocente;
        }
        //_______________________________
        public MATERIA getID_MATERIA()
        {
            return this.ID_MATERIA;
        }
        public DOCENTE getID_DOCENTE()
        {
            return this.ID_DOCENTE;
        }
        //______________________________
        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO DICTA VALUES ('" + ID_MATERIA.GETID_materia() + "','" + ID_DOCENTE.getIDDocente() + "'    )";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
            String sql = "UPDATE DICTA SET NOMBRE_UE=',ID_MATERIA'" + ID_MATERIA.GETID_materia() + "',ID_DOCENTE'" + ID_DOCENTE.getIDDocente() +
                " WHERE ID_MATERIA='" + ID_MATERIA + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM DICTA WHERE ID_MATERIA='" + ID_MATERIA + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM RUDE  WHERE ID_MATERIA='" + ID_MATERIA + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {

                ID_MATERIA.setID_materia(dr.GetString(0));
                ID_MATERIA.buscar();
                ID_DOCENTE.setIDDoc(dr.GetString(1));
                ID_DOCENTE.buscar();

            }
            dr.Close();
            cnx.CerrarConexion();
        }

    }
}




