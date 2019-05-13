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
    public partial class Proyectos : Form
    {
        ClsProductos objProduto = new ClsProductos();
        public Proyectos()
        {
            InitializeComponent();
        }

        private void Proyectos_Load(object sender, EventArgs e)
        {
            ListarProyectos();
            ListarUsuario();
        }

        private void ListarUsuario()
        {
            ClsProductos objProd = new ClsProductos();
            cmbEncargado.DataSource = objProd.ListarUsuario();
            cmbEncargado.DisplayMember = "descripcion";
            cmbEncargado.ValueMember = "usuarioid";

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

        private void BotonComprar_Click(object sender, EventArgs e)
        {
            objProduto.InsertarProyecto(Convert.ToInt32(cmbEncargado.SelectedValue), textBox1.Text, textBox2.Text);

            MessageBox.Show("Registro correcto");
            ListarProyectos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
}



        private void ListarProyectos()
        {
            ClsProductos objProduto = new ClsProductos();
            dataGridView1 = objPro.ListarProyectos();
        }


    }
}
