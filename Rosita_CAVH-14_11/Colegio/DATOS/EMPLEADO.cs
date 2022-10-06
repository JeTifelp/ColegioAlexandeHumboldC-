using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Servidor;

namespace Colegio.DATOS
{
    class EMPLEADO
    {
        private String ID_EMPLEADO ;
        private String AP_PATERNO;
        private String AP_MATERNO;
        private String NOMBRE;
        private int  TELEFONO;
        private String DIRECCION;
        private String ESTADO_CIVIL;
        private DateTime FECHA_NACIMIENTO;
        private CARGO ID_CARGO= new CARGO();
       // private String ;
          private ManejadorDeDatos cnx = new ManejadorDeDatos(); 
        //_______________________________________
        public void SETID_EMPLEADO(String ID_EMPL )  
        {   ID_EMPLEADO=ID_EMPL;}
        public void SETAP_PATERNO(String AP_PAT )
        {    AP_PATERNO=AP_PAT;}
        public void SETAP_MATERNO(String AP_MAT) 
        {   AP_MATERNO=AP_MAT;}
        public void SETNOMBRE(String NOMB)     
        {   NOMBRE=NOMB;}
       public void SETTELEFONO(int TELF)    
       {    TELEFONO=TELF;}
        public void SETDIRECCION(String DIRRE) 
        {   DIRECCION=DIRRE;}
        public void SETESTADO_CIVIL(String ESTA_CIV)  
        {   ESTADO_CIVIL=ESTA_CIV;}
        public void SETFECHA_NACIMIENTO(DateTime FECHA) 
        {   FECHA_NACIMIENTO=FECHA;}
        public void SETID_CARGO(CARGO CAR)              
        {   ID_CARGO=CAR;}
            //_______________________
        public String getID_EMPLEADO() {return ID_EMPLEADO ;}

        public String getAP_PATERNO()   {return AP_PATERNO;}
        public String getAP_MATERNO() { return AP_MATERNO; }
        public String getNOMBRE() { return NOMBRE; }
        public int getTELEFONO() { return TELEFONO; }
        public String getDIRECCION() { return DIRECCION; }
        public String getESTADO_CIVIL() { return ESTADO_CIVIL; }
        public DateTime getFECHA_NACIMIENTO() { return FECHA_NACIMIENTO; }
        public CARGO getID_CARGO() { return ID_CARGO; }


               public void insertar()
       {
           cnx.AbrirConexion();
           String sql = "INSERT INTO EMPLEADO VALUES ('" + ID_EMPLEADO + "','" + AP_PATERNO+ "','" 
               +AP_MATERNO+ "','" + NOMBRE+ "','" +TELEFONO  + "','" + DIRECCION + "','" + ESTADO_CIVIL +  
               "','" + cnx.fechaSQL(FECHA_NACIMIENTO) +"','" + ID_CARGO.GETID_CARGO() +" )";
            
           cnx.EjecutarComando(sql);
           cnx.CerrarConexion();
       }

       public void modificar()
       {
           cnx.AbrirConexion();
           //String sql = "UPDATE GESTION SET DESCRIPCION='" + DESCRIPCION + "',FECHA_INICIO='" + cnx.fechaSQL(FECHA_INICIO) + "',FECHA_FIN='" + cnx.fechaSQL(FEHCA_FIN) + " WHERE ID_GESTION='" + ID_GESTION + "'";
           String sql = "UPDATE EMPLEADO SET AP_PATERNO = '"+AP_MATERNO+ "',AP_MATERNO='"+AP_MATERNO+ "',NOMBRE='"+NOMBRE+
               "',TELEFONO'"+TELEFONO+"',DIRECCION='"+DIRECCION+"',ESTADO_CIVIL='"+ESTADO_CIVIL+ "',FECHA_NACIMIENTO='"+ID_CARGO.GETID_CARGO()+
               "' WHERE ID_EMPLEADO='"+ID_EMPLEADO+"' ";
           cnx.EjecutarComando(sql);
           cnx.CerrarConexion();
       }

       public void eliminar()
       {
           cnx.AbrirConexion();
           String sql = "DELETE FROM EMPLEADO  WHERE ID_EMPLEADO='" + ID_EMPLEADO + "'";
           cnx.EjecutarComando(sql);
           cnx.CerrarConexion();
       }

       public void buscar()
       {
           cnx.AbrirConexion();
           String sql = "SELECT* FROM EMPLEADO  WHERE ID_EMPLEADO='" + ID_EMPLEADO + "'";
             SqlDataReader dr = cnx.EjecutarConsulta(sql);
           int d = dr.FieldCount;
           while (dr.Read())
           {
               ID_EMPLEADO = dr.GetString(0);
               AP_PATERNO = dr.GetString(1);
               AP_MATERNO = dr.GetString(2);
               NOMBRE = dr.GetString(3);
               TELEFONO= dr.GetInt32(4);
               DIRECCION = dr.GetString(5);
               ESTADO_CIVIL= dr.GetString(6);
               FECHA_NACIMIENTO=dr.GetDateTime(7);
               ID_CARGO.setIDcargo(dr.GetString(8));
               ID_CARGO .buscar();
               //___________________MANEJO DE LLAVE FORANEA
             
           }
           dr.Close();
           cnx.CerrarConexion();
       }

        /*
ID_EMPLEADO VARCHAR (10) NOT NULL,
AP_PATERNO VARCHAR (20),
AP_MATERNO VARCHAR (20),
NOMBRE VARCHAR (20),
TELEFONO INT,
DIRECCION VARCHAR (50),
ESTADO_CIVIL VARCHAR (10),
FECHA_NACIMIENTO DATE,
ID_CARGO VARCHAR (10) NOT NULL,         
         */
                public DataTable mostrarEMPLEADO()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from EMPLEADO ";
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
