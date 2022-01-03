using oke.Datos;
using oke.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oke.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            Catalogo control = new Catalogo();
            control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(control);
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();    // Limpia panel padre (cartel bienvenidos)
            Mesas control = new Mesas();
            // control.Dock = DockStyle.Fill;
            
            panelPadre.Controls.Add(control);
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();    // Limpia panel padre (cartel bienvenidos)
            TomarPedidos control = new TomarPedidos();
            control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(control);
        }

        private void timerPedidos_Tick(object sender, EventArgs e)
        {
            ContarPedidos();
        }

        private void ContarPedidos()
        {
            int ContadorPedidos = 0;
            Dpedidos funcion = new Dpedidos();
            funcion.ContarPedidosTodos(ref ContadorPedidos);
            if (ContadorPedidos == 0)
            {
                // panelCantPedidos.Visible = false;
            }
            else
            {
                lblCantPedidos.Text = ContadorPedidos.ToString();
                // panelCantPedidos.Visible = true;
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            VerPedidos control = new VerPedidos();
            control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(control);
        }

        private void btnGenerarQR_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            GenerarQR control = new GenerarQR();
            control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(control);
            // SeleccionarButton(sender);
        }
    }
}
