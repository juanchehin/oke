﻿using System;
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
    }
}
