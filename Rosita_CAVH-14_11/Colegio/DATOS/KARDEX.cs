using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;
using System.Data;

namespace Colegio.DATOS
{
    class KARDEX
    {
        private String ID_Kardex;
        private String CURSO;
        private String NIVEL;
        private String COLEGIO_PRECEDENCIA;
        private String GESTION;
        private String HERMANOS_EN_EL_COLEGIO;
        private String LUGAR_DE_NACIMIENTO;
        private ALUMNO ID_ALUMNO = new ALUMNO();

        private ManejadorDeDatos cnx = new ManejadorDeDatos();



        public void setID_KARDEX(String id_kardex)
        {
            ID_Kardex = id_kardex;
        }

        public void setCurso(String curso)
        {
            CURSO = curso;
        }

        public void setNivel(String nivel)
        {
            NIVEL = nivel;
        }

        public void setColegio_Precedencia(String colegio_precedencia)
        {
            COLEGIO_PRECEDENCIA = colegio_precedencia;
        }
        public void setGestion(String gestion)
        {
            GESTION = gestion;
        }

        public void setHermanos_En_El_Colegio(String hermanos_en_colegio)
        {
            HERMANOS_EN_EL_COLEGIO = hermanos_en_colegio;
        }

        public void setLugar_De_Nac(String Lugar_Nac)
        {
            LUGAR_DE_NACIMIENTO = Lugar_Nac;
        }
        public void setID_ALUMNO(ALUMNO ID)
        {
            ID_ALUMNO = ID;
        }
        //______________________________________
        public ALUMNO getID_ALUMNO() { return ID_ALUMNO; }

        public String getID_Kardex()
        {
            return ID_Kardex;
        }

        public String getCurso()
        {
            return CURSO;
        }

        public String getNivel()
        {
            return NIVEL;
        }

        public String getColegio_Precendencia()
        {
            return COLEGIO_PRECEDENCIA;
        }


        public String getHermanos_En_El_Colegio()
        {
            return HERMANOS_EN_EL_COLEGIO;
        }

        public String getLugar_De_Nac()
        {
            return LUGAR_DE_NACIMIENTO;
        }



        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO KARDEX VALUES ('" + ID_Kardex + "','" + CURSO + "','" + GESTION +
                "','" + NIVEL + "',,'" + COLEGIO_PRECEDENCIA + "','" + LUGAR_DE_NACIMIENTO + "','" + HERMANOS_EN_EL_COLEGIO + "','" + ID_ALUMNO.GETID_alumno() + "'  )";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        //noce en q consiste esto
        public void modificar()
        {
            cnx.AbrirConexion();
            String sql = "UPDATE KARDEX SET CURSO='" + CURSO + "',GESTION='" + GESTION + "',NIVEL='" + NIVEL + "',COLEGIO_PROCEDENCIA='" + COLEGIO_PRECEDENCIA +
                "',LUGAR_DE_NACIMIENTO='" + LUGAR_DE_NACIMIENTO + "',HERMANOS_EN_EL_COLEGIO='" + HERMANOS_EN_EL_COLEGIO + "',ID_ALUMNO='" + ID_ALUMNO.GETID_alumno() +
                " WHERE ID_KARDEX='" + ID_Kardex + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM KARDEX  WHERE ID_Kardex='" + ID_Kardex + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM KARDEX  WHERE ID_Kardex='" + ID_Kardex + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_Kardex = dr.GetString(0);
                CURSO = dr.GetString(1);
                NIVEL = dr.GetString(2);
                COLEGIO_PRECEDENCIA = dr.GetString(3);
                GESTION = dr.GetString(4);
                HERMANOS_EN_EL_COLEGIO = dr.GetString(5);
                LUGAR_DE_NACIMIENTO = dr.GetString(6);


                ID_ALUMNO.setID_alumno(dr.GetString(7));
                ID_ALUMNO.buscar();
                /*
                 *ID_Empleado.SETID_EMPLEADO(dr.GetString(6));
                ID_Alumno.setID_alumno(dr.GetString(7));
                        private String ID_Kardex;
                        private String CURSO;
                        private String NIVEL;
                        private String COLEGIO_PRECEDENCIA;
                        private String GESTION;
                        private String HERMANOS_EN_EL_COLEGIO;
                        private String LUGAR_DE_NACIMIENTO;
                        private ALUMNO ID_ALUMNO = new ALUMNO();
                 */

            }
            dr.Close();
            cnx.CerrarConexion();
        }

        public DataTable mostrarKARDEX()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from KARDEX ";
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

        public DataTable mostrar2()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from KARDEX ";
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
