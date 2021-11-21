using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using oke.Logica;
using System.Windows.Forms;
using KaraokeCurso.Datos;
using oke.Datos;

namespace oke.Presentacion
{
    public partial class Catalogo : UserControl
    {
        public Catalogo()
        {
            InitializeComponent();
        }
        string[] archivo;
        int vTotalCanciones;
        int Idcancion;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opd = new OpenFileDialog();
            Opd.Filter = "Musica|*.mp3;*.mp4";
            Opd.Multiselect = true;
            Opd.Title = "Cargador de canciones";
            if (Opd.ShowDialog() == DialogResult.OK)
            {
                Lcanciones parametros = new Lcanciones();
                Dcanciones funcion = new Dcanciones();
                archivo = Opd.SafeFileNames;
                for (int i = 0; i < archivo.Length; i++)
                {
                    parametros.Nombre = archivo[i];
                    funcion.insertar_Canciones(parametros);

                }
                MostrarCanciones();
            }
        }
        private void MostrarCanciones()
        {
            DataTable dt = new DataTable();
            Dcanciones funcion = new Dcanciones();
            funcion.MostrarCanciones(ref dt);
            dataListado.DataSource = dt;
            OcultarColumnas();
            Total();
        }
        private void OcultarColumnas()
        {
            dataListado.Columns[1].Visible = false;
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
        private void Total()
        {
            Dcanciones funcion = new Dcanciones();
            funcion.TotalCanciones(ref vTotalCanciones);
            lblTotalCanciones.Text = vTotalCanciones.ToString();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            MostrarCanciones();
            Total();
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            EliminarTodasCanciones();
        }
        private void EliminarTodasCanciones()
        {
            Dcanciones funcion = new Dcanciones();
            funcion.EliminarTodasCanciones();
            MostrarCanciones();
        }
    }
}
