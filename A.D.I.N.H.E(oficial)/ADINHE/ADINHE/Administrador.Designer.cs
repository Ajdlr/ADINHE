namespace ADINHE
{
    partial class Administrador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BotonAlmacen = new System.Windows.Forms.Button();
            this.BotonHerramienta = new System.Windows.Forms.Button();
            this.BotonMaterial = new System.Windows.Forms.Button();
            this.BotonComprar = new System.Windows.Forms.Button();
            this.BotonAprobar = new System.Windows.Forms.Button();
            this.BotonHerramientas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BotonCerrarSesion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DProyectos = new System.Windows.Forms.Button();
            this.registroU = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 547);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.registroU);
            this.panel4.Controls.Add(this.DProyectos);
            this.panel4.Controls.Add(this.BotonAlmacen);
            this.panel4.Controls.Add(this.BotonHerramienta);
            this.panel4.Controls.Add(this.BotonMaterial);
            this.panel4.Controls.Add(this.BotonComprar);
            this.panel4.Controls.Add(this.BotonAprobar);
            this.panel4.Controls.Add(this.BotonHerramientas);
            this.panel4.Location = new System.Drawing.Point(69, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(557, 296);
            this.panel4.TabIndex = 12;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // BotonAlmacen
            // 
            this.BotonAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.BotonAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAlmacen.Location = new System.Drawing.Point(2, 76);
            this.BotonAlmacen.Name = "BotonAlmacen";
            this.BotonAlmacen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonAlmacen.Size = new System.Drawing.Size(261, 67);
            this.BotonAlmacen.TabIndex = 1;
            this.BotonAlmacen.Text = "Almacén";
            this.BotonAlmacen.UseVisualStyleBackColor = false;
            this.BotonAlmacen.Click += new System.EventHandler(this.BotonAlmacen_Click);
            // 
            // BotonHerramienta
            // 
            this.BotonHerramienta.BackColor = System.Drawing.Color.Transparent;
            this.BotonHerramienta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonHerramienta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonHerramienta.Location = new System.Drawing.Point(294, 222);
            this.BotonHerramienta.Name = "BotonHerramienta";
            this.BotonHerramienta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonHerramienta.Size = new System.Drawing.Size(261, 70);
            this.BotonHerramienta.TabIndex = 6;
            this.BotonHerramienta.Text = "Herramienta";
            this.BotonHerramienta.UseVisualStyleBackColor = false;
            this.BotonHerramienta.Click += new System.EventHandler(this.BotonHerramienta_Click);
            // 
            // BotonMaterial
            // 
            this.BotonMaterial.BackColor = System.Drawing.Color.Transparent;
            this.BotonMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonMaterial.Location = new System.Drawing.Point(294, 149);
            this.BotonMaterial.Name = "BotonMaterial";
            this.BotonMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonMaterial.Size = new System.Drawing.Size(261, 67);
            this.BotonMaterial.TabIndex = 5;
            this.BotonMaterial.Text = "Material";
            this.BotonMaterial.UseVisualStyleBackColor = false;
            this.BotonMaterial.Click += new System.EventHandler(this.BotonMaterial_Click);
            // 
            // BotonComprar
            // 
            this.BotonComprar.BackColor = System.Drawing.Color.Transparent;
            this.BotonComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonComprar.Location = new System.Drawing.Point(294, 76);
            this.BotonComprar.Name = "BotonComprar";
            this.BotonComprar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonComprar.Size = new System.Drawing.Size(261, 67);
            this.BotonComprar.TabIndex = 4;
            this.BotonComprar.Text = "Comprar";
            this.BotonComprar.UseVisualStyleBackColor = false;
            this.BotonComprar.Click += new System.EventHandler(this.BotonComprar_Click);
            // 
            // BotonAprobar
            // 
            this.BotonAprobar.BackColor = System.Drawing.Color.Transparent;
            this.BotonAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAprobar.Location = new System.Drawing.Point(294, 3);
            this.BotonAprobar.Name = "BotonAprobar";
            this.BotonAprobar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonAprobar.Size = new System.Drawing.Size(261, 67);
            this.BotonAprobar.TabIndex = 3;
            this.BotonAprobar.Text = "Aprobar";
            this.BotonAprobar.UseVisualStyleBackColor = false;
            this.BotonAprobar.Click += new System.EventHandler(this.BotonAprobar_Click);
            // 
            // BotonHerramientas
            // 
            this.BotonHerramientas.BackColor = System.Drawing.Color.Transparent;
            this.BotonHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonHerramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonHerramientas.Location = new System.Drawing.Point(2, 152);
            this.BotonHerramientas.Name = "BotonHerramientas";
            this.BotonHerramientas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonHerramientas.Size = new System.Drawing.Size(261, 67);
            this.BotonHerramientas.TabIndex = 2;
            this.BotonHerramientas.Text = "Herramientas";
            this.BotonHerramientas.UseVisualStyleBackColor = false;
            this.BotonHerramientas.Click += new System.EventHandler(this.BotonHerramientas_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.BotonCerrarSesion);
            this.panel3.Location = new System.Drawing.Point(3, 502);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(699, 42);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // BotonCerrarSesion
            // 
            this.BotonCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrarSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonCerrarSesion.Location = new System.Drawing.Point(580, -1);
            this.BotonCerrarSesion.Name = "BotonCerrarSesion";
            this.BotonCerrarSesion.Size = new System.Drawing.Size(116, 40);
            this.BotonCerrarSesion.TabIndex = 9;
            this.BotonCerrarSesion.Text = "Cerrar Sesión";
            this.BotonCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonCerrarSesion.UseVisualStyleBackColor = false;
            this.BotonCerrarSesion.Click += new System.EventHandler(this.BotonCerrarSesion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 73);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            // 
            // DProyectos
            // 
            this.DProyectos.BackColor = System.Drawing.Color.Transparent;
            this.DProyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DProyectos.Location = new System.Drawing.Point(2, 2);
            this.DProyectos.Name = "DProyectos";
            this.DProyectos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DProyectos.Size = new System.Drawing.Size(261, 68);
            this.DProyectos.TabIndex = 7;
            this.DProyectos.Text = "Proyectos";
            this.DProyectos.UseVisualStyleBackColor = false;
            this.DProyectos.Click += new System.EventHandler(this.button1_Click);
            // 
            // registroU
            // 
            this.registroU.BackColor = System.Drawing.Color.Transparent;
            this.registroU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registroU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registroU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroU.Location = new System.Drawing.Point(2, 225);
            this.registroU.Name = "registroU";
            this.registroU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registroU.Size = new System.Drawing.Size(261, 67);
            this.registroU.TabIndex = 8;
            this.registroU.Text = "Registrar Usuario";
            this.registroU.UseVisualStyleBackColor = false;
            this.registroU.Click += new System.EventHandler(this.registroU_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(698, 544);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonHerramienta;
        private System.Windows.Forms.Button BotonMaterial;
        private System.Windows.Forms.Button BotonComprar;
        private System.Windows.Forms.Button BotonAprobar;
        private System.Windows.Forms.Button BotonHerramientas;
        private System.Windows.Forms.Button BotonAlmacen;
        private System.Windows.Forms.Button BotonCerrarSesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DProyectos;
        private System.Windows.Forms.Button registroU;
    }
}

