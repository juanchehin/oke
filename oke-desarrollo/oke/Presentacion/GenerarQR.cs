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
    public partial class GenerarQR : UserControl
    {
        public GenerarQR()
        {
            InitializeComponent();
        }
        string Ip;
        private void GenerarQR_Load(object sender, EventArgs e)
        {
            ObtenerIpLocal();
        }
        private void ObtenerIpLocal()
        {
            txtIp.Text = Bases.ObtenerIp(ref Ip);
        }
        private void GenerarReporte()
        {
            DataTable dt = new DataTable();
            Dmesas funcion = new Dmesas();
            funcion.mostrarCodigoQR(ref dt);
            CodigosQR rpt = new CodigosQR();
            rpt.DataSource = dt;
            reportViewer1.Visible = true;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }
        private void EditarIp()
        {
            Lestaciones parametros = new Lestaciones();
            Destaciones funcion = new Destaciones();
            parametros.Ip = txtIp.Text;
            funcion.EditarIp(parametros);
        }
        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            EditarIp();
            GenerarReporte();
        }
    }
}
