namespace PRA
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.CargaNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CargaDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CargaLegajo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CargaMateria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CargaParcial1 = new System.Windows.Forms.NumericUpDown();
            this.CargaParcial2 = new System.Windows.Forms.NumericUpDown();
            this.CargaFaltas = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.guardarAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CargaParcial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CargaParcial2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CargaFaltas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Carga de Alumnos";
            // 
            // CargaNombre
            // 
            this.CargaNombre.Location = new System.Drawing.Point(3, 73);
            this.CargaNombre.Name = "CargaNombre";
            this.CargaNombre.Size = new System.Drawing.Size(177, 20);
            this.CargaNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Alumno";
            // 
            // CargaDNI
            // 
            this.CargaDNI.Location = new System.Drawing.Point(403, 73);
            this.CargaDNI.Name = "CargaDNI";
            this.CargaDNI.Size = new System.Drawing.Size(177, 20);
            this.CargaDNI.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "DNI del Alumno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Legajo del Alumno";
            // 
            // CargaLegajo
            // 
            this.CargaLegajo.Location = new System.Drawing.Point(3, 148);
            this.CargaLegajo.Name = "CargaLegajo";
            this.CargaLegajo.Size = new System.Drawing.Size(177, 20);
            this.CargaLegajo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Materia cursando";
            // 
            // CargaMateria
            // 
            this.CargaMateria.Location = new System.Drawing.Point(403, 148);
            this.CargaMateria.Name = "CargaMateria";
            this.CargaMateria.Size = new System.Drawing.Size(177, 20);
            this.CargaMateria.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nota del parcial 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nota del parcial 2";
            // 
            // CargaParcial1
            // 
            this.CargaParcial1.Location = new System.Drawing.Point(3, 238);
            this.CargaParcial1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CargaParcial1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CargaParcial1.Name = "CargaParcial1";
            this.CargaParcial1.Size = new System.Drawing.Size(177, 20);
            this.CargaParcial1.TabIndex = 11;
            this.CargaParcial1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CargaParcial2
            // 
            this.CargaParcial2.Location = new System.Drawing.Point(403, 238);
            this.CargaParcial2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CargaParcial2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CargaParcial2.Name = "CargaParcial2";
            this.CargaParcial2.Size = new System.Drawing.Size(177, 20);
            this.CargaParcial2.TabIndex = 12;
            this.CargaParcial2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CargaFaltas
            // 
            this.CargaFaltas.Location = new System.Drawing.Point(3, 325);
            this.CargaFaltas.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.CargaFaltas.Name = "CargaFaltas";
            this.CargaFaltas.Size = new System.Drawing.Size(177, 20);
            this.CargaFaltas.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-1, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Inasistencias";
            // 
            // guardarAlumno
            // 
            this.guardarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarAlumno.Location = new System.Drawing.Point(403, 317);
            this.guardarAlumno.Name = "guardarAlumno";
            this.guardarAlumno.Size = new System.Drawing.Size(177, 28);
            this.guardarAlumno.TabIndex = 15;
            this.guardarAlumno.Text = "Guardar";
            this.guardarAlumno.UseVisualStyleBackColor = true;
            this.guardarAlumno.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 457);
            this.Controls.Add(this.guardarAlumno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CargaFaltas);
            this.Controls.Add(this.CargaParcial2);
            this.Controls.Add(this.CargaParcial1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CargaMateria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CargaLegajo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CargaDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CargaNombre);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Carga de datos";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CargaParcial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CargaParcial2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CargaFaltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CargaNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CargaDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CargaLegajo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CargaMateria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CargaParcial1;
        private System.Windows.Forms.NumericUpDown CargaParcial2;
        private System.Windows.Forms.NumericUpDown CargaFaltas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button guardarAlumno;
    }
}