namespace ADINHE
{
    partial class Aprobar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aprobar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AprogaryH = new System.Windows.Forms.TabControl();
            this.Materiales = new System.Windows.Forms.TabPage();
            this.BotonAprobar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AprobarM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entregada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Herr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.Historial = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eliminar_ap = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ap_proy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.AprogaryH.SuspendLayout();
            this.Materiales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Historial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.AprogaryH);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 682);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AprogaryH
            // 
            this.AprogaryH.Controls.Add(this.Materiales);
            this.AprogaryH.Controls.Add(this.Historial);
            this.AprogaryH.Location = new System.Drawing.Point(205, 126);
            this.AprogaryH.Name = "AprogaryH";
            this.AprogaryH.SelectedIndex = 0;
            this.AprogaryH.Size = new System.Drawing.Size(866, 473);
            this.AprogaryH.TabIndex = 15;
            // 
            // Materiales
            // 
            this.Materiales.Controls.Add(this.BotonAprobar);
            this.Materiales.Controls.Add(this.dataGridView2);
            this.Materiales.Controls.Add(this.label10);
            this.Materiales.Location = new System.Drawing.Point(4, 22);
            this.Materiales.Name = "Materiales";
            this.Materiales.Padding = new System.Windows.Forms.Padding(3);
            this.Materiales.Size = new System.Drawing.Size(858, 447);
            this.Materiales.TabIndex = 0;
            this.Materiales.Text = "Materiales";
            this.Materiales.UseVisualStyleBackColor = true;
            // 
            // BotonAprobar
            // 
            this.BotonAprobar.BackColor = System.Drawing.Color.Black;
            this.BotonAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAprobar.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonAprobar.Location = new System.Drawing.Point(229, 229);
            this.BotonAprobar.Name = "BotonAprobar";
            this.BotonAprobar.Size = new System.Drawing.Size(132, 49);
            this.BotonAprobar.TabIndex = 25;
            this.BotonAprobar.Text = "Aprobar";
            this.BotonAprobar.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AprobarM,
            this.dataGridViewTextBoxColumn1,
            this.Entregada,
            this.Nom_Herr,
            this.Cant_Mat});
            this.dataGridView2.Location = new System.Drawing.Point(42, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(544, 46);
            this.dataGridView2.TabIndex = 24;
            // 
            // AprobarM
            // 
            this.AprobarM.HeaderText = "Aprobar";
            this.AprobarM.Name = "AprobarM";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Orden";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Entregada
            // 
            this.Entregada.HeaderText = "ID_Mat";
            this.Entregada.Name = "Entregada";
            // 
            // Nom_Herr
            // 
            this.Nom_Herr.HeaderText = "Nom_Mat";
            this.Nom_Herr.Name = "Nom_Herr";
            // 
            // Cant_Mat
            // 
            this.Cant_Mat.HeaderText = "Cant_Mat";
            this.Cant_Mat.Name = "Cant_Mat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Aprobar Materiales";
            // 
            // Historial
            // 
            this.Historial.Controls.Add(this.label1);
            this.Historial.Controls.Add(this.button1);
            this.Historial.Controls.Add(this.dataGridView1);
            this.Historial.Location = new System.Drawing.Point(4, 22);
            this.Historial.Name = "Historial";
            this.Historial.Padding = new System.Windows.Forms.Padding(3);
            this.Historial.Size = new System.Drawing.Size(858, 447);
            this.Historial.TabIndex = 1;
            this.Historial.Text = "Historial";
            this.Historial.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Historial de Materiales";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(318, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 49);
            this.button1.TabIndex = 26;
            this.button1.Text = "Aprobar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar_ap,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ap_proy});
            this.dataGridView1.Location = new System.Drawing.Point(150, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 46);
            this.dataGridView1.TabIndex = 25;
            // 
            // eliminar_ap
            // 
            this.eliminar_ap.HeaderText = "Eliminar material";
            this.eliminar_ap.Name = "eliminar_ap";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nom_Mat";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Cant_Mat";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ap_proy
            // 
            this.ap_proy.HeaderText = "Proyecto";
            this.ap_proy.Name = "ap_proy";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1163, 75);
            this.panel3.TabIndex = 14;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Administrador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(553, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Aprobar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BotonRegresar);
            this.panel2.Location = new System.Drawing.Point(1, 633);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 49);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.BackColor = System.Drawing.Color.Black;
            this.BotonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonRegresar.Location = new System.Drawing.Point(1034, -1);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.Size = new System.Drawing.Size(132, 49);
            this.BotonRegresar.TabIndex = 12;
            this.BotonRegresar.Text = "Regresar";
            this.BotonRegresar.UseVisualStyleBackColor = false;
            this.BotonRegresar.Click += new System.EventHandler(this.BotonRegresar_Click);
            // 
            // Aprobar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1164, 681);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aprobar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprobar";
            this.Load += new System.EventHandler(this.Aprobar_Load);
            this.panel1.ResumeLayout(false);
            this.AprogaryH.ResumeLayout(false);
            this.Materiales.ResumeLayout(false);
            this.Materiales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Historial.ResumeLayout(false);
            this.Historial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonRegresar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl AprogaryH;
        private System.Windows.Forms.TabPage Materiales;
        private System.Windows.Forms.Button BotonAprobar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AprobarM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entregada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Herr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_Mat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage Historial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eliminar_ap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ap_proy;
    }
}