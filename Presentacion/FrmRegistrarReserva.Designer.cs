namespace Presentacion
{
    partial class FrmRegistrarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarReserva));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.ListViewServicios = new System.Windows.Forms.ListView();
            this.IdServicio = new System.Windows.Forms.ColumnHeader();
            this.NombreServicio = new System.Windows.Forms.ColumnHeader();
            this.DescripcionServicio = new System.Windows.Forms.ColumnHeader();
            this.ValorServicio = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.CmbServicio = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.PanelPrincipal.Controls.Add(this.dateTimePicker1);
            this.PanelPrincipal.Controls.Add(this.ListViewServicios);
            this.PanelPrincipal.Controls.Add(this.label6);
            this.PanelPrincipal.Controls.Add(this.TxtIdCliente);
            this.PanelPrincipal.Controls.Add(this.label5);
            this.PanelPrincipal.Controls.Add(this.label4);
            this.PanelPrincipal.Controls.Add(this.label3);
            this.PanelPrincipal.Controls.Add(this.CmbServicio);
            this.PanelPrincipal.Controls.Add(this.pictureBox1);
            this.PanelPrincipal.Controls.Add(this.button2);
            this.PanelPrincipal.Controls.Add(this.BtnAgregar);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 40);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(900, 510);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // ListViewServicios
            // 
            this.ListViewServicios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdServicio,
            this.NombreServicio,
            this.DescripcionServicio,
            this.ValorServicio});
            this.ListViewServicios.HideSelection = false;
            this.ListViewServicios.Location = new System.Drawing.Point(242, 234);
            this.ListViewServicios.Name = "ListViewServicios";
            this.ListViewServicios.Size = new System.Drawing.Size(492, 173);
            this.ListViewServicios.TabIndex = 11;
            this.ListViewServicios.UseCompatibleStateImageBehavior = false;
            this.ListViewServicios.View = System.Windows.Forms.View.Details;
            // 
            // IdServicio
            // 
            this.IdServicio.Text = "Id servicio";
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
            this.DescripcionServicio.Width = 170;
            // 
            // ValorServicio
            // 
            this.ValorServicio.Text = "valor";
            this.ValorServicio.Width = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(422, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Registrar Reserva";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtIdCliente.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdCliente.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtIdCliente.Location = new System.Drawing.Point(242, 110);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(492, 30);
            this.TxtIdCliente.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(56, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Identificacion cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(159, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Servicio";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(93, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hora de reserva:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(385, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(413, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(740, 199);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(106, 29);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Servicio";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descripcion";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valor";
            this.columnHeader4.Width = 100;
            // 
            // CmbServicio
            // 
            this.CmbServicio.FormattingEnabled = true;
            this.CmbServicio.Location = new System.Drawing.Point(242, 200);
            this.CmbServicio.Name = "CmbServicio";
            this.CmbServicio.Size = new System.Drawing.Size(492, 28);
            this.CmbServicio.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(242, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(492, 27);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // FrmRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarReserva";
            this.Text = "FrmRegistrarReserva";
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
        private System.Windows.Forms.ListView ListViewServicios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader IdServicio;
        private System.Windows.Forms.ColumnHeader NombreServicio;
        private System.Windows.Forms.ColumnHeader DescripcionServicio;
        private System.Windows.Forms.ColumnHeader ValorServicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CmbServicio;
    }
}