using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;
using Colegio.DATOS;
using System.Data;
using System.Media;
using System.Resources;
namespace Colegio
{
    //_______________________________________________________
   


    class PARALELOS
    {
        private string ID_PARALELO; //VARCHAR (10) NOT NULL,
        private string DESCRIPCION ;//VARCHAR (30),
        private Int32 CUPOS_LLENOS; //INT,
        private Int32 CUPO_MAX ;//INT,
        private   CURSO ID_CURSO= new CURSO();// VARCHAR (10) NOT NULL,
        private string GESTION;
        private ManejadorDeDatos cnx = new ManejadorDeDatos(); 
        /*
        public PARALELOS() { }
        public PARALELOS(string ID_PARALELO, string DESCRIPCION , UInt32 CUPOS_LLENOS,UInt32 CUPO_MAX , string ID_CURSO){
            this.ID_PARALELO=ID_PARALELO;
            this.DESCRIPCION=DESCRIPCION;
            this.CUPOS_LLENOS=CUPOS_LLENOS;
            this.CUPO_MAX=CUPO_MAX;
            this.ID_CURSO=ID_CURSO;
        }
         * */
        public string GETID_paralelo()
        {
            return ID_PARALELO; 
        }

        public string GET_GESTION()
        {
            return GESTION;
        }
        public string GETDescripcion()
        {
             return DESCRIPCION;
        }
        public Int32 Cupos_llenos()
        {
            return CUPOS_LLENOS; 
        }
        public Int32 Cupos_max ()
        {
            return CUPO_MAX;
            }
        public CURSO ID_curso()
        {
            return ID_CURSO; 
        }
        public void setID_curso(CURSO ID_curso)
        {
           ID_CURSO = ID_curso;
        }

        public void setCupos_max(Int32 Cupos_max)
        {
            CUPO_MAX = Cupos_max;
        }

        public void setCupos_llenos(Int32 Cupos_llenos)
        {
            CUPOS_LLENOS = Cupos_llenos;
        }
        public void setDESCRIPCION(String descripcion)
        {
            DESCRIPCION = descripcion;
        }

        public void setID_paralelo(String ID_paralelo)
        {
            ID_PARALELO = ID_paralelo;
        }

        public void setID_GESTION(String GES ) 
        {
            GESTION = GES;
        }

        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT PARALELO VALUES ('" + ID_PARALELO + "','" + DESCRIPCION + "','" + CUPOS_LLENOS +
                "','" + CUPO_MAX + "','" + ID_CURSO.GETID_Curso() +"','"+ GESTION +"')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }


        public void modificar()
        {
            cnx.AbrirConexion();
           String sql = "UPDATE PARELELO SET DESCRIPCION='" + DESCRIPCION + "',CUPOS_LLENOS='" +CUPO_MAX +
               "',CUPO_MAX='" + CUPO_MAX + "',GESTION='" + GESTION + " WHERE ID_GESTION='" + ID_PARALELO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
       
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "DELETE FROM PARALELO  WHERE ID_PARALELO='" + ID_PARALELO + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }
        public void buscar()
        {
       cnx.AbrirConexion();
            String sql = "SELECT* FROM PARALELO  WHERE ID_ALUMNO='" + ID_PARALELO + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_PARALELO = dr.GetString(0);
                DESCRIPCION= dr.GetString(1);
                CUPOS_LLENOS = dr.GetInt32(2);
                CUPO_MAX = dr.GetInt32(3);
                ID_CURSO.setID_Curso(dr.GetString(4));
                GESTION = dr.GetString(5);

                //___________________MANEJO DE LLAVE FORANEA
                
            }
            dr.Close();
            cnx.CerrarConexion();
        }

        public DataTable mostrarPARALELO()
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from PARALELO ";
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

        //    public DataTable PROCEDIMIENTO_CUPO()
        //{
        //    DataTable table = new DataTable();
        //    cnx.AbrirConexion();
        //    String sql = " ALTER proc VerificarCupo @Sigla VARCHAR (10),@NroCupo int output
        //                   as
        //                     declare @CantIns int
        //                     declare @CupoMAX int
        //                   begin 
        //                        select @CantIns = (Select CUPOS_LLENOS  from PARALELO where ID_PARALELO =@Sigla)
        //                        select @CupoMAX= (Select CUPO_MAX from PARALELO where ID_PARALELO =@Sigla)
    
        //                   set @NroCupo=@CupoMAX -@CantIns
        //                   end ";
        //    SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
        //    int d = dr.FieldCount;
        //    table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
        //    dr.Close();
        //    cnx.CerrarConexion();
        //    /* for (int i = 0; i < table.Rows.Count; i++)
        //     {
        //      table.DataSet.   
        //     }*/
        //    return table;
        //}

              public Int32 CUPOS_DISPONIBLES()
        {
            //DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "SELECT (CUPO_MAX-CUPOS_LLENOS) CUPOS DISPONIBLES FROM PARALELO WHERE ID_PARALELO='" + ID_PARALELO + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);// maneja todo los datos de las tablas ya sean 1,2,3...
            int d = dr.FieldCount;
            //table.Load(dr);   //  lo pasa un datareader  a un datatable para mostrar;     
            dr.Close();
            cnx.CerrarConexion();
            /* for (int i = 0; i < table.Rows.Count; i++)
             {
              table.DataSet.   
             }*/
            return Convert.ToInt32(sql);
        }
        //_____________MANEJA CUPOS_____________
              public DataTable Buscar_Cupo(PARALELOS P)
              {
                  DataTable table = new DataTable();
                  cnx.AbrirConexion();
                  String id = P.GETID_paralelo();
                  // String SQL = "SELECT* FROM PARALELO  WHERE ID_PARALELO=" + id+ ;
                  String SQL = "SELECT* FROM PARALELO  WHERE ID_PARALELO= '" + id + "'";
                  // SqlDataReader DR = cnx.EjecutarConsulta(SQL);
                  // int D = DR.FieldCount;
                  //DR.Close();
                  cnx.CerrarConexion();
                  // return table;

                  return cnx.consultar(SQL);

                  /* ManejadorDeDatos con = new ManejadorDeDatos();
                               // cnx.AbrirConexion(); 
                   String iD = P.GETID_paralelo();                    
                   String sql = "SELECT* FROM PARALELO  WHERE ID_PARALELO=" + iD;                        
                               // cnx.CerrarConexion();
                  return con.consultar(sql);
                   */

              }
        //___________procedimiento almancenado____________-

              public int  ObtieneCupos_de_UNParalelos(String codigoparalelo)
              {
                  String rpta;
                  cnx.AbrirConexion();
                  SqlConnection sqlcnx = new SqlConnection(cnx.obtennerCaminoConexion());
                  int cantidad = 0;
                  //SqlConnection sqlcnx = new SqlConnection(cnx.LeerConexion());
                  try
                  {

                      sqlcnx.Open();
                      SqlCommand sqlcmd = new SqlCommand("VerificarCupo", sqlcnx);
                      sqlcmd.CommandType = CommandType.StoredProcedure;


                      SqlParameter SqlPar_Sigla = new SqlParameter();
                      SqlPar_Sigla.ParameterName = "@Sigla";
                      SqlPar_Sigla.SqlDbType = SqlDbType.VarChar;
                      SqlPar_Sigla.Size = 10;
                      SqlPar_Sigla.Value = codigoparalelo; // SqlPar_Sigla.Value = ID_PARALELO;//dar el parametro
                      sqlcmd.Parameters.Add(SqlPar_Sigla);


                      SqlParameter SqlPar_Cupo = new SqlParameter();
                      SqlPar_Cupo.ParameterName = "@NroCupo";
                      SqlPar_Cupo.SqlDbType = SqlDbType.Int;
                      SqlPar_Cupo.Direction = ParameterDirection.Output;
                      sqlcmd.Parameters.Add(SqlPar_Cupo);

                      sqlcmd.ExecuteNonQuery();
                       cantidad = (int)sqlcmd.Parameters["@NroCupo"].Value;
                      //cantidadcuposActualizados= (int)sqlcmd.Parameters["@NroCupo"].Value;
                     

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

              }
        //_____________________orgina_
        /*
         public void ObtieneCupos_de_UNParalelos( )
              {
                  String rpta;
                  cnx.AbrirConexion();
                  SqlConnection sqlcnx = new SqlConnection(cnx.obtennerCaminoConexion());

                  //SqlConnection sqlcnx = new SqlConnection(cnx.LeerConexion());
                  try
                  {

                      sqlcnx.Open();
                      SqlCommand sqlcmd = new SqlCommand("VerificarCupo", sqlcnx);
                      sqlcmd.CommandType = CommandType.StoredProcedure;


                      SqlParameter SqlPar_Sigla = new SqlParameter();
                      SqlPar_Sigla.ParameterName = "@Sigla";
                      SqlPar_Sigla.SqlDbType = SqlDbType.VarChar;
                      SqlPar_Sigla.Size = 10;
                      SqlPar_Sigla.Value = ID_PARALELO;//dar el parametro
                      sqlcmd.Parameters.Add(SqlPar_Sigla);


                      SqlParameter SqlPar_Cupo = new SqlParameter();
                      SqlPar_Cupo.ParameterName = "@NroCupo";
                      SqlPar_Cupo.SqlDbType = SqlDbType.Int;
                      SqlPar_Cupo.Direction = ParameterDirection.Output;
                      sqlcmd.Parameters.Add(SqlPar_Cupo);

                      sqlcmd.ExecuteNonQuery();
                      int cantidads = (int)sqlcmd.Parameters["@NroCupo"].Value;
                      //cantidadcuposActualizados= (int)sqlcmd.Parameters["@NroCupo"].Value;
                      //return cantidads;

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
                  cnx.CerrarConexion();

              }
         */



    }

}
