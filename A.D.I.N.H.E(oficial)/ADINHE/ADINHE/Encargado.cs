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
    public partial class Encargado : Form
    {
        public Encargado()
        {
            InitializeComponent();
        }
        private void BotonMaterial_Click(object sender, EventArgs e)
        {
            Solicitudes Material1 = new Solicitudes();
            this.Hide();
            Material1.Show();
        }

        private void BotonCerrarSesion_Click(object sender, EventArgs e)
        {
            Login Login1 = new Login();
            this.Hide();
            Login1.Show();
        }
    }
}
