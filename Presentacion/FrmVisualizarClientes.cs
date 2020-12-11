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
        private ClienteService clienteService;
        private List<Cliente> clientes = new List<Cliente>();
        private Cliente cliente;
        private string filename;
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
        public bool ValidarTextBoxVacio(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("no se puede hacer la consulta porque el campo esta vacio");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DtGridView.Rows.Clear();
            try
            {
                if (CmbTipoFiltro.Text.Equals("Consultar Todos"))
                {
                    if (clienteService.ConsultarTodos().listaVacia == false)
                    {
                        if (clienteService.ConsultarTodos().clientes.Count > 0)
                        {
                            clientes = clienteService.ConsultarTodos().clientes;
                            foreach (var item in clientes)
                            {
                                DtGridView.Rows.Add(item.identificacion, item.nombre, item.apellido, item.numeroTelefono, item.edad, item.direccion);
                            }
                        }
                        else
                        {
                            MessageBox.Show("no hay elementos", "informacion");
                        } 
                    }
                    else
                    {
                        MessageBox.Show("no hay elementos", "informacion");
                    }    
                }
                else if (CmbTipoFiltro.Text.Equals("Consultar Por ID Cliente"))
                {
                    if (ValidarTextBoxVacio(TxtIdConsulta))
                    {
                        if (clienteService.ConsultarIdentificacion(TxtIdConsulta.Text).listaVacia==false)
                        {
                            if (clienteService.ConsultarIdentificacion(TxtIdConsulta.Text).cliente!=null)
                            {
                                cliente = clienteService.ConsultarIdentificacion(TxtIdConsulta.Text).cliente;
                                DtGridView.Rows.Add(cliente.identificacion, cliente.nombre, cliente.apellido,
                                cliente.numeroTelefono, cliente.edad, cliente.direccion);
                            }
                        }
                        else
                        {
                            MessageBox.Show("no hay elementos","informacion");
                        }
                    }
                }else if (CmbTipoFiltro.Text.Equals("Consultar Por Nombre"))
                {
                    if (ValidarTextBoxVacio(TxtIdConsulta))
                    {
                        if (clienteService.ConsultarNombre(TxtIdConsulta.Text).listaVacia==false)
                        {
                            clientes = clienteService.ConsultarNombre(TxtIdConsulta.Text).clientes;
                            foreach (var item in clientes)
                            {
                               DtGridView.Rows.Add(item.identificacion, item.nombre, item.apellido, item.numeroTelefono, item.edad, item.direccion);
                            }
                        }
                        else
                        {
                            MessageBox.Show("no hay elementos", "informacion");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("seleccione una opcion","ERROR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: "+ex.Message);
            }
        }

        private void BtnGenerarPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Informe";
            saveFileDialog.InitialDirectory = @"c:/document";
            saveFileDialog.DefaultExt = "pdf";
            filename = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
                if (filename != "" && clientes.Count > 0)
                {
                    string mensaje = clienteService.GenerarPdf(clientes, filename);

                    MessageBox.Show(mensaje, "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se especifico una ruta o No hay datos para generar el reporte", "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnEnviarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog saveFileDialog = new OpenFileDialog();
                saveFileDialog.Title = "Guardar Informe";
                saveFileDialog.InitialDirectory = @"c:/document";
                saveFileDialog.DefaultExt = "pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialog.FileName;
                    if (filename != "")
                    {
                        MessageBox.Show(clienteService.EnviarEmail(filename));
                    }
                    else
                    {
                        MessageBox.Show("No se especifico una ruta para generar el reporte", "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en la aplicacion: "+ex.Message);
            }
        }

        private void CmbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarSeleccion(CmbTipoFiltro.SelectedItem.ToString());
        }
        private void HabilitarSeleccion(string id_filtro)
        {
            if (id_filtro == "Consultar Por ID Cliente")
            {
                TxtIdConsulta.Enabled = true;
            }
            else if (id_filtro == "Consultar Todos")
            {
                TxtIdConsulta.Enabled = false;
            }
            else if (id_filtro == "Consultar Por Nombre")
            {
                TxtIdConsulta.Enabled = true;
            }
        }
    }
}
