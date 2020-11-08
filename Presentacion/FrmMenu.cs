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
        private void AbrirForm(Form form)
        {
            form.TopLevel = false;
            this.PanelPrincipal.Controls.Add(form);
            form.Show();
        }
        private void BtnCalcularSalarioBarbero_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmCalcularSalarioBarbero form = new FrmCalcularSalarioBarbero();
            AbrirForm(form);
        }
        private void BtnRegistrarBarbero_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmRegistrarBarbero form = new FrmRegistrarBarbero();
            AbrirForm(form);
        }

        private void BtnVisualizacionBarberos_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmVisualizacionBarberos form = new FrmVisualizacionBarberos();
            AbrirForm(form);
        }

        private void BtnEliminarBarbero_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmEliminarBarbero form = new FrmEliminarBarbero();
            AbrirForm(form);
        }

        private void BtnVisualizacionClientes_Click(object sender, EventArgs e)
        {
           LimpiarPanel();
            FrmVisualizarClientes form = new FrmVisualizarClientes();
            AbrirForm(form); ;
        }

        private void BtnGestionUsuario_Click(object sender, EventArgs e)
        {
            AlternarPanel(PanelSubMenuGestionUsuario);
        }

        private void BtnCambiarPassword_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmCambiarContraseña form = new FrmCambiarContraseña();
            AbrirForm(form);
        }

        private void PicIconoBarberia_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
        }

        private void BtnModificarBarbero_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmModificarBarbero form = new FrmModificarBarbero();
            AbrirForm(form);
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmModificarCliente form = new FrmModificarCliente();
            AbrirForm(form);
        }

        private void BtnModificarServicio_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmModificarServicio form = new FrmModificarServicio();
            AbrirForm(form);
        }

        private void BtnVisualizarServicio_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmVisualizarServicios form = new FrmVisualizarServicios();
            AbrirForm(form);
        }

        private void BtnRegistrarServicio_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmRegistrarServicio form = new FrmRegistrarServicio();
            AbrirForm(form);
        }

        private void BtnVisualizarReservas_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmVisualizarReserva form = new FrmVisualizarReserva();
            AbrirForm(form);
        }

        private void BtnRegistrarClientes_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmRegistrarCliente form = new FrmRegistrarCliente();
            AbrirForm(form);
        }

        private void BtnRegistrarReserva_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmRegistrarReserva form = new FrmRegistrarReserva();
            AbrirForm(form);
        }

        private void BtnVisualizacionClientes_Click_1(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmVisualizarClientes form = new FrmVisualizarClientes();
            AbrirForm(form);
        }

        private void BtnModificarReserva_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmModificarReserva form = new FrmModificarReserva();
            AbrirForm(form);
        }

        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmEliminarCliente form = new FrmEliminarCliente();
            AbrirForm(form);
        }

        private void BtnEliminarReserva_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmEliminarReserva form = new FrmEliminarReserva();
            AbrirForm(form);
        }

        private void BtnRegistrarReserva_Click_1(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmRegistrarReserva form = new FrmRegistrarReserva();
            AbrirForm(form);
        }
    }
}
