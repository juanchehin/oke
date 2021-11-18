using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using KaraokeApp.Servicio;
using System.Collections.ObjectModel;
using KaraokeApp.Modelo;

namespace KaraokeApp.VistaModelo
{
   public class VMcanciones
    {
		public void buscarCanciones(ref DataTable dt, string buscador)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlDataAdapter da = new SqlDataAdapter("buscarCanciones", CONEXIONMAESTRA.conectar);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@letra", buscador);
				da.Fill(dt);
			}
			catch (Exception )
			{

			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
		public ObservableCollection<Mcanciones> ListarBuscarCanciones(string buscador)
		{
			ObservableCollection<Mcanciones> Canciones = new ObservableCollection<Mcanciones>();
			try
			{
				DataTable dt = new DataTable();
				buscarCanciones(ref dt, buscador);
				foreach (DataRow rdr in dt.Rows)
				{
					Mcanciones parametros = new Mcanciones();
					parametros.IdCancion =Convert.ToInt32( rdr["IdCancion"].ToString());
					parametros.Nombre = rdr["Nombre"].ToString();
					Canciones.Add(parametros);
				}
				return Canciones;

			}
			catch (Exception)
			{
				
			}
			return null;
		}
		public void ComprobarConexion(ref int Id)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand da = new SqlCommand("Select Top 1 IdCancion from Canciones", CONEXIONMAESTRA.conectar);
				Id =Convert.ToInt32( da.ExecuteScalar());
			}
			catch (Exception)
			{
				Id = 0;


			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
	}
}
