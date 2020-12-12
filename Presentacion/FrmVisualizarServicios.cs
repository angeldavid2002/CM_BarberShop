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
    public partial class FrmVisualizarServicios : Form
    {
        private ServicioServices servicioServices;
        private List<Servicio> servicios = new List<Servicio>();
        private Servicio servicio;
        public FrmVisualizarServicios()
        {
            InitializeComponent();
            servicioServices = new ServicioServices(ConfigConnection.connectionString);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMenssage(System.IntPtr hWnh, int wMsg, int wParam, int iParam);
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            DataGridFiltroServicios.Rows.Clear();
            try
            {
                if (ComboTipoFiltro.Text.Equals("Consultar Todos"))
                {
                    if (servicioServices.ConsultarTodos().listaVacia == false)
                    {
                        if (servicioServices.ConsultarTodos().servicios.Count > 0)
                        {
                            servicios = servicioServices.ConsultarTodos().servicios;
                            foreach (var item in servicios)
                            {
                                DataGridFiltroServicios.Rows.Add(item.idServicio, item.nombreServicio, item.descripcionServicio, item.valorServicio);
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
                else if (ComboTipoFiltro.Text.Equals("Consultar Servicio Por Id"))
                {
                    if (ValidarTextBoxVacio(TxtIdConsulta))
                    {
                        if (servicioServices.ConsultarIdentificacion(Convert.ToInt32(TxtIdConsulta.Text)).listaVacia == false)
                        {
                            if (servicioServices.ConsultarIdentificacion(Convert.ToInt32(TxtIdConsulta.Text)).servicio != null)
                            {
                                servicio = servicioServices.ConsultarIdentificacion(Convert.ToInt32(TxtIdConsulta.Text)).servicio;
                                DataGridFiltroServicios.Rows.Add(servicio.idServicio, servicio.nombreServicio, servicio.descripcionServicio,
                                servicio.valorServicio);
                            }
                        }
                        else
                        {
                            MessageBox.Show("no hay elementos", "informacion");
                        }
                    }
                }
                else if (ComboTipoFiltro.Text.Equals("Consultar Por Nombre"))
                {
                    if (ValidarTextBoxVacio(TxtIdConsulta))
                    {
                        if (servicioServices.ConsultarNombre(TxtIdConsulta.Text).listaVacia == false)
                        {
                            servicios = servicioServices.ConsultarNombre(TxtIdConsulta.Text).servicios;
                            foreach (var item in servicios)
                            {
                                DataGridFiltroServicios.Rows.Add(item.idServicio, item.nombreServicio, item.descripcionServicio, item.valorServicio);
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
                    MessageBox.Show("seleccione una opcion", "ERROR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void ComboTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarSeleccion(ComboTipoFiltro.SelectedItem.ToString());
        }
        private void HabilitarSeleccion(string id_filtro)
        {
            if (id_filtro == "Consultar Servicio Por Id")
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
