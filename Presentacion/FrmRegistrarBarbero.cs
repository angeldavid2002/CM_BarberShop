﻿using System;
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
    public partial class FrmRegistrarBarbero : Form
    {
        BarberoServices barberoServices;
        public FrmRegistrarBarbero()
        {
            InitializeComponent();
            barberoServices = new BarberoServices(ConfigConnection.connectionString);
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
            if (ListaTextBoxValidar())
            {
                MessageBox.Show(barberoServices.Guardar(CrearBarbero()));
                VaciarListaTextBox();
            }
        }
        public void VaciarTextBox(TextBox textBox)
        {
            textBox.Text = null;
        }
        public void VaciarListaTextBox()
        {
            VaciarTextBox(TxtApellido);
            VaciarTextBox(TxtNombre);
            VaciarTextBox(TxtDireccion);
            VaciarTextBox(TxtEdad);
            VaciarTextBox(TxtIdentificacion);
            VaciarTextBox(TxtTelefono);
        }
        public Barbero CrearBarbero()
        {
            Barbero barbero = new Barbero();
            barbero.nombre = TxtNombre.Text;
            barbero.apellido = TxtApellido.Text;
            barbero.identificacion = TxtIdentificacion.Text;
            barbero.edad = Convert.ToInt32(TxtEdad.Text);
            barbero.direccion = TxtDireccion.Text;
            barbero.numeroTelefono = TxtTelefono.Text;
            return barbero;
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
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
