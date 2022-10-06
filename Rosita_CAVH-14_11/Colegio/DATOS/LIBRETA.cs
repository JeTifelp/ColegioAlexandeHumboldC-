using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;
using System.Data;
using Colegio.DATOS;


namespace Colegio.DATOS
{
    class LIBRETA
    {

        private String ID_LIBRETA;
        private String anio;
        private String CURSSO;//AUMENTADO
        private  String MATERRIA;//AUMENTADO
        private int NOTA_REFORZAMIENTO;
        private int NOTA_ANUAL;

        private EMPLEADO ID_Empleado=new EMPLEADO();
        private ALUMNO ID_Alumno=new ALUMNO();
       // private MATERIA_CURSO

        /*
ID_LIBRETA VARCHAR (10) NOT NULL,
AÑO INT,
CURSO VARCHAR (10) NOT NULL,
MATERIA VARCHAR (10) NOT NULL,
NOTA_REFORZAMIENTO INT,
NOTA_ANUAL INT,
ID_EMPLEADO VARCHAR (10) NOT NULL,
ID_ALUMNO VARCHAR (10) NOT NULL,*/
         private ManejadorDeDatos cnx = new ManejadorDeDatos(); 



        public void setIdLibreta(String IdLibreta){
            ID_LIBRETA=IdLibreta ;
        }

        public void setAnio(String ANIO)
        {
             anio= ANIO;
        }

        public void setNotaReforzamiento(int NOTA_REF) {
            NOTA_REFORZAMIENTO = NOTA_REF;
        }

        public void setNotaAnual(int  NotaAnual) {
            NOTA_ANUAL = NotaAnual;
        }

        public void setID_EMPLEADO(EMPLEADO EMP){ ID_Empleado= EMP;}
        public void setID_ALUMNO(ALUMNO AL){ ID_Alumno=AL;}



        public void setMATERRIA(String MAT){ MATERRIA=MAT;}
        public void setCURSSO(String CUR){CURSSO =CUR ;}

//____________________________________
         

        public String GETMATERRIA(){ return MATERRIA;
        }
        public String GETCURSSO(){return CURSSO;}



        public String getIDLIBRETA()
        {
        return    ID_LIBRETA;
        }

        public String getAnio()
        {
           return anio;
        }
        public int getNotaReforzamiento()
        {
           return NOTA_REFORZAMIENTO;
        }
        public int getNotaAnual()
        {
           return NOTA_ANUAL;
        }
                public ALUMNO getID_alumno()
        {
           return ID_Alumno;
        }
                public EMPLEADO getID_empleado()
        {
           return ID_Empleado;
        }
        
        //_____________________________
        public void insertar() {
            cnx.AbrirConexion();
            String sql = "INSERT INTO LIBRETA VALUES ('"+ID_LIBRETA+"','"+anio+"','"+NOTA_REFORZAMIENTO+"','"+NOTA_ANUAL+ 
                        "','"+MATERRIA+  "','"+CURSSO+ "','" +ID_Empleado.getID_EMPLEADO() +"','"+ID_Alumno.GETID_alumno()+  "')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar() {
            cnx.AbrirConexion();
            String sql = "UPDATE LIBRETA SET AÑO='" + anio + "',CURSO='" + CURSSO+ "',MATERIA='" +MATERRIA + "',NOTA_REFORZAMIENTO='" +NOTA_REFORZAMIENTO +
                "',=NOTA_ANUAL='" +NOTA_ANUAL + "',ID_EMPLEADO='" +ID_Empleado.getID_EMPLEADO() +  "',ID_ALUMNO='" +ID_Alumno.GETID_alumno() + " WHERE ID_LIBRETA='" + ID_LIBRETA + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }


        public void eliminar() {
            cnx.AbrirConexion();
            String sql = "DELETE FROM LIBRETA  WHERE ID_Libreta='" +ID_LIBRETA+ "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar() {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM LIBRETA  WHERE ID_LIBRETA='" + ID_LIBRETA + "'";    
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_LIBRETA = dr.GetString(0);
                anio = dr.GetString(1);
                CURSSO= dr.GetString(2);
                MATERRIA=dr.GetString(3);
                NOTA_REFORZAMIENTO = dr.GetInt32(4);
                NOTA_ANUAL = dr.GetInt32(5);  
         
                ID_Empleado.SETID_EMPLEADO(dr.GetString(6));
                ID_Alumno.setID_alumno(dr.GetString(7));

                        /*
 ID_LIBRETA VARCHAR (10) NOT NULL,
AÑO INT,
CURSO VARCHAR (10) NOT NULL,
MATERIA VARCHAR (10) NOT NULL,
NOTA_REFORZAMIENTO INT,
NOTA_ANUAL INT,
ID_EMPLEADO VARCHAR (10) NOT NULL,
ID_ALUMNO VARCHAR (10) NOT NULL,
         */
            }
            dr.Close();
            cnx.CerrarConexion();
        }


        public DataTable mostrarLIBRETA()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from LIBRETA ";
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
