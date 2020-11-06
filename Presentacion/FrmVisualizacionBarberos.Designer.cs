namespace Presentacion
{
    partial class FrmVisualizacionBarberos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualizacionBarberos));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.PanelListaFiltro = new System.Windows.Forms.Panel();
            this.DtGridBarberosFiltrados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroClientesAtendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.TxtIdConsulta = new System.Windows.Forms.TextBox();
            this.PanelSuperior.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelListaFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridBarberosFiltrados)).BeginInit();
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
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(860, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(40, 40);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.AutoScroll = true;
            this.PanelPrincipal.Controls.Add(this.pictureBox1);
            this.PanelPrincipal.Controls.Add(this.BtnBuscar);
            this.PanelPrincipal.Controls.Add(this.PanelListaFiltro);
            this.PanelPrincipal.Controls.Add(this.label2);
            this.PanelPrincipal.Controls.Add(this.CmbTipoFiltro);
            this.PanelPrincipal.Controls.Add(this.TxtIdConsulta);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 40);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(900, 660);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(675, 195);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(94, 29);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // PanelListaFiltro
            // 
            this.PanelListaFiltro.AutoScroll = true;
            this.PanelListaFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelListaFiltro.Controls.Add(this.DtGridBarberosFiltrados);
            this.PanelListaFiltro.Location = new System.Drawing.Point(35, 243);
            this.PanelListaFiltro.Name = "PanelListaFiltro";
            this.PanelListaFiltro.Size = new System.Drawing.Size(824, 389);
            this.PanelListaFiltro.TabIndex = 5;
            // 
            // DtGridBarberosFiltrados
            // 
            this.DtGridBarberosFiltrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridBarberosFiltrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Identificacion,
            this.NumeroTelefono,
            this.Edad,
            this.Direccion,
            this.NumeroClientesAtendidos});
            this.DtGridBarberosFiltrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtGridBarberosFiltrados.Location = new System.Drawing.Point(0, 0);
            this.DtGridBarberosFiltrados.Name = "DtGridBarberosFiltrados";
            this.DtGridBarberosFiltrados.RowHeadersWidth = 51;
            this.DtGridBarberosFiltrados.Size = new System.Drawing.Size(824, 389);
            this.DtGridBarberosFiltrados.TabIndex = 4;
            this.DtGridBarberosFiltrados.Text = "dataGridView1";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 121;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 121;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.MinimumWidth = 6;
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Width = 121;
            // 
            // NumeroTelefono
            // 
            this.NumeroTelefono.HeaderText = "Numero de telefono";
            this.NumeroTelefono.MinimumWidth = 6;
            this.NumeroTelefono.Name = "NumeroTelefono";
            this.NumeroTelefono.Width = 121;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.Width = 121;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 121;
            // 
            // NumeroClientesAtendidos
            // 
            this.NumeroClientesAtendidos.HeaderText = "Numero de clientes atendidos";
            this.NumeroClientesAtendidos.MinimumWidth = 6;
            this.NumeroClientesAtendidos.Name = "NumeroClientesAtendidos";
            this.NumeroClientesAtendidos.Width = 121;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(141, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de filtro";
            // 
            // CmbTipoFiltro
            // 
            this.CmbTipoFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoFiltro.FormattingEnabled = true;
            this.CmbTipoFiltro.Items.AddRange(new object[] {
            "consultar barbero por id",
            "consultar todos",
            "consultar por nombre"});
            this.CmbTipoFiltro.Location = new System.Drawing.Point(243, 195);
            this.CmbTipoFiltro.Name = "CmbTipoFiltro";
            this.CmbTipoFiltro.Size = new System.Drawing.Size(426, 28);
            this.CmbTipoFiltro.TabIndex = 1;
            this.CmbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.CmbTipoFiltro_SelectedIndexChanged);
            // 
            // TxtIdConsulta
            // 
            this.TxtIdConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtIdConsulta.Location = new System.Drawing.Point(243, 152);
            this.TxtIdConsulta.Name = "TxtIdConsulta";
            this.TxtIdConsulta.Size = new System.Drawing.Size(426, 27);
            this.TxtIdConsulta.TabIndex = 0;
            // 
            // FrmVisualizacionBarberos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVisualizacionBarberos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVisualizacionBarberos";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelListaFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGridBarberosFiltrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.ComboBox CmbTipoFiltro;
        private System.Windows.Forms.TextBox TxtIdConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DtGridBarberosFiltrados;
        private System.Windows.Forms.Panel PanelListaFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroClientesAtendidos;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}