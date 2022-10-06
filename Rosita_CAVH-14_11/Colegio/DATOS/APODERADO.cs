using System;
using Servidor;
using System.Data.SqlClient;
using System.Data;

namespace Colegio.DATOS
{
    class APODERADO
    {

        private String   ID_APODERADO;
        private int     CI_APODERADO;
        private String AP_PATERNO;
        private String AP_MATERNO;
        private String NOMBRE;
        private String OCUPACION;
        private String MAYOR_GRADO_INSTRUCCION;
        private String PROFESION;
        private String EMPRESA_TRABAJO;
        private int    TELEFONO;
        private String PARENTESCO;
        private String DIRECCION_DOMICILIO;
        private String DIRECCION_OFICINA;

        private ManejadorDeDatos cnx = new ManejadorDeDatos(); 


        public void setID_Apoderado(String ID_Apoderado)
        {
            ID_APODERADO = ID_Apoderado;
        }

        public void setCI_Apoderado(int CI_Apoderado)
        {
            CI_APODERADO = CI_Apoderado;
        }
         public void setApPAternoo(String Ap_Paterno){
            AP_PATERNO= Ap_Paterno;
        }
         public void setApMAternoo(String Ap_Materno)
         {
             AP_MATERNO = Ap_Materno;
         }

        public void setNombre(String Nombre)
        {
            NOMBRE = Nombre;
        }

        public void setOcupacion(String Ocupacion) {
            OCUPACION = Ocupacion;
        }
        public void setMAyorGradoDeInstruccion(String MayorGradoDeIns)
        {
            MAYOR_GRADO_INSTRUCCION = MayorGradoDeIns;
        }


       

        public void setProfesion(String Profesion)
        {
            PROFESION = Profesion;
        }

        public void setEmpresaTrabajo(String EmpresaTrab)
        {
            EMPRESA_TRABAJO = EmpresaTrab;
        }

        public void setTelefono(int Telefono)
        {
            TELEFONO = Telefono;
        }

        public void setParentezco(String Parentezco)
        {
            PARENTESCO = Parentezco;
        }

        public void setDirDomicilio(String DirDomicilio)
        {
            DIRECCION_DOMICILIO= DirDomicilio;
        }

        public void setDirOfic(String DirOficina)
        {
            DIRECCION_OFICINA = DirOficina;
        }

        /// <summary>
        /// getters
        /// </summary>
        /// <returns></returns>
        public String getIDApoderado()
        {
        return    ID_APODERADO;
        }

        public int getCIApoderado()
        {
            return CI_APODERADO;
        }

        public String getOcupacion()
        {
           return OCUPACION;
        }

        public String getApPaterno()
        {
            return AP_PATERNO;
        }
        public String getApMaterno()
        {
            return AP_MATERNO;
        }
        public String getNombre()
        {
            return NOMBRE;
        }
        public String getMayorGradoDeIns()
        {
        return    MAYOR_GRADO_INSTRUCCION ;
        }

        public String getProfesion()
        {
        return    PROFESION ;
        }
        //
        public String getEmpresaTrab()
        {
            return EMPRESA_TRABAJO;
        }
        public int gettELEFONO()
        {
            return TELEFONO;
        }
        public String getPARENTEZCO()
        {
            return PARENTESCO;
        }
        public String getDIRECCION_DOMICILIO()
        {
            return DIRECCION_DOMICILIO;
        }
        public String getDireccion_Oficina()
        {
            return DIRECCION_OFICINA;
        }


        public void insertar() {
            cnx.AbrirConexion();
            String sql = "INSERT INTO APODERADO VALUES ('" + ID_APODERADO + "','" + CI_APODERADO + "','" + AP_PATERNO +
                "','" + AP_MATERNO + "','" + NOMBRE + "','" + OCUPACION + "','" + MAYOR_GRADO_INSTRUCCION +
                "','" +PROFESION + "','" + EMPRESA_TRABAJO + "','" +TELEFONO + "','" + PARENTESCO + 
                "','" + DIRECCION_DOMICILIO+ "','" + DIRECCION_OFICINA + "')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar() {
            cnx.AbrirConexion();
            String sql = "UPDATE APODERADO SET AP_PATERNO='" + AP_PATERNO + "',AP_MATERNO='" +AP_PATERNO +
                "',NOMBRE='" + NOMBRE+ "',OCUPACION='"+OCUPACION+ "',MAYOR_GRADO_INSTRUCCION='"+MAYOR_GRADO_INSTRUCCION+
                "',PROFESION='"+PROFESION+ "',EMPRESA_TRABAJO='"+EMPRESA_TRABAJO+  "',TELEFONO='"+TELEFONO+
                "',PARENTESCO='"+PARENTESCO+"',DIRECCION_DOMICILIO='"+DIRECCION_DOMICILIO+"',DIRECCION_OFICINA='"+DIRECCION_OFICINA+  
                  " WHERE ID_APODERADO='" + ID_APODERADO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        /*
ID_APODERADO VARCHAR (10)NOT NULL,
CI_APODERADO INT ,
AP_PATERNO VARCHAR (20),
AP_MATERNO VARCHAR (20),
NOMBRE VARCHAR (20),
OCUPACION VARCHAR (30),
MAYOR_GRADO_INSTRUCCION VARCHAR (30),
PROFESION VARCHAR (30),
EMPRESA_TRABAJO VARCHAR (30),
TELEFONO INT,
PARENTESCO VARCHAR (10),
DIRECCION_DOMICILIO VARCHAR (50),
DIRECCION_OFICINA VARCHAR (50),
PRIMARY KEY (ID_APODERADO)
         */

        public void eliminar() {
            cnx.AbrirConexion();
            String sql = "DELETE FROM APODERADO  WHERE ID_APODERADO='" + ID_APODERADO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar() {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM APODERADO  WHERE ID_APODERADO='" + ID_APODERADO + "'";    
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_APODERADO = dr.GetString(0);
                CI_APODERADO= dr.GetInt32(1);
                AP_PATERNO= dr.GetString(2);
                AP_MATERNO = dr.GetString(3); 
                NOMBRE= dr.GetString(4);
                OCUPACION = dr.GetString(5);
                MAYOR_GRADO_INSTRUCCION = dr.GetString(6);
                PROFESION = dr.GetString(7);
                EMPRESA_TRABAJO = dr.GetString(8);
                TELEFONO = dr.GetInt32(9);
                PARENTESCO = dr.GetString(10);
                DIRECCION_DOMICILIO = dr.GetString(11);
                DIRECCION_OFICINA = dr.GetString(12); 

            }
            dr.Close();
            cnx.CerrarConexion();
        }

        public DataTable mostrar()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from APODERADO ";
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
