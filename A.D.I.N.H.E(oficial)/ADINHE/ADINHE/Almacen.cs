using System;
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
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }

        private void BotonCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            Administrador Administrador1 = new Administrador();
            this.Hide();
            Administrador1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            BotonRegresar.BackColor = Color.FromArgb(255, 236, 149, 58);
            panel1.BackColor = Color.FromArgb(180, 255, 151, 0);
            panel2.BackColor = Color.FromArgb(180, 236, 231, 224);
            panel3.BackColor = Color.FromArgb(180, 236, 231, 224);
            tabPage1.BackColor = Color.FromArgb(255, 240, 225, 197);
            tabPage2.BackColor = Color.FromArgb(255, 240, 225, 197);
            tabPage3.BackColor = Color.FromArgb(255, 240, 225, 197);
            tabPage4.BackColor = Color.FromArgb(255, 240, 225, 197);
            AgregarMaterial.BackColor = Color.FromArgb(255, 161, 119, 65);
            BotonEntregado.BackColor = Color.FromArgb(255, 161, 119, 65);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarMaterial_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotonEntregado_Click(object sender, EventArgs e)
        {

        }
    }
}
