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
    public partial class Aprobar : Form
    {
        public Aprobar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            Administrador Administrador1 = new Administrador();
            this.Hide();
            Administrador1.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Aprobar_Load(object sender, EventArgs e)
        {
            BotonRegresar.BackColor = Color.FromArgb(255, 236, 149, 58);
            panel1.BackColor = Color.FromArgb(180, 255, 151, 0);
            panel2.BackColor = Color.FromArgb(180, 236, 231, 224);
            panel3.BackColor = Color.FromArgb(180, 236, 231, 224);
            AprogaryH.BackColor = Color.FromArgb(255, 240, 225, 197);
            BotonAprobar.BackColor = Color.FromArgb(255, 161, 119, 65);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Materiales_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
