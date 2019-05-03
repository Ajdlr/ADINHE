using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace ADINHE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Entidades.Login obje = new Entidades.Login();
        Negocios.Login objn = new Negocios.Login();

        private void Login_Load(object sender, EventArgs e)
        {
            PanelDatos.BackColor = Color.FromArgb(130, 236, 231, 224);
            IniciarSesion.BackColor = Color.FromArgb(255, 236, 149, 58);
            PanelCerrar.BackColor = Color.FromArgb(255, 255, 166, 0);
            CerrarAplicacion.BackColor = Color.FromArgb(255, 255, 166, 0);

        }
        
        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            obje.descripcion = Usuario.Text;
            obje.contraseña = Contrasena.Text;
            dt = objn.loginN(obje);

            if (dt.Rows.Count > 0)
            {
                obje.descripcion = dt.Rows[0][1].ToString();
                obje.contraseña = dt.Rows[0][2].ToString();
                
                MessageBox.Show("Bienvenido " + obje.descripcion);

                this.Hide();

                switch (obje.rol)
                {
                    case 1:
                        Administrador admi = new Administrador();
                        this.Hide();
                        admi.Show();
                        break;
                    case 2:
                        Almacenista alma = new Almacenista();
                        this.Hide();
                        alma.Show();
                        break;
                    case 3:
                        Encargado encar = new Encargado();
                        this.Hide();
                        encar.Show();
                        break;
                    case 4:
                        Recepcion recep = new Recepcion();
                        this.Hide();
                        recep.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error"); 
            }
        }

        private void PanelDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void TextoContrasena_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImagenUsuario_Click(object sender, EventArgs e)
        {

        }

        private void PanelCerrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CerrarAplicacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
