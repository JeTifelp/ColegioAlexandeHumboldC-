using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Colegio.DATOS
{
    class FOTOGRAFIA
    {
        private String ID_FOTO;
        private ALUMNO ID_ALUM = new ALUMNO();
        private Image FOTO;
        private DateTime FECHA;

        private ManejadorDeDatos cnx = new ManejadorDeDatos();



        public void setID_FOTO(String id_fot)
        {
            ID_FOTO = id_fot;
        }

        public void setID_ALUMNO(ALUMNO id_al)
        {
            ID_ALUM = id_al;
        }

        public void setFOTO(Image fot)
        {
            FOTO = fot;
        }

        public void setFECHA(DateTime fech)
        {
            FECHA = fech;
        }

       /* ____________________________________________________________*/
       
        public String getID_FOTO()
        {
            return ID_FOTO;
        }

        public ALUMNO getID_ALUMNO()
        {
            return ID_ALUM;
        }

        public Image getFOTO()
        {
            return FOTO;
        }

        public DateTime getFECHA()
        {
            return FECHA;
        }


        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO FOTOGRAFIA VALUES ('" + ID_FOTO + "','" + ID_ALUM.GETID_alumno() + "','" + FOTO + "','" + cnx.fechaSQL(FECHA) + "')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
            String sql = "UPDATE FOTOGRAFIA SET ID_FOTO='" + ID_FOTO + "',ID_ALUMNO='" + ID_ALUM.GETID_alumno() + "',FOTO='" +  FOTO+ "',FECHA='" + cnx.fechaSQL(FECHA) + " WHERE ID_GESTION='" + ID_FOTO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM FOTOGRAFIA  WHERE ID_FOTO='" + ID_FOTO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM FOTOGRAFIA  WHERE ID_FOTO='" + ID_FOTO + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_FOTO = dr.GetString(0);
                ID_ALUM.setID_alumno(dr.GetString(1)) ;
             ///   FOTO.Save(dr); ///NOSE COMO LLENARLO
                FECHA = dr.GetDateTime(3);

            }
            dr.Close();
            cnx.CerrarConexion();
        }

       
        public DataTable mostrar()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from FOTOGRAFIA ";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
            /* for (int i = 0; i < table.Rows.Count; i++)
             {
              table.DataSet.   
             }*/
            return table;
        }

    }
}
