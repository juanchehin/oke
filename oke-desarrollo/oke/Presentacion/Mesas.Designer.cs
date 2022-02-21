
namespace oke.Presentacion
{
    partial class Mesas
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelMesas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedorMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRegistro = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesaEdicion = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panelMesas.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(698, 40);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar mesa";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // panelMesas
            // 
            this.panelMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMesas.Controls.Add(this.btnAgregar);
            this.panelMesas.Controls.Add(this.label1);
            this.panelMesas.Controls.Add(this.panelContenedorMesas);
            this.panelMesas.Location = new System.Drawing.Point(3, 236);
            this.panelMesas.Name = "panelMesas";
            this.panelMesas.Size = new System.Drawing.Size(889, 344);
            this.panelMesas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelContenedorMesas
            // 
            this.panelContenedorMesas.BackColor = System.Drawing.Color.LightGray;
            this.panelContenedorMesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenedorMesas.Location = new System.Drawing.Point(8, 40);
            this.panelContenedorMesas.Name = "panelContenedorMesas";
            this.panelContenedorMesas.Size = new System.Drawing.Size(684, 412);
            this.panelContenedorMesas.TabIndex = 2;
            // 
            // panelRegistro
            // 
            this.panelRegistro.BackColor = System.Drawing.Color.DarkGray;
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Controls.Add(this.txtMesaEdicion);
            this.panelRegistro.Controls.Add(this.flowLayoutPanel2);
            this.panelRegistro.Location = new System.Drawing.Point(256, 55);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(466, 144);
            this.panelRegistro.TabIndex = 2;
            this.panelRegistro.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el nombre de la mesa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMesaEdicion
            // 
            this.txtMesaEdicion.Location = new System.Drawing.Point(270, 3);
            this.txtMesaEdicion.Name = "txtMesaEdicion";
            this.txtMesaEdicion.Size = new System.Drawing.Size(140, 20);
            this.txtMesaEdicion.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel2.Controls.Add(this.btnGuardarCambios);
            this.flowLayoutPanel2.Controls.Add(this.btnVolver);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 29);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(407, 58);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 32);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(122, 3);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(113, 32);
            this.btnGuardarCambios.TabIndex = 4;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(241, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(113, 32);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMesas);
            this.Controls.Add(this.panelRegistro);
            this.Name = "Mesas";
            this.Size = new System.Drawing.Size(895, 583);
            this.Load += new System.EventHandler(this.Mesas_Load);
            this.panelMesas.ResumeLayout(false);
            this.panelMesas.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelMesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMesaEdicion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.FlowLayoutPanel panelContenedorMesas;
    }
}
