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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            ActualizarAlumno.Visible = false;
        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexionString = "server='localhost'; database='alumnos'; uid='AdminAlumnos'; pwd='2505'";


            try
            {

                using (MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(conexionString))
                {
                    conexion.Open();

                    MySqlCommand Recuperar = new MySqlCommand();

                    Recuperar.Connection = conexion;

                    string query = "SELECT * FROM datosalumnos WHERE DNI=@DNI";

                    Recuperar.CommandText = query;

                    int DNIModificar = Convert.ToInt32(textBox1.Text);
                    Recuperar.Parameters.AddWithValue("@DNI", DNIModificar);

                    using (MySqlDataReader reader = Recuperar.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CargaNombre.Text = reader["Nombre"].ToString();

                            CargaDNI.Text = reader["DNI"].ToString();

                            CargaLegajo.Text = reader["DNI"].ToString();

                            CargaMateria.Text = reader["Materia"].ToString();

                            CargaParcial1.Value = Convert.ToDecimal(reader["NotaParcial1"]);

                            CargaParcial2.Value = Convert.ToDecimal(reader["NotaParcial2"]);

                            CargaFaltas.Value = Convert.ToDecimal(reader["Inasistencias"]);

                            CargaNotaFinal.Value = Convert.ToDecimal(reader["NotaFinal"]);

                            ActualizarAlumno.Visible = true;

                            MessageBox.Show("Datos recuperados correctamente");
                            conexion.Close();
                        }
                    }
                }
            }
            catch(MySqlException ex) {
                MessageBox.Show("Hubo un error al recuperar los datos:" + ex);
            }
        }

        private void ActualizarAlumno_Click(object sender, EventArgs e)
        {
            string conexionString = "server='localhost'; database='alumnos'; uid='AdminAlumnos'; pwd='2505'";

            try
            {
                using (MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(conexionString))
                {
                    conexion.Open();

                    string query = "UPDATE datosalumnos SET Nombre=@Nombre, Legajo=@Legajo, Materia=@Materia, NotaParcial1=@NotaParcial1, NotaFinal=@NotaFinal, Libre=@Libre, MateriaAprobada=@MateriaAprobada WHERE DNI=@DNI";

                    MySqlCommand Actualizar = new MySqlCommand(query, conexion);

                    Actualizar.Parameters.AddWithValue("@Nombre", CargaNombre.Text);

                    int DniActualizar = Convert.ToInt32(CargaDNI.Text);
                    Actualizar.Parameters.AddWithValue("@DNI", DniActualizar);

                    int LegajoActualizar = Convert.ToInt32(CargaLegajo.Text);
                    Actualizar.Parameters.AddWithValue("@Legajo", LegajoActualizar);

                    Actualizar.Parameters.AddWithValue("@Materia", CargaMateria.Text);

                    int ActualizarParcial1 = Convert.ToInt32(CargaParcial1.Value);
                    Actualizar.Parameters.AddWithValue("@NotaParcial1", ActualizarParcial1);

                    int ActualizarParcial2 = Convert.ToInt32(CargaParcial2.Value);
                    Actualizar.Parameters.AddWithValue("@NotaParcial2", ActualizarParcial2);

                    int ActualizarFaltas = Convert.ToInt32(CargaFaltas.Value);
                    Actualizar.Parameters.AddWithValue("@Inasistencias", ActualizarFaltas);

                    if (ActualizarFaltas >= 4)
                    {
                        Actualizar.Parameters.AddWithValue("@Libre", true);
                    }
                    else
                    {
                        Actualizar.Parameters.AddWithValue("@Libre", false);
                    }

                    int ActualizarFinal = Convert.ToInt32(CargaNotaFinal.Value);
                    Actualizar.Parameters.AddWithValue("@NotaFinal", ActualizarFinal);

                    if (ActualizarFinal >= 6)
                    {
                        Actualizar.Parameters.AddWithValue("@MateriaAprobada", true);
                    }
                    else
                    {
                        Actualizar.Parameters.AddWithValue("@MateriaAprobada", false);
                    }
                    Actualizar.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados correctamente.");
                    
                }


            }
            catch (MySqlException ex){
                MessageBox.Show("Hubo un error al actualizar los datos: " + ex);
            }
        }
    }
}