﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADINHE
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            Administrador Administrador1 = new Administrador();
            this.Hide();
            Administrador1.Show();
        }

        private void BotonRegis_Click(object sender, EventArgs e)
        {

            if (UsuarioDal.CrearCuentas(txtUsuario.Text, txtContraseña.Text, comboBox1.Text) > 0)
            {
                MessageBox.Show("Cuenta Creada con exito");
            }
            else
                MessageBox.Show("No se pudo crear la cuenta");
        }

    }
        }

