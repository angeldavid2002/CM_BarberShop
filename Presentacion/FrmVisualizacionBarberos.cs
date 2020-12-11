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
    public partial class FrmVisualizacionBarberos : Form
    {
        private BarberoServices barberoServices;
        private List<Barbero> barberos = new List<Barbero>();
        private Barbero barbero;
        private string filename;
        public FrmVisualizacionBarberos()
        {
            InitializeComponent();
            barberoServices = new BarberoServices(ConfigConnection.connectionString);
            EstablecerDiseño();
        }
        private void EstablecerDiseño()
        {
            TxtIdConsulta.Enabled = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMenssage(System.IntPtr hWnh, int wMsg, int wParam, int iParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMenssage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CmbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarSeleccion(CmbTipoFiltro.SelectedItem.ToString());
        }
        private void HabilitarSeleccion(string id_filtro)
        {
            if (id_filtro== "Consultar Por ID Barbero")
            {
                TxtIdConsulta.Enabled = true;
            }else if (id_filtro=="Consultar Todos")
            {
                TxtIdConsulta.Enabled = false;
            }else if (id_filtro=="Consultar Por Nombre")
            {
                TxtIdConsulta.Enabled = true;
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
            DtGridBarberosFiltrados.Rows.Clear();
            try
            {
                if (CmbTipoFiltro.Text.Equals("Consultar Todos"))
                {
                    if (barberoServices.ConsultarTodos().listaVacia == false)
                    {
                        if (barberoServices.ConsultarTodos().barberos.Count > 0)
                        {
                            barberos = barberoServices.ConsultarTodos().barberos;
                            foreach (var item in barberos)
                            {
                                DtGridBarberosFiltrados.Rows.Add(item.nombre, item.apellido, item.identificacion, item.numeroTelefono, item.edad, item.direccion,item.numeroClientesAtendidos);
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
                    if (ValidarTextBoxVacio(TxtIdConsulta))
                    {
                        if (barberoServices.ConsultarIdentificacion(TxtIdConsulta.Text).listaVacia == false)
                        {
                            if (barberoServices.ConsultarIdentificacion(TxtIdConsulta.Text).barbero!=null)
                            {
                                barbero = barberoServices.ConsultarIdentificacion(TxtIdConsulta.Text).barbero;
                                DtGridBarberosFiltrados.Rows.Add(barbero.nombre, barbero.apellido, barbero.identificacion, barbero.numeroTelefono, barbero.edad, barbero.direccion, barbero.numeroClientesAtendidos);
                            }
                        }
                        else
                        {
                            MessageBox.Show("no hay elementos", "informacion");
                        }
                    }
                }
                else if (CmbTipoFiltro.Text.Equals("Consultar Por Nombre"))
                {
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
    }
}
