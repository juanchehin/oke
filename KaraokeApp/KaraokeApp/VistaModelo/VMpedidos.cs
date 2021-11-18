using KaraokeApp.Modelo;
using KaraokeApp.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace KaraokeApp.VistaModelo
{
   public class VMpedidos
    {
        public bool Insertar_Pedidos(Mpedidos parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Pedidos", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdMesa", parametros.IdMesa);
                cmd.Parameters.AddWithValue("@IdCancion", parametros.IdCancion);
                cmd.Parameters.AddWithValue("@Mensaje","-");
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public bool insertar_cumpleanios(Mpedidos parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_cumpleanios", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdMesa", parametros.IdMesa);
                cmd.Parameters.AddWithValue("@Mensaje", parametros.Mensaje);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
