using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Servidor;
using Colegio.DATOS;
using System.Resources;
using Servidor;
using System.Media;
using System.Configuration;
using System.Windows.Forms;
namespace Colegio.DATOS
{
    class ALUMNO
    {
        

       private string ID_ALUMNO;// VARCHAR (10) NOT NULL,
       private string AP_PATERNO;// VARCHAR (20),
       private string AP_MATERNO;// VARCHAR (20),
       private string NOMBRE;// VARCHAR (20),
       private string DIRECCION;// VARCHAR (50),
       private string SEXO;// CHAR,
       private LUGARDENACIMIENTO ID_LN=new LUGARDENACIMIENTO();//VARCHAR (10) NOT NULL,
       private ManejadorDeDatos cnx = new ManejadorDeDatos(); 

        //____________________________________
       public string GETID_alumno()
       {
           return ID_ALUMNO;  
       }
       public string GETAP_paterno()
       {
            return AP_PATERNO;
           }

       public string GETAP_materno()
       {
            return AP_MATERNO ;
           }
       public string GETNombre()
       {
            return NOMBRE;        }

       public string GETDireccion()
       {
            return DIRECCION; 
       }
       public string GETSexo()
       {
          return SEXO; 
       }

       public LUGARDENACIMIENTO GETID_ln()
       {
           return ID_LN;
       }

       public void setID_alumno(String ID_alumno)
       {
           ID_ALUMNO = ID_alumno;
       }

       public void setAP_paterno(String AP_paterno)
       {
           AP_PATERNO = AP_paterno;
       }

       public void setAP_materno(String AP_materno)
       {
           AP_MATERNO = AP_materno;
       }

       public void setNombre(String Nombre)
       {
           NOMBRE =  Nombre;
       }

       public void setDireccion(String Direccion)
       {
           DIRECCION = Direccion;
       }

       public void setSexo(String Sexo)
       {
           SEXO = Sexo;
       }

       public void setID_ln(LUGARDENACIMIENTO ID_ln)
       {
           ID_LN = ID_ln;
       }
       public void insertar()
       {
           cnx.AbrirConexion();
           String sql = "INSERT INTO AlUMNO VALUES ('" + ID_ALUMNO + "','" + AP_PATERNO+ "','" 
               +AP_MATERNO+ "','" + NOMBRE+ "','" + DIRECCION + "','" + SEXO + "','" + ID_LN.getID_LN() +"')";
            
           cnx.EjecutarComando(sql);
           cnx.CerrarConexion();
       }

       public void modificar()
       {
           cnx.AbrirConexion();
           //String sql = "UPDATE GESTION SET DESCRIPCION='" + DESCRIPCION + "',FECHA_INICIO='" + cnx.fechaSQL(FECHA_INICIO) + "',FECHA_FIN='" + cnx.fechaSQL(FEHCA_FIN) + " WHERE ID_GESTION='" + ID_GESTION + "'";
           //String sql = "UPDATE GESTION SET DESCRIPCION='" + DESCRIPCION + "',FECHA_INICIO='" + cnx.fechaSQL(FECHA_INICIO) + "',FECHA_FIN='" + cnx.fechaSQL(FEHCA_FIN) + " WHERE ID_GESTION='" + ID_GESTION + "'";
           String sql = "UPDATE ALUMNO SET AP_PATERNO = '"+AP_MATERNO+ "',AP_MATERNO='"+AP_MATERNO+ "',NOMBRE='"+NOMBRE+"',DIRECCION'"+DIRECCION+"',SEXO='"+SEXO+"',IID_LN='"+ID_LN.getID_LN()+"' WHERE ID_ALUMNO='"+ID_ALUMNO+"' ";
           cnx.EjecutarComando(sql);
           cnx.CerrarConexion();
       }

       public void eliminar()
       {
           cnx.AbrirConexion();
           String sql = "DELETE FROM ALUMNO  WHERE ID_ALUMNO='" + ID_ALUMNO + "'";
           cnx.EjecutarComando(sql);
           cnx.CerrarConexion();
       }

       public void buscar()
       {
           cnx.AbrirConexion();
           String sql = "SELECT* FROM ALUMNO  WHERE ID_ALUMNO='" + ID_ALUMNO + "'";
             SqlDataReader dr = cnx.EjecutarConsulta(sql);
           int d = dr.FieldCount;
           while (dr.Read())
           {
               ID_ALUMNO = dr.GetString(0);
               AP_PATERNO = dr.GetString(1);
               AP_MATERNO = dr.GetString(2);
               NOMBRE = dr.GetString(3);
               DIRECCION = dr.GetString(4);
               SEXO= dr.GetString(5);
               
               //___________________MANEJO DE LLAVE FORANEA
               ID_LN.setID_LN( dr.GetString(6));              
               ID_LN.buscar();
           }
           dr.Close();
           cnx.CerrarConexion();
       }
        //__________________________________
       public DataTable Buscar_ALUMNO_POR_NOMBRE(ALUMNO P)
       {
           DataTable table = new DataTable();
           cnx.AbrirConexion();
           String id = P.GETID_alumno();
           String SQL = "SELECT* FROM ALUMNO  WHERE ID_ALUMNO= '" + id + "'  ";
           cnx.CerrarConexion();     

           return cnx.consultar(SQL);

        }
       //_____________________________________
       



       public DataTable mostrar()
       {
           DataTable table = new DataTable();
           cnx.AbrirConexion();
           String sql = "select * from ALUMNO ";
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


        //__________________________________________-
       public string Obtiene_un_ID_Alumno(string nombresito, string apel_Pa,string apel_Mat )//String codigoparalelo)
       {

           String rpta;
           cnx.AbrirConexion();
           SqlConnection sqlcnx = new SqlConnection(cnx.obtennerCaminoConexion());
           string cantidad ="";
           //SqlConnection sqlcnx = new SqlConnection(cnx.LeerConexion());
           try
           {

               sqlcnx.Open();
               SqlCommand sqlcmd = new SqlCommand("UN_ID_ALUMNO", sqlcnx);
               sqlcmd.CommandType = CommandType.StoredProcedure;


               SqlParameter SqlPar_nombre = new SqlParameter();
               SqlPar_nombre.ParameterName = "@NOMBRE";
               SqlPar_nombre.SqlDbType = SqlDbType.VarChar;
               SqlPar_nombre.Size = 10;
               SqlPar_nombre.Value = nombresito   ; // SqlPar_Sigla.Value = ID_PARALELO;//dar el parametro
               sqlcmd.Parameters.Add(SqlPar_nombre);

               SqlParameter SqlPar_ap_paterno = new SqlParameter();
               SqlPar_ap_paterno.ParameterName = "@APELLPATERNO";
               SqlPar_ap_paterno.SqlDbType = SqlDbType.VarChar;
               SqlPar_ap_paterno.Size = 10;
               SqlPar_ap_paterno.Value =  apel_Pa  ; // SqlPar_Sigla.Value = ID_PARALELO;//dar el parametro
               sqlcmd.Parameters.Add(SqlPar_ap_paterno);

               SqlParameter SqlPar_ap_materno = new SqlParameter();
               SqlPar_ap_materno.ParameterName = "@APELLMATERNNO";
               SqlPar_ap_materno.SqlDbType = SqlDbType.VarChar;
               SqlPar_ap_materno.Size = 10;
               SqlPar_ap_materno.Value =  apel_Mat  ; // SqlPar_Sigla.Value = ID_PARALELO;//dar el parametro
               sqlcmd.Parameters.Add(SqlPar_ap_materno);

               //____________

               SqlParameter SqlPar_Cupo = new SqlParameter();
               SqlPar_Cupo.ParameterName = "@IDALUMNO";
               SqlPar_Cupo.SqlDbType = SqlDbType.Int;
               SqlPar_Cupo.Direction = ParameterDirection.Output;
               sqlcmd.Parameters.Add(SqlPar_Cupo);

               sqlcmd.ExecuteNonQuery();
              // cantidad = (int)sqlcmd.Parameters["@IDALUMNO"].Value;
               //cantidadcuposActualizados= (int)sqlcmd.Parameters["@NroCupo"].Value;
               cantidad = (string)sqlcmd.Parameters["@IDALUMNO"].Value;

           }
           catch (Exception ex)
           {
               rpta = ex.Message;
           }
           finally
           {
               if (sqlcnx.State == ConnectionState.Open) sqlcnx.Close();

           }
           //corregir
           return cantidad;
           cnx.CerrarConexion();

           //____________________________________________
       }
    }
    }

