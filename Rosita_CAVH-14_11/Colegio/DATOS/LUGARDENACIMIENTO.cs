using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servidor;
using System.Data.SqlClient;
using System.Data;

namespace Colegio.DATOS
{

    class LUGARDENACIMIENTO
    {
        private String ID_LN;
        private String PAIS_NACIEMIENTO;
        private String DEPARTAMENTO;
        private String PROVINCIA_ESTADO;
        private String CIUDAD;
       //__________________________________________
        private ManejadorDeDatos cnx = new ManejadorDeDatos();
        //_________________________________________
        public void setPAIS_NACIMIENTO(String pais)
        {
            PAIS_NACIEMIENTO = pais;
        }
        public void setDEPARTAMENTO(String dpto)
        {
            DEPARTAMENTO = dpto;
        }
        public void setPROVINCIA_ESTADO(String prov_estado)
        {
            PROVINCIA_ESTADO = prov_estado;
        }
        public void setCIUDAD(String CIUD)
        {
            CIUDAD = CIUD;
        }
        public void setID_LN(String id_LN)
        {
            ID_LN = id_LN;
        }

        
        //_________________________
        public String getPAIS_NACIMMIENTO()
        {
            return PAIS_NACIEMIENTO;
        }
        public String getDEPARTAMENTO()
        {
            return DEPARTAMENTO;
        }
        public String getPROVINCIA_ESTADO()
        {
            return PROVINCIA_ESTADO;
        }
        public String getCUIDAD()
        {
            return CIUDAD;
        }
        public String getID_LN()
        {
            return ID_LN;
        }

        //________________________________________
        public void insertar()
        {
            cnx.AbrirConexion();
            String sql = "INSERT INTO LUGAR_NACIMIENTO VALUES ('" + ID_LN + "','" + PAIS_NACIEMIENTO + 
                                                   "','" + DEPARTAMENTO + "','" + PROVINCIA_ESTADO + "','" + CIUDAD + "')";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void modificar()
        {     
            cnx.AbrirConexion();
            String sql = "UPDATE LUGAR_NACIMIENTO SET  PAIS_NACIMIENTO='" + PAIS_NACIEMIENTO + "',DEPARTAMENTO='" + DEPARTAMENTO +
                           "',PROVINCIA_ESTADO='" +PROVINCIA_ESTADO +"',CIUDAD='"+CIUDAD+ " WHERE ID_LN='" + ID_LN + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void eliminar()
        {
            cnx.AbrirConexion();
            String sql = "   DELETE FROM LUGAR_NACIMIENTO  WHERE ID_LN='" + ID_LN + "'";
            cnx.EjecutarComando(sql);
            cnx.CerrarConexion();
        }

        public void buscar()
        {
            cnx.AbrirConexion();
            String sql = "SELECT* FROM LUGAR_NACIMIENTO  WHERE ID_LN='" + ID_LN + "'";
            SqlDataReader dr = cnx.EjecutarConsulta(sql);
            int d = dr.FieldCount;
            while (dr.Read())
            {
                ID_LN = dr.GetString(0);
                PAIS_NACIEMIENTO = dr.GetString(1);
                DEPARTAMENTO = dr.GetString(2);
                PROVINCIA_ESTADO = dr.GetString(3);
                CIUDAD = dr.GetString(4);
            }
            dr.Close();
            cnx.CerrarConexion();
        }

        public DataTable mostrarLUGARDENACIMIENTO()//
        {
            DataTable table = new DataTable();
            cnx.AbrirConexion();
            String sql = "select * from  LUGAR_NACIMIENTO";
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
