using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Entidades;
using Logica;
namespace Presentacion
{
    public partial class FrmRegistrarServicio : Form
    {
        ServicioServices servicioServices;
        public FrmRegistrarServicio()
        {
            InitializeComponent();
            servicioServices = new ServicioServices(ConfigConnection.connectionString);
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
        public void AsignarIdServicio(Servicio servicio)
        {
            if (servicioServices.ConsultarTodos().servicios.Any())
            {
                servicio.idServicio = servicioServices.ConsultarTodos().servicios.Last().idServicio +1;
            }
            else
            {
                servicio.idServicio = 0;
            }
        }
        public Servicio CrearServicio()
        {
            Servicio servicio = new Servicio();
            AsignarIdServicio(servicio);
            servicio.descripcionServicio = TxtDescripcionServicio.Text;
            servicio.nombreServicio = TxtNombreServicio.Text;
            servicio.valorServicio = Convert.ToDouble(TxtValorServicio.Text);
            return servicio;
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
        public Boolean ListaTextBoxValidar()
        {
            Boolean respuesta;
            if (ValidarCamposVacios(TxtNombreServicio) && ValidarCamposVacios(TxtDescripcionServicio)
                && ValidarCamposVacios(TxtValorServicio))
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public void VaciarTextBox(TextBox textBox)
        {
            textBox.Text = null;
        }
        public void VaciarListaTextBox()
        {
            VaciarTextBox(TxtNombreServicio);
            VaciarTextBox(TxtDescripcionServicio);
            VaciarTextBox(TxtValorServicio);
        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (ListaTextBoxValidar())
            {
                Servicio servicio = CrearServicio();
                try
                {
                    MessageBox.Show(servicioServices.Guardar(servicio));
                    VaciarListaTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
