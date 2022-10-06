using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;

namespace Colegio.DATOS
{
    class MATERIA_CURSO
    {
        private CURSO ID_CURSO = new CURSO() ;
        private MATERIA ID_MATERIA= new MATERIA();
        private ManejadorDeDatos cnx = new ManejadorDeDatos();



        public void SETID_CURSO(CURSO id_C)
        {
            this.ID_CURSO = id_C;
        }

        public void SETID_MATERIA(MATERIA ID_M)
        {
            this.ID_MATERIA = ID_M;
        }

        public CURSO GETID_CURSO()
        {
            return this.ID_CURSO;
        }

        public MATERIA GET_DESCRIPCION()
        {
            return this.ID_MATERIA;
        }

        //___________
        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO MATERIA_CURSO VALUES ('" + ID_CURSO + "', '" + this.ID_MATERIA + "')"; //////CUANDO PASEN LAS TABLAS DE MATERIA Y CURSO COMPLEMENTAR PUES AMBAS SON LLAVES FORANEAS
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
            String sql = " UPDATE MATERIA_CURSO SET ID_MATERIA=    '" + ID_MATERIA + " ID_CURSO='" + ID_CURSO + " WHERE ID_CURSO='" + ID_CURSO + "  ID_MATERIA= '" + ID_MATERIA   + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();//""'
            String sql = " DELETE FROM NIVEL WHERE ID_CURSO='" + ID_CURSO + " AND ID_MATERIA= " + ID_MATERIA + "";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            string sql = "SELECT* FROM MATERIA_CURSO WHERE ID_CURSO='" + ID_CURSO + "'ID_MATERIA='" + ID_MATERIA + "";
            
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_CURSO.setID_Curso(dr.GetString(0));
                ID_MATERIA.setID_materia(dr.GetString(1));

            }
            dr.Close();
            cnx.CerrarConexion();
        }
        public void setID_MATERIA(string ID_MAT)
        {
            throw new NotImplementedException();
        }

        public void setID_CURSO(string ID_CURSO)
        {
            throw new NotImplementedException();
        }

     /*   public string GETID_MATERIA { get; set; }*/

        internal string GETID_MATERIA()
        {
            throw new NotImplementedException();
        }
    }
}
