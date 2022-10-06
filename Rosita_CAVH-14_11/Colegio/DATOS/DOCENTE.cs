using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;



using System.Data;
namespace Colegio.DATOS
{
    class DOCENTE
    {

        private String AP_PATERNO;
        private String AP_MATERNO; 
        private String NOMBRE; 
        private String DIRECCION;
       // private String Estado; 
        private DateTime FECHA_NACIMIENTO; 
        private int HORAS_TRABAJO; 
        private String ID_DOCENTE;
        private String TELEFONO;
        private ManejadorDeDatos cnx = new ManejadorDeDatos(); 



        public void setApPater(String apPterno){
            AP_PATERNO=apPterno ;
        }

        public void setApMaterno(String APMATERNO)
        {
            AP_PATERNO = APMATERNO;
        }

        public void setNombre(String Nombre) {
            NOMBRE = Nombre;
        }

        public void setDireccion(String Direccion) {
            DIRECCION = Direccion;
        }

        /* public void setEstado(String ESTADO) {
            Estado = ESTADO;
        }
        */
         public void setFechaNac(DateTime FECHA_NAC) {
            FECHA_NACIMIENTO = FECHA_NAC;
        }

         public void setHorasT(Int32 HORAST) {
            HORAS_TRABAJO = HORAST;
        }
         public void setIDDoc(String ID_DOC) {
            ID_DOCENTE = ID_DOC;
        }

        public void setTELEFONO(String Telef) {
            TELEFONO = Telef;
        }

        public String getaApPaterno()
        {
        return    AP_PATERNO;
        }

        public String getApMaterno()
        {
           return AP_MATERNO;
        }
        public String getNombre()
        {
           return NOMBRE;
        }
        public String getDireccion()
        {
           return DIRECCION;
        }
      /*  public String getEstado()
        {
           return Estado;
        }
        */
        public DateTime getFECHANac()
        {
        return    FECHA_NACIMIENTO ;
        }

        public Int32 getHorasTrabajo()
        {
        return    HORAS_TRABAJO ;
        }
        public String getIDDocente()
        {
        return    ID_DOCENTE ;
        }
        public String getTelefono()
        {
        return   TELEFONO ;
        }


        public void insertar() {
            cnx.AbrirConexion();
            String sql = "INSERT INTO DOCENTE VALUES ('"+ID_DOCENTE+"','"+AP_PATERNO+"','"+AP_MATERNO+"','"+NOMBRE +
                            "','"+HORAS_TRABAJO+"','"+TELEFONO+"','"+DIRECCION+"','"+cnx.fechaSQL(FECHA_NACIMIENTO)+"')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar() {
            cnx.AbrirConexion();
            String sql = "UPDATE DOCENTE SET AP_PATERNO='" + AP_PATERNO + "',AP_MATERNO='" +AP_MATERNO + 
                "',NOMBRE='" +NOMBRE+ "',HORAS_TRABAJO='" +HORAS_TRABAJO+"',TELEFONO='" +TELEFONO+
                "',DIRECCION='" +DIRECCION+"',FECHA_NACIMIENTO='" +cnx.fechaSQL(FECHA_NACIMIENTO)+  " WHERE ID_DOCENTE='" + ID_DOCENTE + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }
        /*
ID_DOCENTE VARCHAR (10) NOT NULL,
         * 
AP_PATERNO VARCHAR (20),
AP_MATERNO VARCHAR (20),
NOMBRE VARCHAR (20),
HORAS_TRABAJO INT ,
TELEFONO INT,
DIRECCION VARCHAR (50),
FECHA_NACIMIENTO DATE,
PRIMARY KEY (ID_DOCENTE)
         */


        public void eliminar() {

            cnx.AbrirConexion();
            String sql = "DELETE FROM DOCENTE  WHERE ID_DOCENTE='" +ID_DOCENTE + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar() {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM DOCENTE  WHERE ID_DOCENTE='" + ID_DOCENTE + "'";    
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_DOCENTE = dr.GetString(0);
                AP_PATERNO = dr.GetString(1);
                AP_MATERNO = dr.GetString(2);
                NOMBRE = dr.GetString(3);      
                HORAS_TRABAJO= dr.GetInt32(4);
                TELEFONO= dr.GetString(5);
                DIRECCION= dr.GetString(6);
                FECHA_NACIMIENTO= dr.GetDateTime(7);

            }
            dr.Close();
            cnx.CerrarConexion();
        }

        public DataTable mostrar()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from DOCENTE ";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
            return table;
        }
    }






    }

