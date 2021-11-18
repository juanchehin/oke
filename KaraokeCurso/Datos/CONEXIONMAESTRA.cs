﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using KaraokeCurso.Logica;
namespace KaraokeCurso.Datos
{
  public class CONEXIONMAESTRA
    {
        public static string conexion =Convert.ToString(Desencryptacion.checkServer());
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if(conectar.State ==ConnectionState.Closed)
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
