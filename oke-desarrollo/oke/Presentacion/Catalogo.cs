using KaraokeCurso.Datos;
using oke.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oke.Presentacion
{
    public partial class Catalogo : UserControl
    {
        public Catalogo()
        {
            InitializeComponent();
        }
        string[] archivo;
        int TotalCanciones;
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
            // Total();
        }
        private void OcultarColumnas()
        {
            //datalistado.Columns[1].Visible = false;
        }
    }
}
