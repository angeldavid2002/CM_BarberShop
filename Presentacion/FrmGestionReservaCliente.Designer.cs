namespace Presentacion
{
    partial class FrmGestionReservaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionReservaCliente));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelPrincipalInferior = new System.Windows.Forms.Panel();
            this.BtnEliminarReserva = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtIdReserva = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelPrincipalSuperior = new System.Windows.Forms.Panel();
            this.ListViewServicios = new System.Windows.Forms.ListView();
            this.IdServicio = new System.Windows.Forms.ColumnHeader();
            this.NombreServicio = new System.Windows.Forms.ColumnHeader();
            this.DescripcionServicio = new System.Windows.Forms.ColumnHeader();
            this.ValorServicio = new System.Windows.Forms.ColumnHeader();
            this.BtnAgregarServicio = new System.Windows.Forms.Button();
            this.CmbBarbero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.PictureReserva = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.TxtHoraReserva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelSuperior.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.PanelPrincipalInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelPrincipalSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelSuperior.Controls.Add(this.BtnCerrar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(900, 40);
            this.PanelSuperior.TabIndex = 0;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(860, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(40, 40);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.PanelPrincipalInferior);
            this.PanelPrincipal.Controls.Add(this.PanelPrincipalSuperior);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 40);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(900, 565);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // PanelPrincipalInferior
            // 
            this.PanelPrincipalInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPrincipalInferior.Controls.Add(this.BtnEliminarReserva);
            this.PanelPrincipalInferior.Controls.Add(this.label8);
            this.PanelPrincipalInferior.Controls.Add(this.TxtIdReserva);
            this.PanelPrincipalInferior.Controls.Add(this.pictureBox1);
            this.PanelPrincipalInferior.Controls.Add(this.label6);
            this.PanelPrincipalInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipalInferior.Location = new System.Drawing.Point(0, 388);
            this.PanelPrincipalInferior.Name = "PanelPrincipalInferior";
            this.PanelPrincipalInferior.Size = new System.Drawing.Size(900, 177);
            this.PanelPrincipalInferior.TabIndex = 1;
            // 
            // BtnEliminarReserva
            // 
            this.BtnEliminarReserva.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarReserva.Location = new System.Drawing.Point(658, 129);
            this.BtnEliminarReserva.Name = "BtnEliminarReserva";
            this.BtnEliminarReserva.Size = new System.Drawing.Size(94, 29);
            this.BtnEliminarReserva.TabIndex = 9;
            this.BtnEliminarReserva.Text = "Eliminar";
            this.BtnEliminarReserva.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(159, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "ID reserva:";
            // 
            // TxtIdReserva
            // 
            this.TxtIdReserva.Location = new System.Drawing.Point(243, 129);
            this.TxtIdReserva.Name = "TxtIdReserva";
            this.TxtIdReserva.Size = new System.Drawing.Size(409, 27);
            this.TxtIdReserva.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(364, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(406, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Eliminar Reserva";
            // 
            // PanelPrincipalSuperior
            // 
            this.PanelPrincipalSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPrincipalSuperior.Controls.Add(this.ListViewServicios);
            this.PanelPrincipalSuperior.Controls.Add(this.BtnAgregarServicio);
            this.PanelPrincipalSuperior.Controls.Add(this.CmbBarbero);
            this.PanelPrincipalSuperior.Controls.Add(this.label4);
            this.PanelPrincipalSuperior.Controls.Add(this.BtnRegistrar);
            this.PanelPrincipalSuperior.Controls.Add(this.PictureReserva);
            this.PanelPrincipalSuperior.Controls.Add(this.label7);
            this.PanelPrincipalSuperior.Controls.Add(this.CmbTipoServicio);
            this.PanelPrincipalSuperior.Controls.Add(this.TxtHoraReserva);
            this.PanelPrincipalSuperior.Controls.Add(this.label5);
            this.PanelPrincipalSuperior.Controls.Add(this.label3);
            this.PanelPrincipalSuperior.Controls.Add(this.label2);
            this.PanelPrincipalSuperior.Controls.Add(this.TxtIdentificacion);
            this.PanelPrincipalSuperior.Controls.Add(this.label1);
            this.PanelPrincipalSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPrincipalSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipalSuperior.Name = "PanelPrincipalSuperior";
            this.PanelPrincipalSuperior.Size = new System.Drawing.Size(900, 388);
            this.PanelPrincipalSuperior.TabIndex = 0;
            // 
            // ListViewServicios
            // 
            this.ListViewServicios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdServicio,
            this.NombreServicio,
            this.DescripcionServicio,
            this.ValorServicio});
            this.ListViewServicios.HideSelection = false;
            this.ListViewServicios.Location = new System.Drawing.Point(476, 107);
            this.ListViewServicios.Name = "ListViewServicios";
            this.ListViewServicios.Size = new System.Drawing.Size(411, 173);
            this.ListViewServicios.TabIndex = 11;
            this.ListViewServicios.UseCompatibleStateImageBehavior = false;
            this.ListViewServicios.View = System.Windows.Forms.View.Details;
            // 
            // IdServicio
            // 
            this.IdServicio.Text = "Id Servicio";
            this.IdServicio.Width = 100;
            // 
            // NombreServicio
            // 
            this.NombreServicio.Text = "Nombre";
            this.NombreServicio.Width = 100;
            // 
            // DescripcionServicio
            // 
            this.DescripcionServicio.Text = "Descripcion";
            this.DescripcionServicio.Width = 100;
            // 
            // ValorServicio
            // 
            this.ValorServicio.Text = "Valor";
            this.ValorServicio.Width = 100;
            // 
            // BtnAgregarServicio
            // 
            this.BtnAgregarServicio.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregarServicio.Location = new System.Drawing.Point(364, 248);
            this.BtnAgregarServicio.Name = "BtnAgregarServicio";
            this.BtnAgregarServicio.Size = new System.Drawing.Size(106, 29);
            this.BtnAgregarServicio.TabIndex = 10;
            this.BtnAgregarServicio.Text = "Agregar";
            this.BtnAgregarServicio.UseVisualStyleBackColor = true;
            // 
            // CmbBarbero
            // 
            this.CmbBarbero.FormattingEnabled = true;
            this.CmbBarbero.Location = new System.Drawing.Point(191, 151);
            this.CmbBarbero.Name = "CmbBarbero";
            this.CmbBarbero.Size = new System.Drawing.Size(279, 28);
            this.CmbBarbero.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Barbero:";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.BtnRegistrar.Location = new System.Drawing.Point(385, 327);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(139, 29);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // PictureReserva
            // 
            this.PictureReserva.Image = ((System.Drawing.Image)(resources.GetObject("PictureReserva.Image")));
            this.PictureReserva.Location = new System.Drawing.Point(364, 24);
            this.PictureReserva.Name = "PictureReserva";
            this.PictureReserva.Size = new System.Drawing.Size(206, 77);
            this.PictureReserva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureReserva.TabIndex = 7;
            this.PictureReserva.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(191, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Formato (dia/mes/año hora:minuto)";
            // 
            // CmbTipoServicio
            // 
            this.CmbTipoServicio.FormattingEnabled = true;
            this.CmbTipoServicio.Location = new System.Drawing.Point(88, 249);
            this.CmbTipoServicio.Name = "CmbTipoServicio";
            this.CmbTipoServicio.Size = new System.Drawing.Size(270, 28);
            this.CmbTipoServicio.TabIndex = 5;
            // 
            // TxtHoraReserva
            // 
            this.TxtHoraReserva.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtHoraReserva.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtHoraReserva.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtHoraReserva.Location = new System.Drawing.Point(191, 189);
            this.TxtHoraReserva.Name = "TxtHoraReserva";
            this.TxtHoraReserva.Size = new System.Drawing.Size(279, 30);
            this.TxtHoraReserva.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hora de reserva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Servicio";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identificacion cliente:";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtIdentificacion.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdentificacion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtIdentificacion.Location = new System.Drawing.Point(191, 107);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(279, 30);
            this.TxtIdentificacion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(401, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Reserva";
            // 
            // FrmGestionReservaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 605);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionReservaCliente";
            this.Text = "FrmGestionReservaCliente";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipalInferior.ResumeLayout(false);
            this.PanelPrincipalInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelPrincipalSuperior.ResumeLayout(false);
            this.PanelPrincipalSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel PanelPrincipalInferior;
        private System.Windows.Forms.Panel PanelPrincipalSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTipoServicio;
        private System.Windows.Forms.TextBox TxtHoraReserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnEliminarReserva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtIdReserva;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.PictureBox PictureReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbBarbero;
        private System.Windows.Forms.ListView ListViewServicios;
        private System.Windows.Forms.ColumnHeader IdServicio;
        private System.Windows.Forms.ColumnHeader NombreServicio;
        private System.Windows.Forms.ColumnHeader DescripcionServicio;
        private System.Windows.Forms.ColumnHeader ValorServicio;
        private System.Windows.Forms.Button BtnAgregarServicio;
    }
}