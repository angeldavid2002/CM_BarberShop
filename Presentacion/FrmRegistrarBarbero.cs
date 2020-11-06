using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FrmRegistrarBarbero : Form
    {
        public FrmRegistrarBarbero()
        {
            InitializeComponent();
            EstablecerDiseño();
        }
        private void EstablecerDiseño()
        {
            LabelRespuesta.Visible = false;
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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            LabelRespuesta.Text = "salud por esa vaina no me joda";
            LabelRespuesta.Visible = true;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
