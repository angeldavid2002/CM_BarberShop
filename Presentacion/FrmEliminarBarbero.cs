using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entidades;
using Logica;
namespace Presentacion
{
    public partial class FrmEliminarBarbero : Form
    {
        BarberoServices barberoServices;
        public FrmEliminarBarbero()
        {
            InitializeComponent();
            barberoServices = new BarberoServices(ConfigConnection.connectionString);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtIdentificacionEliminar.Text)!=true)
                {
                    MessageBox.Show(barberoServices.EliminarBarbero(TxtIdentificacionEliminar.Text),"informacion");
                }
                else
                {
                    MessageBox.Show("el campo esta vacio", "informacion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
