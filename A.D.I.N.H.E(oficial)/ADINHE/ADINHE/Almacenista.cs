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
    public partial class Almacenista : Form
    {
        public Almacenista()
        {
            InitializeComponent();
        }

        private void Botoncomprar_Click(object sender, EventArgs e)
        {
            Comprar Comprar1 = new Comprar();
            this.Hide();
            Comprar1.Show();
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
    }
}
