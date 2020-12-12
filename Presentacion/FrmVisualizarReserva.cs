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
    public partial class FrmVisualizarReserva : Form
    {
        private ReservaService reservaService;
        private List<Reserva> reservas = new List<Reserva>();
        private Reserva reserva;
        private string filename;
        public FrmVisualizarReserva()
        {
            InitializeComponent();
            reservaService = new ReservaService(ConfigConnection.connectionString);
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
        
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CmbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarSeleccion(CmbTipoFiltro.SelectedItem.ToString());
        }
        private void HabilitarSeleccion(string id_filtro)
        {
            if (id_filtro == "Consultar Reserva Por Id")
            {
                TxtIdentificacion.Enabled = true;
            }
            else if (id_filtro == "Consultar Todos")
            {
                TxtIdentificacion.Enabled = false;
            }
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
            DtGridViewReservas.Rows.Clear();
            try
            {
                if (CmbTipoFiltro.Text.Equals("Consultar Todos"))
                {
                    if (reservaService.ConsultarTodos().listaVacia == false)
                    {
                        if (reservaService.ConsultarTodos().reservas.Count > 0)
                        {
                            reservas = reservaService.ConsultarTodos().reservas;
                            foreach (var item in reservas)
                            {
                                DtGridViewReservas.Rows.Add(item.idReserva, item.Barbero.identificacion, item.diaReserva, item.estadoAtendido, item.estadoAtendido,item.valorTotalReserva);
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
                else if (CmbTipoFiltro.Text.Equals("Consultar Por ID Barbero"))
                {
                    if (ValidarTextBoxVacio(TxtIdentificacion))
                    { 
                        /*if (reservaService.ConsultarIdentificacion(TxtIdentificacion.Text).listaVacia == false)
                        {
                            if (TxtIdentificacion.ConsultarIdentificacion(TxtIdentificacion.Text).barbero != null)
                            {
                                reserva = reservaService.ConsultarIdentificacion(TxtIdConsulta.Text).barbero;
                                DtGridBarberosFiltrados.Rows.Add(barbero.nombre, barbero.apellido, barbero.identificacion, barbero.numeroTelefono, barbero.edad, barbero.direccion, barbero.numeroClientesAtendidos);
                            }
                        }
                        else
                        {
                            MessageBox.Show("no hay elementos", "informacion");
                        }*/
                    }
                }
                else if (CmbTipoFiltro.Text.Equals("Consultar Por Nombre"))
                {/*
                    if (ValidarTextBoxVacio(TxtIdConsulta))
                    {
                        if (barberoServices.ConsultarNombre(TxtIdConsulta.Text).listaVacia == false)
                        {
                            barberos = barberoServices.ConsultarNombre(TxtIdConsulta.Text).barberos;
                            foreach (var item in barberos)
                            {
                                DtGridBarberosFiltrados.Rows.Add(item.nombre, item.apellido, item.identificacion, item.numeroTelefono, item.edad, item.direccion, item.numeroClientesAtendidos);
                            }
                        }
                        else
                        {
                            MessageBox.Show("no hay elementos", "informacion");
                        }
                    }*/
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
    }
}
