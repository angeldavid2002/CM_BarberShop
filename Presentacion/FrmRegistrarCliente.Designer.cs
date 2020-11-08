namespace Presentacion
{
    partial class FrmRegistrarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarCliente));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.PanelSuperior.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelSuperior.Controls.Add(this.BtnSalir);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(900, 40);
            this.PanelSuperior.TabIndex = 0;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(860, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(40, 40);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.TxtIdentificacion);
            this.PanelPrincipal.Controls.Add(this.TxtNombre);
            this.PanelPrincipal.Controls.Add(this.TxtApellido);
            this.PanelPrincipal.Controls.Add(this.pictureBox1);
            this.PanelPrincipal.Controls.Add(this.TxtDireccion);
            this.PanelPrincipal.Controls.Add(this.TxtTelefono);
            this.PanelPrincipal.Controls.Add(this.TxtEdad);
            this.PanelPrincipal.Controls.Add(this.label7);
            this.PanelPrincipal.Controls.Add(this.label6);
            this.PanelPrincipal.Controls.Add(this.label5);
            this.PanelPrincipal.Controls.Add(this.label4);
            this.PanelPrincipal.Controls.Add(this.label3);
            this.PanelPrincipal.Controls.Add(this.label2);
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Controls.Add(this.BtnRegistrar);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 40);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(900, 410);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnRegistrar.Location = new System.Drawing.Point(421, 338);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(94, 29);
            this.BtnRegistrar.TabIndex = 10;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(404, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registrar Cliente.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(520, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(553, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(525, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(81, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(80, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(41, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Identificacion:";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtEdad.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEdad.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtEdad.Location = new System.Drawing.Point(610, 152);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(250, 30);
            this.TxtEdad.TabIndex = 5;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtTelefono.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelefono.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtTelefono.Location = new System.Drawing.Point(610, 98);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(250, 30);
            this.TxtTelefono.TabIndex = 4;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtDireccion.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDireccion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtDireccion.Location = new System.Drawing.Point(610, 208);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(250, 30);
            this.TxtDireccion.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtApellido.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellido.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtApellido.Location = new System.Drawing.Point(162, 208);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(250, 30);
            this.TxtApellido.TabIndex = 1;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtNombre.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtNombre.Location = new System.Drawing.Point(162, 152);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(250, 30);
            this.TxtNombre.TabIndex = 0;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtIdentificacion.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdentificacion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtIdentificacion.Location = new System.Drawing.Point(162, 98);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(250, 30);
            this.TxtIdentificacion.TabIndex = 2;
            // 
            // FrmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarCliente";
            this.Text = "FrmRegistrarCliente";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}