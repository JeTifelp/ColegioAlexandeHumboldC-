﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Servidor;






namespace Colegio.DATOS
{
    public class Usuario
    {


        public static int CrearCuentas(string pUsuario, string pContraseña)
        {
            int resultado = 0;
            SqlConnection Conn = ManejadorDeDatos.ObtnerCOnexion();

            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuarios (Nombre, Contraseña) values ('{0}', PwdEncrypt('{1}') )", pUsuario, pContraseña), Conn);

            resultado = Comando.ExecuteNonQuery();
            Conn.Close();

            return resultado;
        }



        public static int Autentificar(String pUsuarios, String pContraseña)
        {
            int resultado = -1;

            SqlConnection conexion = ManejadorDeDatos.ObtnerCOnexion();

            SqlCommand comando = new SqlCommand(string.Format(
                "Select * From Usuarios Where Nombre = '{0}' and PwdCompare('{1}',Contraseña) = 1 ", pUsuarios, pContraseña), conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }

            conexion.Close();
            return resultado;
        }



    }

}


