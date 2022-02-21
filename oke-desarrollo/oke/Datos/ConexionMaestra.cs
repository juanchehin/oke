﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using oke.Logica;

namespace oke.Datos
{
    public class ConexionMaestra
    {
        //public static string conexion = @"Data source=DESKTOP-9BKC47G\SQLEXPRESS;Initial Catalog=oke;Integrated Security=true";
        public static string conexion = Convert.ToString(Desencriptacion.checkServer());
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if(conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
