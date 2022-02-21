using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oke.Presentacion.AsistenteInstalacion
{
    public partial class InstaladorBD : Form
    {
        public InstaladorBD()
        {
            InitializeComponent();
        }

        private void InstaladorBD_Load(object sender, EventArgs e)
        {
            centrarPaneles();
        }

        private void centrarPaneles()
        {
            panelInstalandoServidor.Location = new Point((Width - Panel2.Width) / 2, (Height - Panel2.Height) / 2);
            Cursor = Cursors.WaitCursor;
            //Panel4.Visible = false;
            //Panel4.Dock = DockStyle.None;
        }
    }
}
