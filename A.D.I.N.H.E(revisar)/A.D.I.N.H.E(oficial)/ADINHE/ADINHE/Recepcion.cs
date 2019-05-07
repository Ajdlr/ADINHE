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
    public partial class Recepcion : Form
    {
        public Recepcion()
        {
            InitializeComponent();
        }

        private void Recepcion_Load(object sender, EventArgs e)
        {

        }

        private void BotonHerramientas_Click(object sender, EventArgs e)
        {
            Herramientas Herramientas1 = new Herramientas();
            this.Hide();
            Herramientas1.Show();
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
