using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace okeApp.Servicios
{
    public class ConexionMaestra
    {
        public static string ruta = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "connection.txt");
        public static string text = File.ReadAllText(ruta);
        public static string conexion = text;
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
