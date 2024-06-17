using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PRA
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string conexionString = "server='localhost'; database='alumnos'; uid='AdminAlumnos'; pwd='2505'";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();

                    string query = "SELECT Nombre, DNI, Legajo, Materia, NotaParcial1, NotaParcial2, Inasistencias, NotaFinal, " +
                                   "CASE WHEN Inasistencias >= 4 THEN 1 ELSE 0 END AS Libre, " +
                                   "CASE WHEN NotaFinal >= 6 THEN 1 ELSE 0 END AS MateriaAprobada " +
                                   "FROM datosalumnos WHERE DNI=@DNI";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    int DNIBuscar = Convert.ToInt32(textBox1.Text);
                    cmd.Parameters.AddWithValue("@DNI", DNIBuscar);

                    MySqlDataReader leer = cmd.ExecuteReader();

                    while (leer.Read())
                    {
                        string alumnolibre = leer["Libre"].ToString() == "1" ? "Si" : "No";
                        string materiaaprobada = leer["MateriaAprobada"].ToString() == "1" ? "Si" : "No";
                        dataGridView1.Rows.Add(leer["Nombre"], leer["DNI"], leer["Legajo"], leer["Materia"], leer["NotaParcial1"], leer["NotaParcial2"], leer["Inasistencias"], alumnolibre, leer["NotaFinal"], materiaaprobada);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hubo un error al recuperar los datos: " + ex.Message);
            }
        }
    }
}
