namespace ADINHE
{
    partial class Encargado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encargado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BotonHerramienta = new System.Windows.Forms.Button();
            this.BotonMaterial = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BotonCerrarSesion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 469);
            this.panel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BotonHerramienta);
            this.panel4.Controls.Add(this.BotonMaterial);
            this.panel4.Location = new System.Drawing.Point(65, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(467, 235);
            this.panel4.TabIndex = 15;
            // 
            // BotonHerramienta
            // 
            this.BotonHerramienta.BackColor = System.Drawing.Color.Transparent;
            this.BotonHerramienta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonHerramienta.FlatAppearance.BorderSize = 0;
            this.BotonHerramienta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonHerramienta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(85)))), ((int)(((byte)(46)))));
            this.BotonHerramienta.Location = new System.Drawing.Point(99, 49);
            this.BotonHerramienta.Name = "BotonHerramienta";
            this.BotonHerramienta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonHerramienta.Size = new System.Drawing.Size(261, 70);
            this.BotonHerramienta.TabIndex = 8;
            this.BotonHerramienta.Text = "Herramienta";
            this.BotonHerramienta.UseVisualStyleBackColor = false;
            this.BotonHerramienta.Click += new System.EventHandler(this.BotonHerramienta_Click);
            // 
            // BotonMaterial
            // 
            this.BotonMaterial.BackColor = System.Drawing.Color.Transparent;
            this.BotonMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonMaterial.FlatAppearance.BorderSize = 0;
            this.BotonMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(85)))), ((int)(((byte)(46)))));
            this.BotonMaterial.Location = new System.Drawing.Point(99, 125);
            this.BotonMaterial.Name = "BotonMaterial";
            this.BotonMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonMaterial.Size = new System.Drawing.Size(261, 67);
            this.BotonMaterial.TabIndex = 7;
            this.BotonMaterial.Text = "Material";
            this.BotonMaterial.UseVisualStyleBackColor = false;
            this.BotonMaterial.Click += new System.EventHandler(this.BotonMaterial_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.BotonCerrarSesion);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(601, 72);
            this.panel3.TabIndex = 14;
            // 
            // BotonCerrarSesion
            // 
            this.BotonCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrarSesion.CausesValidation = false;
            this.BotonCerrarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BotonCerrarSesion.Location = new System.Drawing.Point(0, 0);
            this.BotonCerrarSesion.Name = "BotonCerrarSesion";
            this.BotonCerrarSesion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.BotonCerrarSesion.Size = new System.Drawing.Size(601, 72);
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 73);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(85)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(216, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encargado";
            // 
            // Encargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 469);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encargado";
            this.Text = "Encargado";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BotonHerramienta;
        private System.Windows.Forms.Button BotonMaterial;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BotonCerrarSesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}