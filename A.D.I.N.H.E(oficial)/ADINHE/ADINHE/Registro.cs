using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADINHE.CAPACONEXION;

namespace ADINHE
{
    public partial class Registro : Form
    {
        ClsProductos objProduto = new ClsProductos();

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
            objProduto.InsertarRegistro(Convert.ToInt32(cmbRol.SelectedValue), txtContraseña.Text, txtUsuario.Text);

            MessageBox.Show("Registro correcto");
        }
    }
}

