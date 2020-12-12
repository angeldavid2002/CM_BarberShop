namespace Presentacion
{
    partial class FrmVisualizarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualizarClientes));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.BtnEnviarArchivo = new System.Windows.Forms.Button();
            this.BtnGenerarPdf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelFiltro = new System.Windows.Forms.Panel();
            this.DtGridView = new System.Windows.Forms.DataGridView();
            this.identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.TxtIdConsulta = new System.Windows.Forms.TextBox();
            this.PanelSuperior.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridView)).BeginInit();
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
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
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
            this.PanelPrincipal.Controls.Add(this.BtnEnviarArchivo);
            this.PanelPrincipal.Controls.Add(this.BtnGenerarPdf);
            this.PanelPrincipal.Controls.Add(this.pictureBox1);
            this.PanelPrincipal.Controls.Add(this.PanelFiltro);
            this.PanelPrincipal.Controls.Add(this.BtnBuscar);
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Controls.Add(this.CmbTipoFiltro);
            this.PanelPrincipal.Controls.Add(this.TxtIdConsulta);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.ForeColor = System.Drawing.Color.Black;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 40);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(900, 660);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // BtnEnviarArchivo
            // 
            this.BtnEnviarArchivo.Location = new System.Drawing.Point(757, 41);
            this.BtnEnviarArchivo.Name = "BtnEnviarArchivo";
            this.BtnEnviarArchivo.Size = new System.Drawing.Size(131, 29);
            this.BtnEnviarArchivo.TabIndex = 6;
            this.BtnEnviarArchivo.Text = "Enviar Archivo";
            this.BtnEnviarArchivo.UseVisualStyleBackColor = true;
            this.BtnEnviarArchivo.Click += new System.EventHandler(this.BtnEnviarArchivo_Click);
            // 
            // BtnGenerarPdf
            // 
            this.BtnGenerarPdf.Location = new System.Drawing.Point(779, 6);
            this.BtnGenerarPdf.Name = "BtnGenerarPdf";
            this.BtnGenerarPdf.Size = new System.Drawing.Size(109, 29);
            this.BtnGenerarPdf.TabIndex = 2;
            this.BtnGenerarPdf.Text = "Generar Pdf";
            this.BtnGenerarPdf.UseVisualStyleBackColor = true;
            this.BtnGenerarPdf.Click += new System.EventHandler(this.BtnGenerarPdf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PanelFiltro
            // 
            this.PanelFiltro.Controls.Add(this.DtGridView);
            this.PanelFiltro.ForeColor = System.Drawing.Color.Black;
            this.PanelFiltro.Location = new System.Drawing.Point(30, 210);
            this.PanelFiltro.Name = "PanelFiltro";
            this.PanelFiltro.Size = new System.Drawing.Size(831, 425);
            this.PanelFiltro.TabIndex = 4;
            // 
            // DtGridView
            // 
            this.DtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificacion,
            this.nombre,
            this.apellido,
            this.numeroTelefono,
            this.edad,
            this.direccion});
            this.DtGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtGridView.GridColor = System.Drawing.Color.Black;
            this.DtGridView.Location = new System.Drawing.Point(0, 0);
            this.DtGridView.Name = "DtGridView";
            this.DtGridView.RowHeadersWidth = 51;
            this.DtGridView.Size = new System.Drawing.Size(831, 425);
            this.DtGridView.TabIndex = 0;
            this.DtGridView.Text = "dataGridView1";
            // 
            // identificacion
            // 
            this.identificacion.HeaderText = "identificacion";
            this.identificacion.MinimumWidth = 6;
            this.identificacion.Name = "identificacion";
            this.identificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // numeroTelefono
            // 
            this.numeroTelefono.HeaderText = "numero de telefono";
            this.numeroTelefono.MinimumWidth = 6;
            this.numeroTelefono.Name = "numeroTelefono";
            this.numeroTelefono.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // edad
            // 
            this.edad.HeaderText = "edad";
            this.edad.MinimumWidth = 6;
            this.edad.Name = "edad";
            this.edad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(704, 119);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(94, 29);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Filtro:";
            // 
            // CmbTipoFiltro
            // 
            this.CmbTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoFiltro.FormattingEnabled = true;
            this.CmbTipoFiltro.Items.AddRange(new object[] {
            "Consultar Por ID Cliente",
            "Consultar Todos",
            "Consultar Por Nombre"});
            this.CmbTipoFiltro.Location = new System.Drawing.Point(180, 153);
            this.CmbTipoFiltro.Name = "CmbTipoFiltro";
            this.CmbTipoFiltro.Size = new System.Drawing.Size(518, 28);
            this.CmbTipoFiltro.TabIndex = 1;
            this.CmbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.CmbTipoFiltro_SelectedIndexChanged);
            // 
            // TxtIdConsulta
            // 
            this.TxtIdConsulta.Location = new System.Drawing.Point(180, 120);
            this.TxtIdConsulta.Name = "TxtIdConsulta";
            this.TxtIdConsulta.Size = new System.Drawing.Size(518, 27);
            this.TxtIdConsulta.TabIndex = 0;
            // 
            // FrmVisualizarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelSuperior);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVisualizarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVisualizarClienes";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.TextBox TxtIdConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTipoFiltro;
        private System.Windows.Forms.Panel PanelFiltro;
        private System.Windows.Forms.DataGridView DtGridView;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Button BtnEnviarArchivo;
        private System.Windows.Forms.Button BtnGenerarPdf;
    }
}