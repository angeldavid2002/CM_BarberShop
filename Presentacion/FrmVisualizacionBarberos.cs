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
    public partial class FrmVisualizacionBarberos : Form
    {
        public FrmVisualizacionBarberos()
        {
            InitializeComponent();
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
            if(CmbTipoFiltro.SelectedItem.ToString()!=null)
            {
                string id_filtro = CmbTipoFiltro.SelectedItem.ToString();
                HabilitarSeleccion(id_filtro);
            }
            else
            {

            }
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
