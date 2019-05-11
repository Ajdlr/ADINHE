namespace ADINHE
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.PanelDatos = new System.Windows.Forms.Panel();
            this.TextoContrasena = new System.Windows.Forms.Label();
            this.Contrasena = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.TextoUsuario = new System.Windows.Forms.Label();
            this.ImagenUsuario = new System.Windows.Forms.PictureBox();
            this.PanelCerrar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CerrarAplicacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenUsuario)).BeginInit();
            this.PanelCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.BackColor = System.Drawing.Color.Black;
            this.IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.IniciarSesion.Location = new System.Drawing.Point(223, 239);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(153, 37);
            this.IniciarSesion.TabIndex = 7;
            this.IniciarSesion.Text = "Iniciar Sesión";
            this.IniciarSesion.UseVisualStyleBackColor = false;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // PanelDatos
            // 
            this.PanelDatos.Controls.Add(this.TextoContrasena);
            this.PanelDatos.Controls.Add(this.Contrasena);
            this.PanelDatos.Controls.Add(this.Usuario);
            this.PanelDatos.Controls.Add(this.TextoUsuario);
            this.PanelDatos.Controls.Add(this.IniciarSesion);
            this.PanelDatos.Location = new System.Drawing.Point(286, 300);
            this.PanelDatos.Name = "PanelDatos";
            this.PanelDatos.Size = new System.Drawing.Size(611, 296);
            this.PanelDatos.TabIndex = 8;
            this.PanelDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDatos_Paint);
            // 
            // TextoContrasena
            // 
            this.TextoContrasena.AutoSize = true;
            this.TextoContrasena.BackColor = System.Drawing.Color.Transparent;
            this.TextoContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoContrasena.Location = new System.Drawing.Point(50, 150);
            this.TextoContrasena.Name = "TextoContrasena";
            this.TextoContrasena.Size = new System.Drawing.Size(165, 31);
            this.TextoContrasena.TabIndex = 12;
            this.TextoContrasena.Text = "Contraseña";
            this.TextoContrasena.Click += new System.EventHandler(this.TextoContrasena_Click);
            // 
            // Contrasena
            // 
            this.Contrasena.Location = new System.Drawing.Point(56, 184);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(491, 20);
            this.Contrasena.TabIndex = 11;
            this.Contrasena.TextChanged += new System.EventHandler(this.Contrasena_TextChanged);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(56, 80);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(491, 20);
            this.Usuario.TabIndex = 10;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            // 
            // TextoUsuario
            // 
            this.TextoUsuario.AutoSize = true;
            this.TextoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.TextoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoUsuario.Location = new System.Drawing.Point(50, 46);
            this.TextoUsuario.Name = "TextoUsuario";
            this.TextoUsuario.Size = new System.Drawing.Size(115, 31);
            this.TextoUsuario.TabIndex = 8;
            this.TextoUsuario.Text = "Usuario";
            this.TextoUsuario.Click += new System.EventHandler(this.TextoUsuario_Click);
            // 
            // ImagenUsuario
            // 
            this.ImagenUsuario.BackColor = System.Drawing.Color.Transparent;
            this.ImagenUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagenUsuario.BackgroundImage")));
            this.ImagenUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagenUsuario.Location = new System.Drawing.Point(509, 113);
            this.ImagenUsuario.Name = "ImagenUsuario";
            this.ImagenUsuario.Size = new System.Drawing.Size(161, 164);
            this.ImagenUsuario.TabIndex = 9;
            this.ImagenUsuario.TabStop = false;
            this.ImagenUsuario.Click += new System.EventHandler(this.ImagenUsuario_Click);
            // 
            // PanelCerrar
            // 
            this.PanelCerrar.Controls.Add(this.label1);
            this.PanelCerrar.Controls.Add(this.CerrarAplicacion);
            this.PanelCerrar.ForeColor = System.Drawing.Color.Black;
            this.PanelCerrar.Location = new System.Drawing.Point(-2, 0);
            this.PanelCerrar.Name = "PanelCerrar";
            this.PanelCerrar.Size = new System.Drawing.Size(1176, 48);
            this.PanelCerrar.TabIndex = 10;
            this.PanelCerrar.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCerrar_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema Administrador de Inventario y Herramientas (ADINHE)";
            // 
            // CerrarAplicacion
            // 
            this.CerrarAplicacion.BackColor = System.Drawing.Color.Transparent;
            this.CerrarAplicacion.FlatAppearance.BorderSize = 0;
            this.CerrarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarAplicacion.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarAplicacion.ForeColor = System.Drawing.Color.Black;
            this.CerrarAplicacion.Location = new System.Drawing.Point(1107, 0);
            this.CerrarAplicacion.Name = "CerrarAplicacion";
            this.CerrarAplicacion.Size = new System.Drawing.Size(69, 48);
            this.CerrarAplicacion.TabIndex = 0;
            this.CerrarAplicacion.Text = "X";
            this.CerrarAplicacion.UseVisualStyleBackColor = false;
            this.CerrarAplicacion.Click += new System.EventHandler(this.CerrarAplicacion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1053, 539);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 122);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1173, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelCerrar);
            this.Controls.Add(this.ImagenUsuario);
            this.Controls.Add(this.PanelDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.PanelDatos.ResumeLayout(false);
            this.PanelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenUsuario)).EndInit();
            this.PanelCerrar.ResumeLayout(false);
            this.PanelCerrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.Panel PanelDatos;
        private System.Windows.Forms.Label TextoUsuario;
        private System.Windows.Forms.TextBox Contrasena;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label TextoContrasena;
        private System.Windows.Forms.PictureBox ImagenUsuario;
        private System.Windows.Forms.Panel PanelCerrar;
        private System.Windows.Forms.Button CerrarAplicacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}