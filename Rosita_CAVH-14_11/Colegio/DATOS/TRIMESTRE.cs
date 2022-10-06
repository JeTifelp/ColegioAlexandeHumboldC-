using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;
using System.Data;

namespace Colegio.DATOS
{
    class TRIMESTRE
    {
        private String Id_trimestral; //archar (20)not null,
        private string nombre_trimestre; //int not null, 
        private int Id_Libreta;
        //private string curso;
        //private string materia;
        private int Puntaje_conocimiento;//float not null,
        private int Puntaje_dps;//int not null,
        private int Puntaje_trimestre; //float not null,

        private MATERIA_CURSO ID_MATERIA = new MATERIA_CURSO();
        private MATERIA_CURSO ID_CURSO = new MATERIA_CURSO();
        private ALUMNO ID_ALUMNO = new ALUMNO();
        private LIBRETA ID_LIBRET = new LIBRETA();

        private ManejadorDeDatos cnx = new ManejadorDeDatos();

        public void setID_ALUMNO(ALUMNO idAlumno)
        {
            ID_ALUMNO = idAlumno;
        }
        
        public void set_materia(MATERIA_CURSO mate)
        {
            ID_MATERIA = mate;
        }

        public void set_CURSO(MATERIA_CURSO CURSO)
        {
            ID_CURSO = CURSO;
        }

        public void SET_IDLIBRETA(LIBRETA ID_LIB)
        {
            ID_LIBRET = ID_LIB;
        }

        public void setIdTrimestral(String IdTrimestral)
        {
            Id_trimestral = IdTrimestral;
        }

        ////public void setId(int IDnota)
        ////{
        ////    Id_Libreta = IDnota;
        ////}

        public void setNombretrimestre(string Nomtrimestre)
        {
            nombre_trimestre = Nomtrimestre;
        }

        public void setPuntajetrimestre(int puntajeTrimestre)
        {
            Puntaje_trimestre = puntajeTrimestre;
        }

        public void setPuntajeconocimiento(int puntajeconocimiento)
        {
            Puntaje_conocimiento = puntajeconocimiento;
        }

        public void setPuntajeDps(int puntajeDps)
        {
            Puntaje_dps = puntajeDps;
        }
        /// <summary>
        /// //////////////////////       GET
        /// </summary>
        /// <returns></returns>
        public String getIdTrimestral()
        {
            return Id_trimestral;
        }

        public MATERIA_CURSO getIdMATERIA()
        {
            return this.ID_MATERIA;
        }

        public MATERIA_CURSO getIdCURSO()
        {
            return this.ID_CURSO;
        }

        public LIBRETA GET_IDLIBRETA()
        {
            return this.ID_LIBRET;
        }

        public string getNOMBtrimestre()
        {
            return nombre_trimestre;
        }

        public int getPuntajetrimestre()
        {
            return Puntaje_trimestre;
        }

        public int getPuntajeconocimiento()
        {
            return Puntaje_conocimiento;
        }

        public int getPuntajeDps()
        {
            return Puntaje_dps;
        }

        public ALUMNO getID_ALUMNO() { return this.ID_ALUMNO; }

       public void insertar()
       {
           cnx.AbrirConexion();
           String sql = "INSERT INTO TRIMESTRAL VALUES ('" + Id_trimestral + "','" + nombre_trimestre + "','" + ID_ALUMNO.GETID_alumno() + "','" + ID_CURSO.GETID_CURSO() + "','" + ID_MATERIA.GETID_MATERIA() + "','" + Puntaje_conocimiento + "','" + Puntaje_dps + "','" + Puntaje_trimestre + "','"+ID_LIBRET + "')";
           cnx.EjecutarComando(sql);
           cnx.CerrarConexion();
       }
        
        public void modificar()
        {
            cnx.AbrirConexion();
            String sql = "UPDATE TRIMESTRAL SET Id_TRIMESTRE='" + Id_trimestral + "',NOMBRE_TRIMESTRE='" + nombre_trimestre + "',ID_ALUMNO='" + ID_ALUMNO.GETID_alumno() + "',CURSO='" + ID_CURSO.GETID_CURSO() + "',MATERIA='" + ID_MATERIA.GETID_MATERIA() + "',PUNTAJE_CONOCIMIENTO='" + Puntaje_conocimiento + "',PUNTAJE_DPS='" + Puntaje_dps + "',PUNTAJE_TRIMESTRAL='" + Puntaje_trimestre + "',ID_LIBRETA='" + ID_LIBRET + " WHERE Id_trimestral='" + Id_trimestral + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM TRIMESTRAL  WHERE ID_TRIMESTRE='" + Id_trimestral + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }


     /*   public DataTable PROMEDIO()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "SELECT AVG(CALIFICACION) FROM NOTAS N  WHERE N.ID_ALUMNO='" + ID_Alumno + "N.CURSO='" + CURSSO + "N.ID_TRIMESTRE='" + ID_TRIMESTRE + "N.MATERIA='" + MATERIA + "'";

            /*       "SELECT  AVG (CALIFICACION)
                   FROM NOTAS N
                   WHERE N.ID_ALUMNO='AL001' AND N.CURSO='1PRIM' AND N.ID_TRIMESTRE= 'TRI01' AND N.MATERIA='MAT' ";
             * */

         /*   SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
            /* for (int i = 0; i < table.Rows.Count; i++)
             {
              table.DataSet.   
             }*/
        //    return table;
      // }*

        public DataTable MOSTRAR()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from BOLETIN_TRIMESTRAL ";
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


