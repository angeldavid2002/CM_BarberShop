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
    public partial class FrmVisualizarClientes : Form
    {
        ClienteService clienteService;
        public FrmVisualizarClientes()
        {
            clienteService = new ClienteService(ConfigConnection.connectionString);
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if(CmbTipoFiltro.Text.Equals("Consultar Todos"))
            {
                List<Cliente> clientes = clienteService.ConsultarTodos().clientes;
                foreach (var item in clientes)
                {
                    DtGridView.Rows.Add(item.identificacion,item.nombre,item.apellido,item.numeroTelefono,item.edad,item.direccion);
                }
            }
        }
    }
}
