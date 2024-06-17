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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRA
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
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
                                       "FROM datosalumnos";

                        MySqlCommand cmd = new MySqlCommand(query, conexion);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

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
