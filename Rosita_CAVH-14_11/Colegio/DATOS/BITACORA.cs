using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data;
using System.Data.SqlClient;

namespace Colegio.DATOS
{
    class BITACORA
    {
        private ManejadorDeDatos cnx = new ManejadorDeDatos(); 
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private String msgError;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        public String MsgError
        {
            get { return msgError; }
            set { msgError = value; }
        }
        public BITACORA()
        {
            FechaInicio = new DateTime();
            FechaFin = new DateTime();
            MsgError = "";
        }

        #region Metodos de Bitacora
      

        public DataTable listarBitacora()
        {
             SqlConnection sqlcnx = new SqlConnection(cnx.obtennerCaminoConexion());
            SqlCommand sqlcmd = new SqlCommand("SP_LISTAR_BITACORA", sqlcnx);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                sqlcnx.Dispose();
                sqlcmd.Dispose();
            }
        }
        // tiene que devolver una lista con codigo de la enfermedad y procedimiento
        //revisar maneras de obtener  un mejor resultado para tener un mejor filtro
        public DataTable obtenerBitacora()
        {
            SqlConnection sqlcnx = new SqlConnection(cnx.obtennerCaminoConexion());

            SqlCommand sqlcmd = new SqlCommand("SP_OBTENER_BITACORA", sqlcnx);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            SqlParameter SqlPar_FechaInicio = new SqlParameter();
            SqlPar_FechaInicio.ParameterName = "@Fecha_inicio";
            SqlPar_FechaInicio.SqlDbType = SqlDbType.DateTime;
            SqlPar_FechaInicio.Value = this.FechaInicio;
            SqlPar_FechaInicio.Direction = ParameterDirection.Input;
            sqlcmd.Parameters.Add(SqlPar_FechaInicio);

            SqlParameter SqlPar_FechaFin = new SqlParameter();
            SqlPar_FechaFin.ParameterName = "@Fecha_fin";
            SqlPar_FechaFin.SqlDbType = SqlDbType.DateTime;
            SqlPar_FechaFin.Value = this.FechaFin;
            SqlPar_FechaInicio.Direction = ParameterDirection.Input;
            sqlcmd.Parameters.Add(SqlPar_FechaFin);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                sqlcnx.Dispose();
                sqlcmd.Dispose();
            }
        }
       


        #endregion
    }
}
