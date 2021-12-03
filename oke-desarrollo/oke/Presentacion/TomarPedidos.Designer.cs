
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
            this.btnCumpleanos = new System.Windows.Forms.Button();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Pedir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMesas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContenedorMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSaludo = new System.Windows.Forms.Panel();
            this.btnVolverC = new System.Windows.Forms.Button();
            this.btnPedirC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSaludo = new System.Windows.Forms.RichTextBox();
            this.ColumnTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCanciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMesas.SuspendLayout();
            this.panelSaludo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCanciones
            // 
            this.panelCanciones.Controls.Add(this.btnCumpleanos);
            this.panelCanciones.Controls.Add(this.dataListado);
            this.panelCanciones.Controls.Add(this.pictureBox1);
            this.panelCanciones.Controls.Add(this.txtBuscar);
            this.panelCanciones.Controls.Add(this.label1);
            this.panelCanciones.Location = new System.Drawing.Point(20, 38);
            this.panelCanciones.Name = "panelCanciones";
            this.panelCanciones.Size = new System.Drawing.Size(741, 371);
            this.panelCanciones.TabIndex = 0;
            // 
            // btnCumpleanos
            // 
            this.btnCumpleanos.BackColor = System.Drawing.Color.Transparent;
            this.btnCumpleanos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCumpleanos.BackgroundImage")));
            this.btnCumpleanos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCumpleanos.Location = new System.Drawing.Point(298, 41);
            this.btnCumpleanos.Name = "btnCumpleanos";
            this.btnCumpleanos.Size = new System.Drawing.Size(79, 57);
            this.btnCumpleanos.TabIndex = 5;
            this.btnCumpleanos.UseVisualStyleBackColor = false;
            this.btnCumpleanos.Click += new System.EventHandler(this.btnCumpleanos_Click);
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToResizeColumns = false;
            this.dataListado.AllowUserToResizeRows = false;
            this.dataListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pedir,
            this.Eliminar,
            this.ColumnTest});
            this.dataListado.Location = new System.Drawing.Point(18, 116);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersVisible = false;
            this.dataListado.Size = new System.Drawing.Size(689, 242);
            this.dataListado.TabIndex = 4;
            this.dataListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellClick);
            // 
            // Pedir
            // 
            this.Pedir.HeaderText = "Pedir";
            this.Pedir.Name = "Pedir";
            this.Pedir.ReadOnly = true;
            this.Pedir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pedir.Width = 37;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 49;
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
            // panelContenedorMesas
            // 
            this.panelContenedorMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorMesas.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorMesas.Name = "panelContenedorMesas";
            this.panelContenedorMesas.Size = new System.Drawing.Size(277, 235);
            this.panelContenedorMesas.TabIndex = 0;
            // 
            // panelSaludo
            // 
            this.panelSaludo.Controls.Add(this.btnVolverC);
            this.panelSaludo.Controls.Add(this.btnPedirC);
            this.panelSaludo.Controls.Add(this.groupBox1);
            this.panelSaludo.Location = new System.Drawing.Point(887, 357);
            this.panelSaludo.Name = "panelSaludo";
            this.panelSaludo.Size = new System.Drawing.Size(332, 196);
            this.panelSaludo.TabIndex = 2;
            // 
            // btnVolverC
            // 
            this.btnVolverC.Location = new System.Drawing.Point(196, 160);
            this.btnVolverC.Name = "btnVolverC";
            this.btnVolverC.Size = new System.Drawing.Size(122, 33);
            this.btnVolverC.TabIndex = 2;
            this.btnVolverC.Text = "Volver";
            this.btnVolverC.UseVisualStyleBackColor = true;
            this.btnVolverC.Click += new System.EventHandler(this.btnVolverC_Click);
            // 
            // btnPedirC
            // 
            this.btnPedirC.Location = new System.Drawing.Point(26, 160);
            this.btnPedirC.Name = "btnPedirC";
            this.btnPedirC.Size = new System.Drawing.Size(125, 33);
            this.btnPedirC.TabIndex = 1;
            this.btnPedirC.Text = "Pedir";
            this.btnPedirC.UseVisualStyleBackColor = true;
            this.btnPedirC.Click += new System.EventHandler(this.btnPedirC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSaludo);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese saludo";
            // 
            // txtSaludo
            // 
            this.txtSaludo.Location = new System.Drawing.Point(8, 32);
            this.txtSaludo.Name = "txtSaludo";
            this.txtSaludo.Size = new System.Drawing.Size(286, 84);
            this.txtSaludo.TabIndex = 0;
            this.txtSaludo.Text = "";
            // 
            // ColumnTest
            // 
            this.ColumnTest.HeaderText = "ColumnTest";
            this.ColumnTest.Name = "ColumnTest";
            this.ColumnTest.ReadOnly = true;
            this.ColumnTest.Width = 88;
            // 
            // TomarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.panelSaludo);
            this.Controls.Add(this.panelMesas);
            this.Controls.Add(this.panelCanciones);
            this.Name = "TomarPedidos";
            this.Size = new System.Drawing.Size(1249, 607);
            this.Load += new System.EventHandler(this.TomarPedidos_Load);
            this.panelCanciones.ResumeLayout(false);
            this.panelCanciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMesas.ResumeLayout(false);
            this.panelMesas.PerformLayout();
            this.panelSaludo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCanciones;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMesas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel panelContenedorMesas;
        private System.Windows.Forms.Panel panelSaludo;
        private System.Windows.Forms.Button btnVolverC;
        private System.Windows.Forms.Button btnPedirC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtSaludo;
        private System.Windows.Forms.Button btnCumpleanos;
        private System.Windows.Forms.DataGridViewButtonColumn Pedir;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTest;
    }
}
