namespace PRA
{
    partial class PRA
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
        {            this.titulo = new System.Windows.Forms.Label();
            this.cargaDatos = new System.Windows.Forms.Button();
            this.eliminarDatos = new System.Windows.Forms.Button();
            this.modificarDatos = new System.Windows.Forms.Button();
            this.enlistarAlumno = new System.Windows.Forms.Button();
            this.enlistarTodo = new System.Windows.Forms.Button();
            this.salida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(12, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(557, 37);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Predicción de Resultados de Alumnos";
            // 
            // cargaDatos
            // 
            this.cargaDatos.Location = new System.Drawing.Point(79, 93);
            this.cargaDatos.Name = "cargaDatos";
            this.cargaDatos.Size = new System.Drawing.Size(114, 47);
            this.cargaDatos.TabIndex = 1;
            this.cargaDatos.Text = "Cargar Datos";
            this.cargaDatos.UseVisualStyleBackColor = true;
            this.cargaDatos.Click += new System.EventHandler(this.cargaDatos_Click);
            // 
            // eliminarDatos
            // 
            this.eliminarDatos.Location = new System.Drawing.Point(327, 93);
            this.eliminarDatos.Name = "eliminarDatos";
            this.eliminarDatos.Size = new System.Drawing.Size(113, 47);
            this.eliminarDatos.TabIndex = 2;
            this.eliminarDatos.Text = "Eliminar Datos";
            this.eliminarDatos.UseVisualStyleBackColor = true;
            this.eliminarDatos.Click += new System.EventHandler(this.eliminarDatos_Click);
            // 
            // modificarDatos
            // 
            this.modificarDatos.Location = new System.Drawing.Point(79, 183);
            this.modificarDatos.Name = "modificarDatos";
            this.modificarDatos.Size = new System.Drawing.Size(114, 47);
            this.modificarDatos.TabIndex = 3;
            this.modificarDatos.Text = "Modificar Datos";
            this.modificarDatos.UseVisualStyleBackColor = true;
            this.modificarDatos.Click += new System.EventHandler(this.modificarDatos_Click);
            // 
            // enlistarAlumno
            // 
            this.enlistarAlumno.Location = new System.Drawing.Point(327, 183);
            this.enlistarAlumno.Name = "enlistarAlumno";
            this.enlistarAlumno.Size = new System.Drawing.Size(114, 47);
            this.enlistarAlumno.TabIndex = 4;
            this.enlistarAlumno.Text = "Enlistar Un Alumno";
            this.enlistarAlumno.UseVisualStyleBackColor = true;
            this.enlistarAlumno.Click += new System.EventHandler(this.enlistarAlumno_Click);
            // 
            // enlistarTodo
            // 
            this.enlistarTodo.Location = new System.Drawing.Point(79, 282);
            this.enlistarTodo.Name = "enlistarTodo";
            this.enlistarTodo.Size = new System.Drawing.Size(114, 47);
            this.enlistarTodo.TabIndex = 5;
            this.enlistarTodo.Text = "Enlistar Todos";
            this.enlistarTodo.UseVisualStyleBackColor = true;
            this.enlistarTodo.Click += new System.EventHandler(this.enlistarTodo_Click);
            // 
            // salida
            // 
            this.salida.Location = new System.Drawing.Point(327, 282);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(113, 47);
            this.salida.TabIndex = 6;
            this.salida.Text = "Salir";
            this.salida.UseVisualStyleBackColor = true;
            this.salida.Click += new System.EventHandler(this.salida_Click);
            // 
            // PRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(580, 457);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.enlistarTodo);
            this.Controls.Add(this.enlistarAlumno);
            this.Controls.Add(this.modificarDatos);
            this.Controls.Add(this.eliminarDatos);
            this.Controls.Add(this.cargaDatos);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PRA";
            this.Text = "Predicción de Resultados de Alumnos";
            this.Load += new System.EventHandler(this.PRA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button cargaDatos;
        private System.Windows.Forms.Button eliminarDatos;
        private System.Windows.Forms.Button modificarDatos;
        private System.Windows.Forms.Button enlistarAlumno;
        private System.Windows.Forms.Button enlistarTodo;
        private System.Windows.Forms.Button salida;
    }
}

