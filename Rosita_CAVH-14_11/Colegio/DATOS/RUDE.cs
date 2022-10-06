using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Servidor;


namespace Colegio.DATOS
{
    class RUDE
    {
        private String COD_RUDE;
        private String NOMBRE_UE;
        private int CODIGO_SIE;
        private int CODIGO_PROCEDENCIA;
        private  String DEPENDENCIA_UE;
        private String NOMBRE_UE_PROCEDENCIA;
        private  ALUMNO ID_ALUMNO= new ALUMNO();

        //__________________________________________
        private ManejadorDeDatos cnx = new ManejadorDeDatos();
        //_________________________________________


        public void setCOD_RUDE(String COD){
            COD_RUDE=COD;
        }
        public void setNOMBRE_UE(String NOM){
            NOMBRE_UE= NOM; 
        }
        public void setCODIGO_SIE(int SIE){
            CODIGO_SIE= SIE;
        }
        public void setCODIGO_PROCEDENCIA (int CODPROC){
              CODIGO_PROCEDENCIA= CODPROC;
        }
        public void setDEPENDENCIA_UE(String DEP_UE){
            DEPENDENCIA_UE=DEP_UE;
        }
        public void setNOMBRE_UE_PROCEDENCIA(String NOMBRE_UEPROC){
              NOMBRE_UE_PROCEDENCIA=NOMBRE_UEPROC;
        }
        public void setID_ALUMNO(ALUMNO idAlumno){
            ID_ALUMNO= idAlumno;
        }

        //_________________________

        public String getCOD_RUDE() { return COD_RUDE; }
        public String getNOMBRE_UE() { return NOMBRE_UE; }
        public int getCODIGO_SIE() { return CODIGO_SIE; }
        public int getCODIGO_PROCEDENCIA() { return CODIGO_PROCEDENCIA; }
        public String getDEPENDENCIA_UE() { return DEPENDENCIA_UE; }
        public String getNOMBRE_UE_PROCEDENCIA() { return NOMBRE_UE_PROCEDENCIA; }
        public ALUMNO getID_ALUMNO() { return this.ID_ALUMNO; }



        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO RUDE VALUES ('" + COD_RUDE + "','" + NOMBRE_UE + "','" + CODIGO_SIE + "','" + CODIGO_PROCEDENCIA +
                                "','"+DEPENDENCIA_UE+"','"+NOMBRE_UE_PROCEDENCIA+"','"+ ID_ALUMNO.GETID_alumno() +"'    )";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

         public void modificar()
         {
             cnx.AbrirConexion();
             String sql = "UPDATE RUDE SET NOMBRE_UE='" + NOMBRE_UE + "',COD_SIE='" +CODIGO_SIE + "',COD_PROCEDENCIA='"+CODIGO_PROCEDENCIA +
                            "'DEPENDENCIA_UE'"+DEPENDENCIA_UE +"',NOMBRE_UE_PROCEDENCIA'"+NOMBRE_UE_PROCEDENCIA+"',ID_ALUMNO'"+ ID_ALUMNO.GETID_alumno()+  " WHERE COD_RUDE='" + COD_RUDE + "'";
             cnx.EjecutarComando(sql);
             cnx.CerrarConexion();
         }

         public void eliminar()
         {
             cnx.AbrirConexion();
             String sql = "DELETE FROM RUDE  WHERE COD_RUDE='" + COD_RUDE + "'";
             cnx.EjecutarComando(sql);
             cnx.CerrarConexion();
         }

         public void buscar()
         {
             cnx.AbrirConexion();
             String sql = "SELECT* FROM RUDE  WHERE COD_RUDE='" + COD_RUDE + "'";
             SqlDataReader dr = cnx.EjecutarConsulta(sql);
             int d = dr.FieldCount;
             while (dr.Read())
             {
                 COD_RUDE = dr.GetString(0);
                 NOMBRE_UE = dr.GetString(1);
                 CODIGO_SIE = dr.GetInt32(2);
                 CODIGO_PROCEDENCIA = dr.GetInt32(3);
                 DEPENDENCIA_UE=dr.GetString(4);
                    NOMBRE_UE_PROCEDENCIA=dr.GetString(5);
                    ID_ALUMNO.setID_alumno(dr.GetString(6));
                    ID_ALUMNO.buscar();

             }
             dr.Close();
             cnx.CerrarConexion();
         }

         public DataTable mostrar()
         {
             DataTable table = new DataTable();
             cnx.AbrirConexion();
             String sql = "select * from RUDE ";
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
