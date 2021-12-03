using oke.Datos;
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
    public partial class VerPedidos : UserControl
    {
        public VerPedidos()
        {
            InitializeComponent();
        }
        private void VerPedidos_Load(object sender, EventArgs e)
        {
            MostrarPedidos();
        }
        public void MostrarPedidos()
        {
            try
            {
                PanelPedidos.Controls.Clear();
                DataTable dt = new DataTable();
                Dpedidos funcion = new Dpedidos();
                funcion.MostrarPedidos(ref dt);
                foreach (DataRow rdr in dt.Rows)
                {
                    Button btnDespachar = new Button();
                    Button btnCopiar = new Button();
                    Button btnMesa = new Button();
                    Button btnEliminar = new Button();
                    Label LabelCancion = new Label();
                    Panel panelConte = new Panel();
                    Panel Panelbotones = new Panel();
                    Label LabelEstado = new Label();
                    PictureBox ImagenSonando = new PictureBox();

                    LabelCancion.Text = rdr["Cancion"].ToString();
                    btnMesa.Text = "Mesa " + rdr["Mesa"].ToString();
                    LabelEstado.Text = rdr["Estado"].ToString();
                    btnDespachar.Text = "Despachar";
                    btnCopiar.Text = "copiar";
                    btnCopiar.Tag = rdr["Cancion"].ToString();
                    btnEliminar.Name = rdr["IdPedido"].ToString();
                    btnEliminar.Text = "Eliminar";
                    //*************
                    btnMesa.ForeColor = Color.White;
                    btnMesa.BackColor = Color.Transparent;
                    btnMesa.TextAlign = ContentAlignment.MiddleCenter;
                    btnMesa.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    btnMesa.Size = new Size(118, 114);
                    btnMesa.Dock = DockStyle.Left;
                    btnMesa.FlatStyle = FlatStyle.Flat;
                    // btnMesa.BackgroundImage = Properties.Resources.negro;
                    btnMesa.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btnMesa.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    btnMesa.BackgroundImageLayout = ImageLayout.Stretch;
                    btnMesa.FlatAppearance.BorderSize = 0;
                    //*************
                    LabelCancion.ForeColor = Color.White;
                    LabelCancion.BackColor = Color.Transparent;
                    LabelCancion.TextAlign = ContentAlignment.MiddleCenter;
                    LabelCancion.AutoSize = false;
                    LabelCancion.Font = new Font("Microsoft Sans Serif", 12);
                    LabelCancion.Size = new Size(688, 61);
                    LabelCancion.Dock = DockStyle.Top;
                    //*************
                    // btnDespachar.BackgroundImage = Properties.Resources.naranja;
                    btnDespachar.Size = new Size(125, 53);
                    btnDespachar.Dock = DockStyle.Right;
                    btnDespachar.BackColor = Color.Transparent;
                    btnDespachar.FlatStyle = FlatStyle.Flat;
                    btnDespachar.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btnDespachar.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    btnDespachar.BackgroundImageLayout = ImageLayout.Stretch;
                    btnDespachar.FlatAppearance.BorderSize = 0;
                    btnDespachar.ForeColor = Color.White;
                    btnDespachar.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    btnDespachar.Name = rdr["IdPedido"].ToString();
                    //*************
                    btnCopiar.Size = new Size(70, 53);
                    btnCopiar.Dock = DockStyle.Right;
                    btnCopiar.BackColor = Color.Transparent;
                    btnCopiar.FlatStyle = FlatStyle.Flat;
                    btnCopiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
                    btnCopiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 25);
                    btnCopiar.FlatAppearance.BorderSize = 0;
                    btnCopiar.ForeColor = Color.WhiteSmoke;
                    btnCopiar.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    btnCopiar.Cursor = Cursors.Hand;
                    //*************
                    btnEliminar.Size = new Size(125, 53);
                    btnEliminar.Dock = DockStyle.Right;
                    btnEliminar.BackColor = Color.Transparent;
                    // btnEliminar.BackgroundImage = Properties.Resources.rosa;
                    btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
                    btnEliminar.FlatStyle = FlatStyle.Flat;
                    btnEliminar.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btnEliminar.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    btnEliminar.FlatAppearance.BorderSize = 0;
                    btnEliminar.ForeColor = Color.WhiteSmoke;
                    btnEliminar.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    //*************
                    LabelEstado.ForeColor = Color.FromArgb(255, 179, 0);
                    LabelEstado.BackColor = Color.Transparent;
                    LabelEstado.TextAlign = ContentAlignment.MiddleCenter;
                    LabelEstado.AutoSize = false;
                    LabelEstado.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    LabelEstado.Size = new Size(100, 61);
                    LabelEstado.Dock = DockStyle.Right;
                    //*************
                    Panelbotones.Dock = DockStyle.Fill;
                    Panelbotones.BackColor = Color.Transparent;
                    //*************
                    panelConte.Size = new Size(550, 114);
                    panelConte.BackColor = Color.FromArgb(39, 39, 39);
                    //*************
                    // ImagenSonando.Image = Properties.Resources.musica;
                    ImagenSonando.SizeMode = PictureBoxSizeMode.Zoom;
                    ImagenSonando.Dock = DockStyle.Right;
                    ImagenSonando.BackColor = Color.Transparent;
                    //****************
                    if (LabelEstado.Text == "Pendiente")
                    {
                        Panelbotones.Controls.Add(btnDespachar);
                    }
                    else
                    {
                        Panelbotones.Controls.Add(ImagenSonando);
                        panelConte.BackColor = Color.FromArgb(253, 97, 59);
                        LabelEstado.ForeColor = Color.White;
                        btnMesa.BackgroundImage = null;

                    }
                    Panelbotones.Controls.Add(LabelEstado);
                    Panelbotones.Controls.Add(btnCopiar);
                    Panelbotones.Controls.Add(btnEliminar);

                    panelConte.Controls.Add(btnMesa);
                    panelConte.Controls.Add(LabelCancion);
                    panelConte.Controls.Add(Panelbotones);
                    PanelPedidos.Controls.Add(panelConte);
                    LabelCancion.BringToFront();
                    Panelbotones.BringToFront();

                    // btnDespachar.Click += BtnDespachar_Click;
                    // btnCopiar.Click += BtnCopiar_Click;
                    // btnEliminar.Click += BtnEliminar_Click;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
