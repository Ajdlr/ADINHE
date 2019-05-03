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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotonHerramientas_Click(object sender, EventArgs e)
        {
            Herramientas Herramientas1 = new Herramientas();
            this.Hide();
            Herramientas1.Show();
        }

        private void BotonAprobar_Click(object sender, EventArgs e)
        {
            Aprobar Aprobar1 = new Aprobar();
            this.Hide();
            Aprobar1.Show();
        }

        private void BotonComprar_Click(object sender, EventArgs e)
        {
            Comprar Comprar1 = new Comprar();
            this.Hide();
            Comprar1.Show();
        }

        private void BotonMaterial_Click(object sender, EventArgs e)
        {
            Material Material1 = new Material();
            this.Hide();
            Material1.Show();
        }

        private void BotonHerramienta_Click(object sender, EventArgs e)
        {
            Herramienta Herramienta1 = new Herramienta();
            this.Hide();
            Herramienta1.Show();
        }

        private void BotonAlmacen_Click(object sender, EventArgs e)
        {
            Almacen Almacen1 = new Almacen();
                this.Hide();
            Almacen1.Show();
        }


        private void BotonCerrarSesion_Click(object sender, EventArgs e)
        {
            Login Login1 = new Login();
            this.Hide();
            Login1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            BotonCerrarSesion.BackColor = Color.FromArgb(255, 236, 149, 58);
            panel1.BackColor = Color.FromArgb(180, 255, 151, 0);
            panel2.BackColor = Color.FromArgb(180, 236, 231, 224);
            panel3.BackColor = Color.FromArgb(180, 236, 231, 224);
            panel4.BackColor = Color.FromArgb(0, 0, 0, 0);
            BotonAlmacen.BackColor = Color.FromArgb(255, 240, 225, 197);
            BotonHerramientas.BackColor = Color.FromArgb(255, 240, 225, 197);
            BotonAprobar.BackColor = Color.FromArgb(255, 240, 225, 197);
            BotonComprar.BackColor = Color.FromArgb(255, 240, 225, 197);
            BotonMaterial.BackColor = Color.FromArgb(255, 240, 225, 197);
            BotonHerramienta.BackColor = Color.FromArgb(255, 240, 225, 197);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proyectos proyectos = new Proyectos ();
            this.Hide();
            proyectos.Show();
        }

        private void registroU_Click(object sender, EventArgs e)
        {
            Registro registro= new Registro();
            this.Hide();
            registro.Show();
        }
    }
}
