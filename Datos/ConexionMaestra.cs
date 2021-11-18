using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace oke.Datos
{
    internal static class ConexionMaestra
    {
        public static SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-9BKC47G\SQLEXPRESS; Initial Catalog=oke; Integrated Security=true");
    }
}
