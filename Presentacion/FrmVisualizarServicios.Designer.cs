namespace Presentacion
{
    partial class FrmVisualizarServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualizarServicios));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.DataGridFiltroServicios = new System.Windows.Forms.DataGridView();
            this.IDServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtIdConsulta = new System.Windows.Forms.TextBox();
            this.ComboTipoFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelSuperior.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFiltroServicios)).BeginInit();
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
            this.PanelPrincipal.Controls.Add(this.DataGridFiltroServicios);
            this.PanelPrincipal.Controls.Add(this.TxtIdConsulta);
            this.PanelPrincipal.Controls.Add(this.ComboTipoFiltro);
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Controls.Add(this.BtnBuscar);
            this.PanelPrincipal.Controls.Add(this.pictureBox1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 40);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(900, 660);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // DataGridFiltroServicios
            // 
            this.DataGridFiltroServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridFiltroServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridFiltroServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFiltroServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDServicio,
            this.NombreServicio,
            this.DescripcionServicio,
            this.ValorServicio});
            this.DataGridFiltroServicios.Location = new System.Drawing.Point(29, 210);
            this.DataGridFiltroServicios.Name = "DataGridFiltroServicios";
            this.DataGridFiltroServicios.RowHeadersWidth = 51;
            this.DataGridFiltroServicios.Size = new System.Drawing.Size(840, 425);
            this.DataGridFiltroServicios.TabIndex = 6;
            this.DataGridFiltroServicios.Text = "dataGridView1";
            // 
            // IDServicio
            // 
            this.IDServicio.HeaderText = "IDServicio";
            this.IDServicio.MinimumWidth = 6;
            this.IDServicio.Name = "IDServicio";
            // 
            // NombreServicio
            // 
            this.NombreServicio.HeaderText = "Nombre Del Servicio";
            this.NombreServicio.MinimumWidth = 6;
            this.NombreServicio.Name = "NombreServicio";
            // 
            // DescripcionServicio
            // 
            this.DescripcionServicio.HeaderText = "Descripcion Del Servicio";
            this.DescripcionServicio.MinimumWidth = 6;
            this.DescripcionServicio.Name = "DescripcionServicio";
            // 
            // ValorServicio
            // 
            this.ValorServicio.HeaderText = "Valor Del Servicio";
            this.ValorServicio.MinimumWidth = 6;
            this.ValorServicio.Name = "ValorServicio";
            // 
            // TxtIdConsulta
            // 
            this.TxtIdConsulta.Location = new System.Drawing.Point(186, 116);
            this.TxtIdConsulta.Name = "TxtIdConsulta";
            this.TxtIdConsulta.Size = new System.Drawing.Size(518, 27);
            this.TxtIdConsulta.TabIndex = 0;
            // 
            // ComboTipoFiltro
            // 
            this.ComboTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoFiltro.FormattingEnabled = true;
            this.ComboTipoFiltro.Items.AddRange(new object[] {
            "Consultar Servicio Por Id",
            "Consultar Por Nombre",
            "Consultar Todos"});
            this.ComboTipoFiltro.Location = new System.Drawing.Point(186, 161);
            this.ComboTipoFiltro.Name = "ComboTipoFiltro";
            this.ComboTipoFiltro.Size = new System.Drawing.Size(518, 28);
            this.ComboTipoFiltro.TabIndex = 1;
            this.ComboTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.ComboTipoFiltro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Filtro:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(710, 116);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(94, 29);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(402, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVisualizarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelSuperior);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVisualizarServicios";
            this.Text = "FrmVisualizarServicios";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFiltroServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.TextBox TxtIdConsulta;
        private System.Windows.Forms.ComboBox ComboTipoFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DataGridFiltroServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorServicio;
    }
}