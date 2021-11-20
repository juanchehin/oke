using oke.Datos;
using oke.Logica;
using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace oke.Presentacion
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        int idusuario;

        private void mostrar_usuarios()
        {
            DataTable dt;
            dusuarios funcion = new dusuarios();
            dt = funcion.mostrar_usuarios();
            dataListado.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = true;
            panelUsuario.Dock = DockStyle.Fill;
            btnGuardar.Visible = true;
            btnGuardarCambios.Visible = false;
            txtUsuario.Clear();
            txtPass.Clear();
        }

        private void Icono_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imagenes";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                Icono.BackgroundImage = null;
                Icono.Image = new Bitmap(dlg.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtPass.Text != "")
                {
                    insertar_usuario();
                    mostrar_usuarios();
                }
                else
                {
                    MessageBox.Show("Ingrese una Contraseña", "Sin Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Usuario", "Sin Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insertar_usuario()
        {
            lusuarios dt = new lusuarios();
            dusuarios funcion = new dusuarios();
            dt.Usuario = txtUsuario.Text;
            dt.Pass = txtPass.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            dt.Icono = ms.GetBuffer();
            dt.Estado = "ACTIVO";
            if (funcion.insertar(dt))
            {
                MessageBox.Show("Usuario Registrado", "Registro Correcto");
                panelUsuario.Visible = false;
                panelUsuario.Dock = DockStyle.None;
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            mostrar_usuarios();
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idusuario = Convert.ToInt32(dataListado.SelectedCells[2].Value.ToString());
            MessageBox.Show("Pasa 0", "Pasa 0");

            if (e.ColumnIndex == this.dataListado.Columns["Eliminar"].Index)
            {
                MessageBox.Show("Pasa", "Pasa");
                DialogResult result;
                result = MessageBox.Show("¿Realmente desea eliminar el registro?","Eliminando registro",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    eliminar_usuario();
                    mostrar_usuarios();
                }
            }

            if (e.ColumnIndex == this.dataListado.Columns["Editar"].Index)
            {
                txtUsuario.Text = dataListado.SelectedCells[3].Value.ToString();
                txtPass.Text = dataListado.SelectedCells[4].Value.ToString();
                Icono.BackgroundImage = null;
                byte[] b = (Byte[])dataListado.SelectedCells[5].Value;
                MemoryStream ms = new MemoryStream(b);
                Icono.Image = Image.FromStream(ms);

                panelUsuario.Visible = true;
                panelUsuario.Dock = DockStyle.Fill;
                btnGuardar.Visible = false;
                btnGuardarCambios.Visible = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
            panelUsuario.Dock = DockStyle.None;
        }

        private void editar_usuario()
        {
            lusuarios dt = new lusuarios();
            dusuarios funcion = new dusuarios();

            dt.Idusuario = idusuario;
            dt.Usuario = txtUsuario.Text;
            dt.Pass = txtPass.Text;

            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            dt.Icono = ms.GetBuffer();
            dt.Estado = "ACTIVO";
            if (funcion.editar(dt))
            {
                MessageBox.Show("Usuario Modificado", "Registro Correcto");
                panelUsuario.Visible = false;
                panelUsuario.Dock = DockStyle.None;
            }
        }

        private void eliminar_usuario()
        {
            lusuarios dt = new lusuarios();
            dusuarios funcion = new dusuarios();

            dt.Idusuario = idusuario;

            if (funcion.eliminar_usuarios(dt))
            {
                MessageBox.Show("Usuario Eliminado", "Eliminacion Correcto");
                panelUsuario.Visible = false;
                panelUsuario.Dock = DockStyle.None;
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            editar_usuario();
            mostrar_usuarios();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("entrea buscar");
            buscar_usuarios();
        }
        private void buscar_usuarios()
        {
            MessageBox.Show("entrea buscar 1");
            DataTable dt;
            dusuarios funcion = new dusuarios();
            dt = funcion.buscar_usuarios(txtBuscador.Text);
            dataListado.DataSource = dt;
        }

        private void txtBuscador_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("entrea enter");
            buscar_usuarios();
        }
    }
}
