using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using oke.Logica;
using System.Windows.Forms;
using oke.Datos;

namespace oke.Datos
{
	public class Dcanciones
	{
		public bool insertar_Canciones(Lcanciones parametros)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlCommand cmd = new SqlCommand("insertar_canciones", ConexionMaestra.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
				return false;
			}
			finally
			{
				ConexionMaestra.cerrar();
			}
		}
		public bool eliminar_Canciones(Lcanciones parametros)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlCommand cmd = new SqlCommand("eliminar_canciones", ConexionMaestra.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IdCancion", parametros.IdCancion);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
				return false;
			}
			finally
			{
				ConexionMaestra.cerrar();
			}
		}
		public void buscarCanciones(ref DataTable dt, string buscador)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlDataAdapter da = new SqlDataAdapter("buscar_canciones", ConexionMaestra.conectar);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@letra", buscador);
				da.Fill(dt);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.StackTrace);

			}
			finally
			{
				ConexionMaestra.cerrar();
			}
		}
		public void MostrarCanciones(ref DataTable dt)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlDataAdapter da = new SqlDataAdapter("select top 50 * from Canciones", ConexionMaestra.conectar);
				da.Fill(dt);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.StackTrace);

			}
			finally
			{
				ConexionMaestra.cerrar();
			}
		}
		public void TotalCanciones(ref int Total)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlCommand cmd = new SqlCommand("select count(IdCancion) from Canciones", ConexionMaestra.conectar);
				Total = Convert.ToInt32(cmd.ExecuteScalar());
			}
			catch (Exception)
			{
				Total = 0;

			}
			finally
			{
				ConexionMaestra.cerrar();
			}
		}
		public bool EliminarTodasCanciones()
		{
			try
			{
				ConexionMaestra.abrir();
				SqlCommand cmd = new SqlCommand("delete from Canciones", ConexionMaestra.conectar);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
				return false;
			}
			finally
			{
				ConexionMaestra.cerrar();
			}
		}

	}
}
