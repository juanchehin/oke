using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace okeApp.Servicios
{
    public class ConexionMaestra
    {
        // public static string conexion = @"Data source=DESKTOP-9BKC47G\SQLEXPRESS;Initial Catalog=oke;Integrated Security=true";

        public static string conexion = "Data source=192.168.0.104;Initial Catalog=oke;Integrated Security=false;User Id=okeSQL;Password=okeSQ12";
        // public static string ruta = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "connection.txt");
        // public static string text = File.ReadAllText(ruta);
        // public static string conexion = text;
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
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
