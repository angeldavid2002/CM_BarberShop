using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Logica;
namespace Presentacion
{
    public partial class FrmEliminarCliente : Form
    {
        private readonly ClienteService clienteService;
        public FrmEliminarCliente()
        {
            clienteService = new ClienteService(ConfigConnection.connectionString);
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
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
        public Boolean ValidarCamposVacios(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("el campo: " + textBox.Name + " no puede estar vacio");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios(TxtIdentificacion))
            {
                MessageBox.Show(clienteService.EliminarCliente(TxtIdentificacion.Text));
            }
        }
    }
}
