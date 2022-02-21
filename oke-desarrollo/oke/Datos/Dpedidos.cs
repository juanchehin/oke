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
    public class Dpedidos
    {
        public bool Insertar_Pedidos(Lpedidos parametros)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Pedidos", ConexionMaestra.conectar);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdMesa", parametros.IdMesa);
                cmd.Parameters.AddWithValue("@IdCancion", parametros.IdCancion);
                cmd.Parameters.AddWithValue("@Mensaje", parametros.Mensaje);

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

        public bool EliminarPedidos(Lpedidos parametros)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("eliminar_pedido", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idpedido", parametros.IdPedido);
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

        public bool eliminarPedidosTodos()
        {
            try
            {
                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("eliminar_todos_pedidos", ConexionMaestra.conectar);
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

        public void MostrarPedidos(ref DataTable dt)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarPedidos", ConexionMaestra.conectar);
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

        public void MostrarCumpleanios(ref DataTable dt)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarCumpleanios", ConexionMaestra.conectar);
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

        public void ContarPedidosTodos(ref int Total)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("select count(IdPedido) from Pedidos", ConexionMaestra.conectar);
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

        public bool insertar_cumpleanios(Lpedidos parametros)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("insertar_cumpleanios", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdMesa", parametros.IdMesa);
                cmd.Parameters.AddWithValue("@Mensaje", parametros.Mensaje);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }
        public bool EditarEstadoPedido(Lpedidos parametros)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("editarEstadoPedido", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idpedido", parametros.IdPedido);
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
        public void ContarCumpleaños(ref int Total)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("select count(IdPedido) from Pedidos inner join Canciones on Canciones.IdCancion = Pedidos.IdCancion Where Nombre = '!Happy Birthday!'", ConexionMaestra.conectar);
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
        public void ContarPedidosSinFc(ref int Total)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("select count(IdPedido) from Pedidos  inner join Canciones on Canciones.IdCancion = Pedidos.IdCancion Where Nombre<>'!Happy Birthday!'", ConexionMaestra.conectar);
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
    }
}
