namespace ADINHE
{
    partial class Comprar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonRegresar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BotonComprar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BotonBorrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.checkcompra = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medi_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 682);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(1, 0);
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
            this.label8.Size = new System.Drawing.Size(114, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Comprar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BotonRegresar);
            this.panel2.Location = new System.Drawing.Point(1, 632);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 49);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.BackColor = System.Drawing.Color.Black;
            this.BotonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonRegresar.Location = new System.Drawing.Point(1032, 0);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.Size = new System.Drawing.Size(132, 49);
            this.BotonRegresar.TabIndex = 12;
            this.BotonRegresar.Text = "Regresar";
            this.BotonRegresar.UseVisualStyleBackColor = false;
            this.BotonRegresar.Click += new System.EventHandler(this.BotonRegresar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(51, 106);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 498);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.BotonComprar);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comprar";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // BotonComprar
            // 
            this.BotonComprar.BackColor = System.Drawing.Color.Black;
            this.BotonComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonComprar.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonComprar.Location = new System.Drawing.Point(481, 319);
            this.BotonComprar.Name = "BotonComprar";
            this.BotonComprar.Size = new System.Drawing.Size(132, 49);
            this.BotonComprar.TabIndex = 22;
            this.BotonComprar.Text = "Comprar";
            this.BotonComprar.UseVisualStyleBackColor = false;
            this.BotonComprar.Click += new System.EventHandler(this.BotonComprar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkcompra,
            this.ID_Orden,
            this.Nom_Mat,
            this.Desc_Mat,
            this.Medi_Mat,
            this.dataGridViewTextBoxColumn2,
            this.Precio_Mat});
            this.dataGridView1.Location = new System.Drawing.Point(99, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 46);
            this.dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Material sin existencia";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.BotonBorrar);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1058, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Material adquirido";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comprado,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.Location = new System.Drawing.Point(134, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(744, 45);
            this.dataGridView2.TabIndex = 25;
            // 
            // BotonBorrar
            // 
            this.BotonBorrar.BackColor = System.Drawing.Color.Black;
            this.BotonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBorrar.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonBorrar.Location = new System.Drawing.Point(481, 319);
            this.BotonBorrar.Name = "BotonBorrar";
            this.BotonBorrar.Size = new System.Drawing.Size(132, 49);
            this.BotonBorrar.TabIndex = 24;
            this.BotonBorrar.Text = "Borrar";
            this.BotonBorrar.UseVisualStyleBackColor = false;
            this.BotonBorrar.Click += new System.EventHandler(this.BotonBorrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(455, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Material adquirido";
            // 
            // checkcompra
            // 
            this.checkcompra.HeaderText = "Comprar";
            this.checkcompra.Name = "checkcompra";
            this.checkcompra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkcompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ID_Orden
            // 
            this.ID_Orden.HeaderText = "ID_Mat";
            this.ID_Orden.Name = "ID_Orden";
            // 
            // Nom_Mat
            // 
            this.Nom_Mat.HeaderText = "Nom_Mat";
            this.Nom_Mat.Name = "Nom_Mat";
            // 
            // Desc_Mat
            // 
            this.Desc_Mat.HeaderText = "Desc_Mat";
            this.Desc_Mat.Name = "Desc_Mat";
            // 
            // Medi_Mat
            // 
            this.Medi_Mat.HeaderText = "Medi_Mat";
            this.Medi_Mat.Name = "Medi_Mat";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cant_Mat";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Precio_Mat
            // 
            this.Precio_Mat.HeaderText = "Precio_Mat";
            this.Precio_Mat.Name = "Precio_Mat";
            // 
            // comprado
            // 
            this.comprado.HeaderText = "Comprado";
            this.comprado.Name = "comprado";
            this.comprado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comprado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Mat";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom_Mat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Desc_Mat";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Medi_Mat";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cant_Mat";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio_Mat";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 681);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Comprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.Comprar_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonRegresar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BotonComprar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BotonBorrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkcompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medi_Mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Mat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn comprado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}