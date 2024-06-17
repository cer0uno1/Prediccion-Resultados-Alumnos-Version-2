namespace PRA
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notaparcial1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notaparcial2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notafinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materiaaprobada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.DNI,
            this.Legajo,
            this.Materia,
            this.Notaparcial1,
            this.Notaparcial2,
            this.Faltas,
            this.Libre,
            this.Notafinal,
            this.Materiaaprobada});
            this.dataGridView1.Location = new System.Drawing.Point(-5, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            // 
            // Notaparcial1
            // 
            this.Notaparcial1.HeaderText = "Nota 1er Parcial";
            this.Notaparcial1.Name = "Notaparcial1";
            // 
            // Notaparcial2
            // 
            this.Notaparcial2.HeaderText = "Nota 2do Parcial";
            this.Notaparcial2.Name = "Notaparcial2";
            // 
            // Faltas
            // 
            this.Faltas.HeaderText = "Inasistencias";
            this.Faltas.Name = "Faltas";
            // 
            // Libre
            // 
            this.Libre.HeaderText = "Alumno Libre?";
            this.Libre.Name = "Libre";
            this.Libre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Libre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Notafinal
            // 
            this.Notafinal.HeaderText = "Nota Final";
            this.Notafinal.Name = "Notafinal";
            // 
            // Materiaaprobada
            // 
            this.Materiaaprobada.HeaderText = "Materia Aprobada?";
            this.Materiaaprobada.Name = "Materiaaprobada";
            this.Materiaaprobada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enlistar Alumnos";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.Text = "Enlistar Alumnos";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notaparcial1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notaparcial2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notafinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materiaaprobada;
        private System.Windows.Forms.Label label1;
    }
}