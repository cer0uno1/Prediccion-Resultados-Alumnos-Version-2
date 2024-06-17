using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DatosAlumno alumno = new DatosAlumno();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alumno.Nombre = CargaNombre.Text;

            Convert.ToInt32(CargaDNI.Text);
            alumno.DNI = CargaDNI.Text;

            int LegAux = Convert.ToInt32(CargaLegajo.Text);
            alumno.Legajo = LegAux;

            alumno.Materia = CargaMateria.Text;

            int Parcial1 = Convert.ToInt32(CargaParcial1.Value);
            alumno.Nota1erParcial = Parcial1;      

            int Parcial2 = Convert.ToInt32(CargaParcial2.Value);
            alumno.Nota2doParcial = Parcial2;

            if(Parcial1 >= 6 && Parcial2 >= 6){
                alumno.NotaFinal = (Parcial1 + Parcial2) / 2;
                alumno.MateriaAprobada = true;
            }

            else if ((Parcial1 >= 4 && Parcial1 <= 5) || (Parcial2 >= 4 && Parcial2 <= 5))
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = "Ingrese la nota final",
                    StartPosition = FormStartPosition.CenterScreen,
                    MaximizeBox = false
                };

                Label textLabel = new Label() { Left = 50, Top = 20, Text = "El alumno no promocionó uno o más parciales. Ingrese la nota final" };
                NumericUpDown numericUpDown = new NumericUpDown() { Left = 50, Top = 50, Width = 400, Minimum = 1, Maximum = 10 };
                Button confirmationButton = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmationButton.Click += (object enviar, EventArgs ee) => { prompt.Close(); };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(numericUpDown);
                prompt.Controls.Add(confirmationButton);
                prompt.AcceptButton = confirmationButton;

                DialogResult dialogResult = prompt.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    alumno.NotaFinal = Convert.ToInt32(numericUpDown.Value);
                    if(alumno.NotaFinal >= 6)
                    {
                        alumno.MateriaAprobada = true;
                    }
                    else
                    {
                        alumno.MateriaAprobada = false;
                    }
                }
            }
            else
            {
                alumno.MateriaAprobada = false;
            }

            alumno.Inasistencias = Convert.ToInt32(CargaFaltas.Value);
            if(alumno.Inasistencias >= 4)
            {
                alumno.Libre = true;
            }
            else
            {
                alumno.Libre= false;
            }
            string conexionString = "server='localhost'; database='alumnos'; uid='AdminAlumnos'; pwd='2505'";

            try
            {
                using (MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(conexionString))
                {
                    conexion.Open();

                    MySqlCommand Insertar = new MySqlCommand();
                    Insertar.Connection = conexion;

                    string query = "INSERT INTO datosalumnos (Nombre, DNI, Legajo, Materia, Inasistencias, Libre, NotaParcial1, NotaParcial2, NotaFinal, MateriaAprobada) VALUES (@Nombre, @DNI, @Legajo, @Materia, @Inasistencias, @Libre, @NotaParcial1, @NotaParcial2, @NotaFinal, @MateriaAprobada)";
                    Insertar.CommandText = query;

                    Insertar.Parameters.AddWithValue("@Nombre", alumno.Nombre);

                    Insertar.Parameters.AddWithValue("@DNI", alumno.DNI);

                    Insertar.Parameters.AddWithValue("@Legajo", alumno.Legajo);

                    Insertar.Parameters.AddWithValue("@Materia", alumno.Materia);

                    Insertar.Parameters.AddWithValue("@Inasistencias", alumno.Inasistencias);

                    Insertar.Parameters.AddWithValue("@Libre", alumno.Libre);

                    Insertar.Parameters.AddWithValue("@NotaParcial1", alumno.Nota1erParcial);

                    Insertar.Parameters.AddWithValue("@NotaParcial2", alumno.Nota2doParcial);

                    Insertar.Parameters.AddWithValue("@NotaFinal", alumno.NotaFinal);

                    Insertar.Parameters.AddWithValue("@MateriaAprobada", alumno.MateriaAprobada);

                    Insertar.ExecuteNonQuery();

                    MessageBox.Show("Datos cargados correctamente");

                    this.Close();
                } // La conexión se cierra automáticamente al final del bloque using
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }



        }
    }
}
