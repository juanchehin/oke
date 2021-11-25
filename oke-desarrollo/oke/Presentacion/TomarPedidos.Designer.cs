
namespace oke.Presentacion
{
    partial class TomarPedidos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TomarPedidos));
            this.panelCanciones = new System.Windows.Forms.Panel();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Pedir = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMesas = new System.Windows.Forms.Panel();
            this.panelContenedorMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCanciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCanciones
            // 
            this.panelCanciones.Controls.Add(this.dataListado);
            this.panelCanciones.Controls.Add(this.pictureBox2);
            this.panelCanciones.Controls.Add(this.pictureBox1);
            this.panelCanciones.Controls.Add(this.txtBuscar);
            this.panelCanciones.Controls.Add(this.label1);
            this.panelCanciones.Location = new System.Drawing.Point(20, 38);
            this.panelCanciones.Name = "panelCanciones";
            this.panelCanciones.Size = new System.Drawing.Size(741, 371);
            this.panelCanciones.TabIndex = 0;
            // 
            // dataListado
            // 
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Pedir});
            this.dataListado.Location = new System.Drawing.Point(18, 116);
            this.dataListado.Name = "dataListado";
            this.dataListado.Size = new System.Drawing.Size(720, 242);
            this.dataListado.TabIndex = 4;
            this.dataListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellClick);
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            // 
            // Pedir
            // 
            this.Pedir.HeaderText = "Pedir";
            this.Pedir.Image = ((System.Drawing.Image)(resources.GetObject("Pedir.Image")));
            this.Pedir.Name = "Pedir";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(291, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(18, 71);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija una cancion";
            // 
            // panelMesas
            // 
            this.panelMesas.Controls.Add(this.label2);
            this.panelMesas.Controls.Add(this.panelContenedorMesas);
            this.panelMesas.Location = new System.Drawing.Point(905, 91);
            this.panelMesas.Name = "panelMesas";
            this.panelMesas.Size = new System.Drawing.Size(277, 235);
            this.panelMesas.TabIndex = 1;
            // 
            // panelContenedorMesas
            // 
            this.panelContenedorMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorMesas.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorMesas.Name = "panelContenedorMesas";
            this.panelContenedorMesas.Size = new System.Drawing.Size(277, 235);
            this.panelContenedorMesas.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Elija una mesa";
            // 
            // TomarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.panelMesas);
            this.Controls.Add(this.panelCanciones);
            this.Name = "TomarPedidos";
            this.Size = new System.Drawing.Size(1227, 443);
            this.Load += new System.EventHandler(this.TomarPedidos_Load);
            this.panelCanciones.ResumeLayout(false);
            this.panelCanciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMesas.ResumeLayout(false);
            this.panelMesas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCanciones;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Pedir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMesas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel panelContenedorMesas;
    }
}
