using oke.Datos;
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
    public partial class TomarPedidos : UserControl
    {
        public TomarPedidos()
        {
            InitializeComponent();
        }
        int idMesa;
        int idCancion;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buscarCanciones();
        }

        private void buscarCanciones()
        {
            DataTable dt = new DataTable();
            Dcanciones funcion = new Dcanciones();
            funcion.buscarCanciones(ref dt, txtBuscar.Text);
            dataListado.DataSource = dt;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            dataListado.Columns[1].Visible = false;
        }

        private void dibujarMesas()
        {
            try
            {
                panelCanciones.Visible = false;
                panelMesas.Visible = true;
                panelSaludo.Visible = false;

                panelMesas.Dock = DockStyle.Fill;
                panelContenedorMesas.Controls.Clear();

                DataTable dt = new DataTable();
                Dmesas funcion = new Dmesas();
                funcion.MostrarMesas(ref dt);

                foreach (DataRow rdr in dt.Rows)
                {
                    Button b = new Button();
                    b.Text = rdr["Mesa"].ToString();
                    b.Name = rdr["IdMesa"].ToString();
                    b.Size = new Size(152, 121);
                    b.Font = new Font("Microsoft Sans Serif", 13);
                    b.BackColor = Color.Peru;
                    // b.BackgroundImage = Properties.Resources.verde;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 0;
                    b.ForeColor = Color.White;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Cursor = Cursors.Hand;
                    b.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    b.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    panelContenedorMesas.Controls.Add(b);
                    b.Click += B_Click;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

            }

        }

        private void B_Click(object sender, EventArgs e)
        {
            idMesa = Convert.ToInt32(((Button)sender).Name);
            panelMesas.Visible = false;
            panelCanciones.Visible = true;
            buscarCanciones();
        }

        private void TomarPedidos_Load(object sender, EventArgs e)
        {
            dibujarMesas();
        }

        private void dataListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Pedir"].Index)
            {
                insertar_Pedidos();
            }
        }
        private void insertar_Pedidos()
        {
            Lpedidos parametros = new Lpedidos();
            Dpedidos funcion = new Dpedidos();

            parametros.IdCancion = idCancion;
            parametros.IdMesa = idMesa;
            parametros.Mensaje = "-";

            if (funcion.Insertar_Pedidos(parametros) == true)
            {
                MessageBox.Show("Pedido realizado");
                buscarCanciones();
            }
        }

        private void btnCumpleanos_Click(object sender, EventArgs e)
        {
            txtSaludo.Clear();
            panelSaludo.Visible = true;
            panelSaludo.Location = new Point((Width - panelSaludo.Width) / 2, (Height - panelSaludo.Height) / 2);
            panelSaludo.BringToFront();
            panelCanciones.Enabled = false;
        }

        private void btnPedirC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSaludo.Text))
            {
                insertar_cumpleanios();
                panelCanciones.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese un saludo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void insertar_cumpleanios()
        {
            Lpedidos parametros = new Lpedidos();
            Dpedidos funcion = new Dpedidos();
            parametros.IdMesa = idMesa;
            parametros.Mensaje = txtSaludo.Text;
            if (funcion.insertar_cumpleanios(parametros) == true)
            {
                MessageBox.Show("Pedido realizado");
                panelSaludo.Visible = false;

            }
        }

        private void btnVolverC_Click(object sender, EventArgs e)
        {
            panelSaludo.Visible = false;
            panelCanciones.Enabled = true;
        }
    }
}
