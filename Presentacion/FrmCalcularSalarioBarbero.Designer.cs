namespace Presentacion
{
    partial class FrmCalcularSalarioBarbero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalcularSalarioBarbero));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelDtGrid = new System.Windows.Forms.Panel();
            this.DtGridSalarioCalculado = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroClientesAtendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCalcularSalario = new System.Windows.Forms.Button();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.PanelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelDtGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridSalarioCalculado)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelDtGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnCalcularSalario);
            this.panel1.Controls.Add(this.TxtIdentificacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 310);
            this.panel1.TabIndex = 1;
            // 
            // PanelDtGrid
            // 
            this.PanelDtGrid.Controls.Add(this.DtGridSalarioCalculado);
            this.PanelDtGrid.Location = new System.Drawing.Point(12, 185);
            this.PanelDtGrid.Name = "PanelDtGrid";
            this.PanelDtGrid.Size = new System.Drawing.Size(876, 113);
            this.PanelDtGrid.TabIndex = 6;
            // 
            // DtGridSalarioCalculado
            // 
            this.DtGridSalarioCalculado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGridSalarioCalculado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridSalarioCalculado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Identificacion,
            this.NumeroClientesAtendidos,
            this.Salario});
            this.DtGridSalarioCalculado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtGridSalarioCalculado.Location = new System.Drawing.Point(0, 0);
            this.DtGridSalarioCalculado.Name = "DtGridSalarioCalculado";
            this.DtGridSalarioCalculado.RowHeadersWidth = 51;
            this.DtGridSalarioCalculado.Size = new System.Drawing.Size(876, 113);
            this.DtGridSalarioCalculado.TabIndex = 5;
            this.DtGridSalarioCalculado.Text = "dataGridView1";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.MinimumWidth = 6;
            this.Identificacion.Name = "Identificacion";
            // 
            // NumeroClientesAtendidos
            // 
            this.NumeroClientesAtendidos.HeaderText = "Numero de clientes atendidos";
            this.NumeroClientesAtendidos.MinimumWidth = 6;
            this.NumeroClientesAtendidos.Name = "NumeroClientesAtendidos";
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.MinimumWidth = 6;
            this.Salario.Name = "Salario";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(207, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduzca la identificacion del barbero para calcular el salario";
            // 
            // BtnCalcularSalario
            // 
            this.BtnCalcularSalario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCalcularSalario.BackColor = System.Drawing.Color.Transparent;
            this.BtnCalcularSalario.FlatAppearance.BorderSize = 0;
            this.BtnCalcularSalario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.BtnCalcularSalario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCalcularSalario.Location = new System.Drawing.Point(643, 73);
            this.BtnCalcularSalario.Name = "BtnCalcularSalario";
            this.BtnCalcularSalario.Size = new System.Drawing.Size(94, 29);
            this.BtnCalcularSalario.TabIndex = 3;
            this.BtnCalcularSalario.Text = "Calcular";
            this.BtnCalcularSalario.UseVisualStyleBackColor = false;
            this.BtnCalcularSalario.Click += new System.EventHandler(this.BtnCalcularSalario_Click);
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtIdentificacion.Location = new System.Drawing.Point(225, 73);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(394, 27);
            this.TxtIdentificacion.TabIndex = 2;
            // 
            // FrmCalcularSalarioBarbero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCalcularSalarioBarbero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCalcularSalarioBarbero";
            this.PanelSuperior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelDtGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGridSalarioCalculado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCalcularSalario;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtGridSalarioCalculado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroClientesAtendidos;
        private System.Windows.Forms.Panel PanelDtGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
    }
}