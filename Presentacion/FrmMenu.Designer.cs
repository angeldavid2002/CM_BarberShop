namespace Presentacion
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.BtnRestaurar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.PanelSubMenuGestionUsuario = new System.Windows.Forms.Panel();
            this.BtnVisualizarServicio = new System.Windows.Forms.Button();
            this.BtnModificarServicio = new System.Windows.Forms.Button();
            this.BtnRegistrarServicio = new System.Windows.Forms.Button();
            this.BtnCambiarPassword = new System.Windows.Forms.Button();
            this.BtnGestionUsuario = new System.Windows.Forms.Button();
            this.PanelSubMenuCliente = new System.Windows.Forms.Panel();
            this.BtnModificarCliente = new System.Windows.Forms.Button();
            this.BtnGestionReservaCliente = new System.Windows.Forms.Button();
            this.BtnGestionCliente = new System.Windows.Forms.Button();
            this.BtnVisualizacionClientes = new System.Windows.Forms.Button();
            this.BtnAdministrarClientes = new System.Windows.Forms.Button();
            this.PanelSubMenuBarberos = new System.Windows.Forms.Panel();
            this.BtnModificarBarbero = new System.Windows.Forms.Button();
            this.BtnEliminarBarbero = new System.Windows.Forms.Button();
            this.BtnRegistrarBarbero = new System.Windows.Forms.Button();
            this.BtnVisualizacionBarberos = new System.Windows.Forms.Button();
            this.BtnCalcularSalarioBarbero = new System.Windows.Forms.Button();
            this.BtnAdministrarBarberos = new System.Windows.Forms.Button();
            this.SubPanelIzquierdoSuperior = new System.Windows.Forms.Panel();
            this.PicIconoBarberia = new System.Windows.Forms.PictureBox();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelSuperior.SuspendLayout();
            this.PanelIzquierdo.SuspendLayout();
            this.PanelSubMenuGestionUsuario.SuspendLayout();
            this.PanelSubMenuCliente.SuspendLayout();
            this.PanelSubMenuBarberos.SuspendLayout();
            this.SubPanelIzquierdoSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoBarberia)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.Black;
            this.PanelSuperior.Controls.Add(this.BtnMaximizar);
            this.PanelSuperior.Controls.Add(this.BtnRestaurar);
            this.PanelSuperior.Controls.Add(this.BtnCerrar);
            this.PanelSuperior.Controls.Add(this.BtnMinimizar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(1200, 50);
            this.PanelSuperior.TabIndex = 1;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(1100, 0);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(50, 50);
            this.BtnMaximizar.TabIndex = 2;
            this.BtnMaximizar.UseVisualStyleBackColor = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnRestaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRestaurar.FlatAppearance.BorderSize = 0;
            this.BtnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestaurar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(1100, 0);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(50, 50);
            this.BtnRestaurar.TabIndex = 4;
            this.BtnRestaurar.UseVisualStyleBackColor = false;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1150, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(50, 50);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(1050, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(50, 50);
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.AutoScroll = true;
            this.PanelIzquierdo.BackColor = System.Drawing.Color.Black;
            this.PanelIzquierdo.Controls.Add(this.PanelSubMenuGestionUsuario);
            this.PanelIzquierdo.Controls.Add(this.BtnGestionUsuario);
            this.PanelIzquierdo.Controls.Add(this.PanelSubMenuCliente);
            this.PanelIzquierdo.Controls.Add(this.BtnAdministrarClientes);
            this.PanelIzquierdo.Controls.Add(this.PanelSubMenuBarberos);
            this.PanelIzquierdo.Controls.Add(this.BtnAdministrarBarberos);
            this.PanelIzquierdo.Controls.Add(this.SubPanelIzquierdoSuperior);
            this.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 50);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(230, 950);
            this.PanelIzquierdo.TabIndex = 0;
            // 
            // PanelSubMenuGestionUsuario
            // 
            this.PanelSubMenuGestionUsuario.Controls.Add(this.BtnVisualizarServicio);
            this.PanelSubMenuGestionUsuario.Controls.Add(this.BtnModificarServicio);
            this.PanelSubMenuGestionUsuario.Controls.Add(this.BtnRegistrarServicio);
            this.PanelSubMenuGestionUsuario.Controls.Add(this.BtnCambiarPassword);
            this.PanelSubMenuGestionUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuGestionUsuario.Location = new System.Drawing.Point(0, 554);
            this.PanelSubMenuGestionUsuario.Name = "PanelSubMenuGestionUsuario";
            this.PanelSubMenuGestionUsuario.Size = new System.Drawing.Size(230, 185);
            this.PanelSubMenuGestionUsuario.TabIndex = 6;
            // 
            // BtnVisualizarServicio
            // 
            this.BtnVisualizarServicio.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnVisualizarServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVisualizarServicio.FlatAppearance.BorderSize = 0;
            this.BtnVisualizarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnVisualizarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisualizarServicio.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVisualizarServicio.Location = new System.Drawing.Point(0, 90);
            this.BtnVisualizarServicio.Name = "BtnVisualizarServicio";
            this.BtnVisualizarServicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnVisualizarServicio.Size = new System.Drawing.Size(230, 30);
            this.BtnVisualizarServicio.TabIndex = 0;
            this.BtnVisualizarServicio.Text = "Visualizar Servicios";
            this.BtnVisualizarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVisualizarServicio.UseVisualStyleBackColor = false;
            this.BtnVisualizarServicio.Click += new System.EventHandler(this.BtnVisualizarServicio_Click);
            // 
            // BtnModificarServicio
            // 
            this.BtnModificarServicio.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnModificarServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnModificarServicio.FlatAppearance.BorderSize = 0;
            this.BtnModificarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnModificarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarServicio.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnModificarServicio.Location = new System.Drawing.Point(0, 60);
            this.BtnModificarServicio.Name = "BtnModificarServicio";
            this.BtnModificarServicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnModificarServicio.Size = new System.Drawing.Size(230, 30);
            this.BtnModificarServicio.TabIndex = 0;
            this.BtnModificarServicio.Text = "Modificar Servicios";
            this.BtnModificarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarServicio.UseVisualStyleBackColor = false;
            this.BtnModificarServicio.Click += new System.EventHandler(this.BtnModificarServicio_Click);
            // 
            // BtnRegistrarServicio
            // 
            this.BtnRegistrarServicio.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRegistrarServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRegistrarServicio.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnRegistrarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarServicio.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRegistrarServicio.Location = new System.Drawing.Point(0, 30);
            this.BtnRegistrarServicio.Name = "BtnRegistrarServicio";
            this.BtnRegistrarServicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRegistrarServicio.Size = new System.Drawing.Size(230, 30);
            this.BtnRegistrarServicio.TabIndex = 0;
            this.BtnRegistrarServicio.Text = "Registrar Nuevos Servicios";
            this.BtnRegistrarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarServicio.UseVisualStyleBackColor = false;
            this.BtnRegistrarServicio.Click += new System.EventHandler(this.BtnRegistrarServicio_Click);
            // 
            // BtnCambiarPassword
            // 
            this.BtnCambiarPassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCambiarPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCambiarPassword.FlatAppearance.BorderSize = 0;
            this.BtnCambiarPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCambiarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiarPassword.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCambiarPassword.Location = new System.Drawing.Point(0, 0);
            this.BtnCambiarPassword.Name = "BtnCambiarPassword";
            this.BtnCambiarPassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCambiarPassword.Size = new System.Drawing.Size(230, 30);
            this.BtnCambiarPassword.TabIndex = 0;
            this.BtnCambiarPassword.Text = "Cambiar contraseña";
            this.BtnCambiarPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCambiarPassword.UseVisualStyleBackColor = false;
            this.BtnCambiarPassword.Click += new System.EventHandler(this.BtnCambiarPassword_Click);
            // 
            // BtnGestionUsuario
            // 
            this.BtnGestionUsuario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGestionUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGestionUsuario.FlatAppearance.BorderSize = 0;
            this.BtnGestionUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnGestionUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.BtnGestionUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionUsuario.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGestionUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGestionUsuario.Location = new System.Drawing.Point(0, 524);
            this.BtnGestionUsuario.Name = "BtnGestionUsuario";
            this.BtnGestionUsuario.Size = new System.Drawing.Size(230, 30);
            this.BtnGestionUsuario.TabIndex = 3;
            this.BtnGestionUsuario.Text = "Gestion de usuario";
            this.BtnGestionUsuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnGestionUsuario.UseVisualStyleBackColor = false;
            this.BtnGestionUsuario.Click += new System.EventHandler(this.BtnGestionUsuario_Click);
            // 
            // PanelSubMenuCliente
            // 
            this.PanelSubMenuCliente.AutoSize = true;
            this.PanelSubMenuCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelSubMenuCliente.Controls.Add(this.BtnModificarCliente);
            this.PanelSubMenuCliente.Controls.Add(this.BtnGestionReservaCliente);
            this.PanelSubMenuCliente.Controls.Add(this.BtnGestionCliente);
            this.PanelSubMenuCliente.Controls.Add(this.BtnVisualizacionClientes);
            this.PanelSubMenuCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuCliente.Location = new System.Drawing.Point(0, 404);
            this.PanelSubMenuCliente.Name = "PanelSubMenuCliente";
            this.PanelSubMenuCliente.Size = new System.Drawing.Size(230, 120);
            this.PanelSubMenuCliente.TabIndex = 5;
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnModificarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnModificarCliente.FlatAppearance.BorderSize = 0;
            this.BtnModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarCliente.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnModificarCliente.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnModificarCliente.Location = new System.Drawing.Point(0, 90);
            this.BtnModificarCliente.Name = "BtnModificarCliente";
            this.BtnModificarCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnModificarCliente.Size = new System.Drawing.Size(230, 30);
            this.BtnModificarCliente.TabIndex = 0;
            this.BtnModificarCliente.Text = "Modificar Cliente";
            this.BtnModificarCliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnModificarCliente.UseVisualStyleBackColor = false;
            this.BtnModificarCliente.Click += new System.EventHandler(this.BtnModificarCliente_Click);
            // 
            // BtnGestionReservaCliente
            // 
            this.BtnGestionReservaCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnGestionReservaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGestionReservaCliente.FlatAppearance.BorderSize = 0;
            this.BtnGestionReservaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnGestionReservaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionReservaCliente.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGestionReservaCliente.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnGestionReservaCliente.Location = new System.Drawing.Point(0, 60);
            this.BtnGestionReservaCliente.Name = "BtnGestionReservaCliente";
            this.BtnGestionReservaCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnGestionReservaCliente.Size = new System.Drawing.Size(230, 30);
            this.BtnGestionReservaCliente.TabIndex = 0;
            this.BtnGestionReservaCliente.Text = "Gestionar reservas";
            this.BtnGestionReservaCliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnGestionReservaCliente.UseVisualStyleBackColor = false;
            this.BtnGestionReservaCliente.Click += new System.EventHandler(this.BtnGestionReservaCliente_Click);
            // 
            // BtnGestionCliente
            // 
            this.BtnGestionCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnGestionCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGestionCliente.FlatAppearance.BorderSize = 0;
            this.BtnGestionCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnGestionCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionCliente.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGestionCliente.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnGestionCliente.Location = new System.Drawing.Point(0, 30);
            this.BtnGestionCliente.Name = "BtnGestionCliente";
            this.BtnGestionCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnGestionCliente.Size = new System.Drawing.Size(230, 30);
            this.BtnGestionCliente.TabIndex = 0;
            this.BtnGestionCliente.Text = "Gestion de clientes";
            this.BtnGestionCliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnGestionCliente.UseVisualStyleBackColor = false;
            this.BtnGestionCliente.Click += new System.EventHandler(this.BtnGestionCliente_Click);
            // 
            // BtnVisualizacionClientes
            // 
            this.BtnVisualizacionClientes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnVisualizacionClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVisualizacionClientes.FlatAppearance.BorderSize = 0;
            this.BtnVisualizacionClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnVisualizacionClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisualizacionClientes.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVisualizacionClientes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnVisualizacionClientes.Location = new System.Drawing.Point(0, 0);
            this.BtnVisualizacionClientes.Name = "BtnVisualizacionClientes";
            this.BtnVisualizacionClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnVisualizacionClientes.Size = new System.Drawing.Size(230, 30);
            this.BtnVisualizacionClientes.TabIndex = 0;
            this.BtnVisualizacionClientes.Text = "Visualizacion de clientes";
            this.BtnVisualizacionClientes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnVisualizacionClientes.UseVisualStyleBackColor = false;
            this.BtnVisualizacionClientes.Click += new System.EventHandler(this.BtnVisualizacionClientes_Click);
            // 
            // BtnAdministrarClientes
            // 
            this.BtnAdministrarClientes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAdministrarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdministrarClientes.FlatAppearance.BorderSize = 0;
            this.BtnAdministrarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAdministrarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.BtnAdministrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministrarClientes.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdministrarClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdministrarClientes.Location = new System.Drawing.Point(0, 374);
            this.BtnAdministrarClientes.Name = "BtnAdministrarClientes";
            this.BtnAdministrarClientes.Size = new System.Drawing.Size(230, 30);
            this.BtnAdministrarClientes.TabIndex = 3;
            this.BtnAdministrarClientes.Text = "Administrar Clientes";
            this.BtnAdministrarClientes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnAdministrarClientes.UseVisualStyleBackColor = false;
            this.BtnAdministrarClientes.Click += new System.EventHandler(this.BtnAdministrarClientes_Click);
            // 
            // PanelSubMenuBarberos
            // 
            this.PanelSubMenuBarberos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelSubMenuBarberos.Controls.Add(this.BtnModificarBarbero);
            this.PanelSubMenuBarberos.Controls.Add(this.BtnEliminarBarbero);
            this.PanelSubMenuBarberos.Controls.Add(this.BtnRegistrarBarbero);
            this.PanelSubMenuBarberos.Controls.Add(this.BtnVisualizacionBarberos);
            this.PanelSubMenuBarberos.Controls.Add(this.BtnCalcularSalarioBarbero);
            this.PanelSubMenuBarberos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuBarberos.Location = new System.Drawing.Point(0, 230);
            this.PanelSubMenuBarberos.Name = "PanelSubMenuBarberos";
            this.PanelSubMenuBarberos.Size = new System.Drawing.Size(230, 144);
            this.PanelSubMenuBarberos.TabIndex = 4;
            // 
            // BtnModificarBarbero
            // 
            this.BtnModificarBarbero.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnModificarBarbero.FlatAppearance.BorderSize = 0;
            this.BtnModificarBarbero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnModificarBarbero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarBarbero.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnModificarBarbero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnModificarBarbero.Location = new System.Drawing.Point(0, 87);
            this.BtnModificarBarbero.Name = "BtnModificarBarbero";
            this.BtnModificarBarbero.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnModificarBarbero.Size = new System.Drawing.Size(230, 30);
            this.BtnModificarBarbero.TabIndex = 3;
            this.BtnModificarBarbero.Text = "Modificar Barbero";
            this.BtnModificarBarbero.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnModificarBarbero.UseVisualStyleBackColor = false;
            this.BtnModificarBarbero.Click += new System.EventHandler(this.BtnModificarBarbero_Click);
            // 
            // BtnEliminarBarbero
            // 
            this.BtnEliminarBarbero.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnEliminarBarbero.FlatAppearance.BorderSize = 0;
            this.BtnEliminarBarbero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEliminarBarbero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarBarbero.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminarBarbero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminarBarbero.Location = new System.Drawing.Point(0, 57);
            this.BtnEliminarBarbero.Name = "BtnEliminarBarbero";
            this.BtnEliminarBarbero.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnEliminarBarbero.Size = new System.Drawing.Size(230, 30);
            this.BtnEliminarBarbero.TabIndex = 3;
            this.BtnEliminarBarbero.Text = "Eliminar Barbero";
            this.BtnEliminarBarbero.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnEliminarBarbero.UseVisualStyleBackColor = false;
            this.BtnEliminarBarbero.Click += new System.EventHandler(this.BtnEliminarBarbero_Click);
            // 
            // BtnRegistrarBarbero
            // 
            this.BtnRegistrarBarbero.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRegistrarBarbero.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarBarbero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnRegistrarBarbero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarBarbero.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRegistrarBarbero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegistrarBarbero.Location = new System.Drawing.Point(0, 0);
            this.BtnRegistrarBarbero.Name = "BtnRegistrarBarbero";
            this.BtnRegistrarBarbero.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnRegistrarBarbero.Size = new System.Drawing.Size(230, 30);
            this.BtnRegistrarBarbero.TabIndex = 2;
            this.BtnRegistrarBarbero.Text = "Registrar Barbero";
            this.BtnRegistrarBarbero.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnRegistrarBarbero.UseVisualStyleBackColor = false;
            this.BtnRegistrarBarbero.Click += new System.EventHandler(this.BtnRegistrarBarbero_Click);
            // 
            // BtnVisualizacionBarberos
            // 
            this.BtnVisualizacionBarberos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnVisualizacionBarberos.FlatAppearance.BorderSize = 0;
            this.BtnVisualizacionBarberos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnVisualizacionBarberos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisualizacionBarberos.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVisualizacionBarberos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnVisualizacionBarberos.Location = new System.Drawing.Point(0, 27);
            this.BtnVisualizacionBarberos.Name = "BtnVisualizacionBarberos";
            this.BtnVisualizacionBarberos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnVisualizacionBarberos.Size = new System.Drawing.Size(230, 30);
            this.BtnVisualizacionBarberos.TabIndex = 1;
            this.BtnVisualizacionBarberos.Text = "Visualizacion de barberos";
            this.BtnVisualizacionBarberos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnVisualizacionBarberos.UseVisualStyleBackColor = false;
            this.BtnVisualizacionBarberos.Click += new System.EventHandler(this.BtnVisualizacionBarberos_Click);
            // 
            // BtnCalcularSalarioBarbero
            // 
            this.BtnCalcularSalarioBarbero.AutoSize = true;
            this.BtnCalcularSalarioBarbero.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCalcularSalarioBarbero.FlatAppearance.BorderSize = 0;
            this.BtnCalcularSalarioBarbero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCalcularSalarioBarbero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcularSalarioBarbero.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCalcularSalarioBarbero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCalcularSalarioBarbero.Location = new System.Drawing.Point(0, 117);
            this.BtnCalcularSalarioBarbero.Name = "BtnCalcularSalarioBarbero";
            this.BtnCalcularSalarioBarbero.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnCalcularSalarioBarbero.Size = new System.Drawing.Size(230, 30);
            this.BtnCalcularSalarioBarbero.TabIndex = 0;
            this.BtnCalcularSalarioBarbero.Text = "calcular salario barbero";
            this.BtnCalcularSalarioBarbero.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnCalcularSalarioBarbero.UseVisualStyleBackColor = false;
            this.BtnCalcularSalarioBarbero.Click += new System.EventHandler(this.BtnCalcularSalarioBarbero_Click);
            // 
            // BtnAdministrarBarberos
            // 
            this.BtnAdministrarBarberos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAdministrarBarberos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdministrarBarberos.FlatAppearance.BorderSize = 0;
            this.BtnAdministrarBarberos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAdministrarBarberos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.BtnAdministrarBarberos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministrarBarberos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdministrarBarberos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdministrarBarberos.Location = new System.Drawing.Point(0, 200);
            this.BtnAdministrarBarberos.Name = "BtnAdministrarBarberos";
            this.BtnAdministrarBarberos.Size = new System.Drawing.Size(230, 30);
            this.BtnAdministrarBarberos.TabIndex = 3;
            this.BtnAdministrarBarberos.Text = "Administrar Barberos";
            this.BtnAdministrarBarberos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnAdministrarBarberos.UseVisualStyleBackColor = false;
            this.BtnAdministrarBarberos.Click += new System.EventHandler(this.BtnAdministrarBarberos_Click);
            // 
            // SubPanelIzquierdoSuperior
            // 
            this.SubPanelIzquierdoSuperior.Controls.Add(this.PicIconoBarberia);
            this.SubPanelIzquierdoSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelIzquierdoSuperior.Location = new System.Drawing.Point(0, 0);
            this.SubPanelIzquierdoSuperior.Name = "SubPanelIzquierdoSuperior";
            this.SubPanelIzquierdoSuperior.Size = new System.Drawing.Size(230, 200);
            this.SubPanelIzquierdoSuperior.TabIndex = 2;
            // 
            // PicIconoBarberia
            // 
            this.PicIconoBarberia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicIconoBarberia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicIconoBarberia.Image = ((System.Drawing.Image)(resources.GetObject("PicIconoBarberia.Image")));
            this.PicIconoBarberia.Location = new System.Drawing.Point(0, 0);
            this.PicIconoBarberia.Name = "PicIconoBarberia";
            this.PicIconoBarberia.Size = new System.Drawing.Size(230, 200);
            this.PicIconoBarberia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicIconoBarberia.TabIndex = 0;
            this.PicIconoBarberia.TabStop = false;
            this.PicIconoBarberia.Click += new System.EventHandler(this.PicIconoBarberia_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.AutoScroll = true;
            this.PanelPrincipal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(230, 50);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(970, 950);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 1000);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelIzquierdo);
            this.Controls.Add(this.PanelSuperior);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelSuperior.ResumeLayout(false);
            this.PanelIzquierdo.ResumeLayout(false);
            this.PanelIzquierdo.PerformLayout();
            this.PanelSubMenuGestionUsuario.ResumeLayout(false);
            this.PanelSubMenuCliente.ResumeLayout(false);
            this.PanelSubMenuBarberos.ResumeLayout(false);
            this.PanelSubMenuBarberos.PerformLayout();
            this.SubPanelIzquierdoSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoBarberia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.Panel SubPanelIzquierdoSuperior;
        private System.Windows.Forms.Panel PanelSubMenuBarberos;
        private System.Windows.Forms.Button BtnAdministrarBarberos;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button BtnRestaurar;
        private System.Windows.Forms.Button BtnMaximizar;
        private System.Windows.Forms.Button BtnEliminarBarbero;
        private System.Windows.Forms.Button BtnRegistrarBarbero;
        private System.Windows.Forms.Button BtnVisualizacionBarberos;
        private System.Windows.Forms.Button BtnCalcularSalarioBarbero;
        private System.Windows.Forms.Panel PanelSubMenuCliente;
        private System.Windows.Forms.Button BtnVisualizacionClientes;
        private System.Windows.Forms.Button BtnAdministrarClientes;
        private System.Windows.Forms.PictureBox PicIconoBarberia;
        private System.Windows.Forms.Button BtnGestionUsuario;
        private System.Windows.Forms.Button BtnGestionReservaCliente;
        private System.Windows.Forms.Button BtnGestionCliente;
        private System.Windows.Forms.Panel PanelSubMenuGestionUsuario;
        private System.Windows.Forms.Button BtnCambiarPassword;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button BtnRegistrarServicio;
        private System.Windows.Forms.Button BtnModificarBarbero;
        private System.Windows.Forms.Button BtnModificarCliente;
        private System.Windows.Forms.Button BtnModificarServicio;
        private System.Windows.Forms.Button BtnVisualizarServicio;
    }
}