using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Logica;
namespace Presentacion
{
    public partial class FrmRegistrarCliente : Form
    {
        ClienteService clienteService;
        public FrmRegistrarCliente()
        {
            InitializeComponent();
            clienteService = new ClienteService(ConfigConnection.connectionString);
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
        public Cliente CrearCliente()
        {
            Cliente cliente= new Cliente();
            cliente.nombre = TxtNombre.Text;
            cliente.apellido = TxtApellido.Text;
            cliente.identificacion = TxtIdentificacion.Text;
            cliente.edad = Convert.ToInt32(TxtEdad.Text);
            cliente.direccion =  TxtDireccion.Text;
            return cliente;
        }
        public Boolean ValidarCamposVacios(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("el campo: "+textBox.Name+" no puede estar vacio");
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean ListaTextBoxValidar()
        {
            Boolean respuesta;
            if (ValidarCamposVacios(TxtNombre) && ValidarCamposVacios(TxtApellido) 
                && ValidarCamposVacios(TxtIdentificacion) && ValidarCamposVacios(TxtEdad) 
                && ValidarCamposVacios(TxtDireccion) && ValidarCamposVacios(TxtTelefono))
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clienteService.ServerVersion());
        }
    }
}
