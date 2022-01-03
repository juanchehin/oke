using oke.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oke.Datos
{
    public class Destaciones
    {
        public bool EditarIp(Lestaciones parametros)
        {
            try
            {

                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("EditarIp", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ip", parametros.Ip);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }
        public bool InsertarEstaciones()
        {
            try
            {

                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("InsertarEstaciones", ConexionMaestra.conectar);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }
    }
}
