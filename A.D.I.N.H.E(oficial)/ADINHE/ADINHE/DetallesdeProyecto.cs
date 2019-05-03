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
    public partial class DetallesdeProyecto : Form
    {
        public DetallesdeProyecto()
        {
            InitializeComponent();
        }

        private void DetallesdeProyecto_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            Administrador Administrador1 = new Administrador();
            this.Hide();
            Administrador1.Show();
        }
    }
}
