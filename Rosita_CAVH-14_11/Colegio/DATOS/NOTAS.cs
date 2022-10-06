using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;
using System.Data;

namespace Colegio.DATOS
{
    class NOTAS
    {
        private String ID_NOTAS;
        private String TIPO;
        private int CALIFICACION;
        private DateTime FECHA;
        private MATERIA_CURSO ID_MATERIA = new MATERIA_CURSO();
        private MATERIA_CURSO ID_CURSO = new MATERIA_CURSO();
        private TRIMESTRE ID_TRIMESTRE= new TRIMESTRE ();
        private ALUMNO ID_ALUMNO = new ALUMNO();

        //__________________________________________
        private ManejadorDeDatos cnx = new ManejadorDeDatos();
        //_________________________________________


        public void setID_NOTAS(String idNot)
        {
            ID_NOTAS = idNot;
        }
        public void setTIPO(String TIPO)
        {
            this.TIPO = TIPO;
        }
        public void setCALIFICACION(int CAL)
        {
            CALIFICACION = CAL;
        }
        public void setFECHA(DateTime FECH)
        {
            FECHA = FECH;
        }
        public void setMATERIA(MATERIA_CURSO MATERI)
        {
            ID_MATERIA = MATERI;
        }
        public void setCURSO(MATERIA_CURSO ID_CUR)
        {
            ID_CURSO = ID_CUR;
        }
        public void setID_TRIMESTRE(TRIMESTRE ID_TRIM)
        {
            ID_TRIMESTRE = ID_TRIM;
        }
       public void setID_ALUMNO(ALUMNO idAlumno)
        {
            ID_ALUMNO = idAlumno;
        }

        //_________________________

        public String getID_NOTAS() { return ID_NOTAS; }
        public String getTIPO() { return TIPO; }
        public int getCALIFICACION() { return CALIFICACION; }
        public DateTime getFECHA() { return FECHA; }
        public MATERIA_CURSO getMATERIA() { return ID_MATERIA; }
        public MATERIA_CURSO getCURSO() { return ID_CURSO; }
        public TRIMESTRE getID_TRIMESTRE() { return ID_TRIMESTRE; }
        public ALUMNO getID_ALUMNO() { return this.ID_ALUMNO; }

        // ---------------------------------_____________________________

        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO NOTAS VALUES ('" + ID_NOTAS + "','" + TIPO + "','" + CALIFICACION + "','" + cnx.fechaSQL(FECHA) + "','" + ID_MATERIA.GETID_MATERIA() + "','" + ID_CURSO.GETID_CURSO() + "','" + ID_TRIMESTRE.getIdTrimestral() + "','" + ID_ALUMNO.GETID_alumno() + "')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {
            cnx.AbrirConexion();
            ///  String sql = "UPDATE GESTION SET DESCRIPCION='" + DESCRIPCION + "',FECHA_INICIO='" + cnx.fechaSQL(FECHA_INICIO) + "',FECHA_FIN='" + cnx.fechaSQL(FEHCA_FIN) + " WHERE ID_GESTION='" + ID_GESTION + "'";
            String sql = "UPDATE GESTION SET NOTAS='" + ID_NOTAS + "',TIPO='" + TIPO + "',CALIFICACION='" + CALIFICACION + "',FECHA='" + cnx.fechaSQL(FECHA) + "',MATERIA='" + ID_MATERIA.GETID_MATERIA() + "',CURSO='" + ID_CURSO.GETID_CURSO() + "',ID_TRIMESTRE='" + ID_TRIMESTRE.getIdTrimestral() + "',ID_ALUMNO='" + ID_ALUMNO.GETID_alumno() + " WHERE ID_NOTAS='" + ID_NOTAS + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM NOTAS  WHERE ID_NOTAS='" + ID_NOTAS + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM NOTAS  WHERE ID_NOTAS='" + ID_NOTAS + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_NOTAS = dr.GetString(0);
                TIPO = dr.GetString(1);
                CALIFICACION = dr.GetInt32(2);
                FECHA = dr.GetDateTime(3);
                ID_MATERIA.setID_CURSO(dr.GetString(4)) ;   ///////LLAVES FORANEAS FALTA LLAMAR A BUSCAR  DE CADA UNA DE LAS CLASES
                ID_CURSO.setID_MATERIA(dr.GetString(5));
                ID_TRIMESTRE.setIdTrimestral( dr.GetString(6));
                ID_ALUMNO.setID_alumno(dr.GetString(7));

            }
            dr.Close();
            cnx.CerrarConexion();
        }
        public DataTable mostrar()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from NOTAS ";
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
