using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            EstablecerDiseño();
        }
        private void EstablecerDiseño()
        {
            PanelSubMenuBarberos.Visible = false;
            PanelSubMenuCliente.Visible = false;
            PanelSubMenuGestionUsuario.Visible = false;
        }
        private void LimpiarPanel()
        {
            if (this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
            }
        }
        private void AlternarPanel(Panel panel)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
        }
        private void OcultarPanel(Panel panel)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
        }
        private void EsconderMenu()
        {
            OcultarPanel(PanelSubMenuBarberos);
            OcultarPanel(PanelSubMenuCliente);
            OcultarPanel(PanelSubMenuGestionUsuario);
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMenssage(System.IntPtr hWnh, int wMsg, int wParam, int iParam);

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMenssage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnAdministrarBarberos_Click(object sender, EventArgs e)
        {
            AlternarPanel(PanelSubMenuBarberos);
        }

        private void BtnAdministrarClientes_Click(object sender, EventArgs e)
        {
            AlternarPanel(PanelSubMenuCliente);
        }

        private void BtnCalcularSalarioBarbero_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmCalcularSalarioBarbero form = new FrmCalcularSalarioBarbero();
            form.TopLevel = false;
            this.PanelPrincipal.Controls.Add(form);
            form.Show();
        }
        private void BtnRegistrarBarbero_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmRegistrarBarbero form = new FrmRegistrarBarbero();
            form.TopLevel = false;
            this.PanelPrincipal.Controls.Add(form);
            this.PanelPrincipal.Tag = form;
            form.Show();
        }

        private void BtnVisualizacionBarberos_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmVisualizacionBarberos form = new FrmVisualizacionBarberos();
            form.TopLevel = false;
            this.PanelPrincipal.Controls.Add(form);
            this.PanelPrincipal.Tag = form;
            form.Show();
        }

        private void BtnEliminarBarbero_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmEliminarBarbero form = new FrmEliminarBarbero();
            form.TopLevel = false;
            this.PanelPrincipal.Controls.Add(form);
            this.PanelPrincipal.Tag = form;
            form.Show();
        }

        private void BtnVisualizacionClientes_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmVisualizarClientes form = new FrmVisualizarClientes();
            form.TopLevel = false;
            this.PanelPrincipal.Controls.Add(form);
            this.PanelPrincipal.Tag = form;
            form.Show();
        }

        private void BtnGestionReservaCliente_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmGestionReservaCliente form = new FrmGestionReservaCliente();
            form.TopLevel = false;
            this.PanelPrincipal.Controls.Add(form);
            this.PanelPrincipal.Tag = form;
            form.Show();
        }

        private void BtnGestionUsuario_Click(object sender, EventArgs e)
        {
            AlternarPanel(PanelSubMenuGestionUsuario);
        }

        private void BtnCambiarPassword_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmCambiarContraseña form = new FrmCambiarContraseña();
            form.TopLevel = false;
            this.PanelPrincipal.Controls.Add(form);
            this.PanelPrincipal.Tag = form;
            form.Show();
        }

        private void PicIconoBarberia_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
        }

        private void BtnGestionCliente_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmGestionCliente form = new FrmGestionCliente();
            form.TopLevel = false;
            this.PanelPrincipal.Controls.Add(form);
            this.PanelPrincipal.Tag = form;
            form.Show();
        }

        private void BtnRegistrarServicio_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmRegistrarServicio form = new FrmRegistrarServicio();
            form.TopLevel = false;
            this.PanelPrincipal.Controls.Add(form);
            this.PanelPrincipal.Tag = form;
            form.Show();
        }
    }
}
