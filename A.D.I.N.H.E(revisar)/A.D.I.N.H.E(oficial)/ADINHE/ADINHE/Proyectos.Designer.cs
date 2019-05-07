namespace ADINHE
{
    partial class Proyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proyectos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BotonRegresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.proyectos_ver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncProy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matproy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.herrproy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(754, 450);
            this.panel1.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(134, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 267);
            this.panel4.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proyectos_ver,
            this.EncProy,
            this.matproy,
            this.herrproy});
            this.dataGridView1.Location = new System.Drawing.Point(40, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 45);
            this.dataGridView1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BotonRegresar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 51);
            this.panel3.TabIndex = 33;
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.BackColor = System.Drawing.Color.Black;
            this.BotonRegresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonRegresar.Location = new System.Drawing.Point(0, 0);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.Size = new System.Drawing.Size(754, 51);
            this.BotonRegresar.TabIndex = 32;
            this.BotonRegresar.Text = "Regresar";
            this.BotonRegresar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 64);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(85)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(325, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Proyectos";
            // 
            // proyectos_ver
            // 
            this.proyectos_ver.HeaderText = "Proyecto";
            this.proyectos_ver.Name = "proyectos_ver";
            this.proyectos_ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.proyectos_ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EncProy
            // 
            this.EncProy.HeaderText = "Encargado";
            this.EncProy.Name = "EncProy";
            // 
            // matproy
            // 
            this.matproy.HeaderText = "Materiales";
            this.matproy.Name = "matproy";
            // 
            // herrproy
            // 
            this.herrproy.HeaderText = "Herramientas";
            this.herrproy.Name = "herrproy";
            // 
            // Proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Proyectos";
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.Proyectos_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BotonRegresar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proyectos_ver;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncProy;
        private System.Windows.Forms.DataGridViewTextBoxColumn matproy;
        private System.Windows.Forms.DataGridViewTextBoxColumn herrproy;
    }
}