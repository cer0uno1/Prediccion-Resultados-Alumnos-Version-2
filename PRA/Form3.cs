using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DNIEliminar = Convert.ToInt32(textBox1.Text);

            string conexionString = "server='localhost'; database='alumnos'; uid='AdminAlumnos'; pwd='2505'";

            try
            {
                using (MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(conexionString))
                {
                    conexion.Open();

                    MySqlCommand Eliminar = new MySqlCommand();
                    Eliminar.Connection = conexion;

                    string query = "DELETE FROM datosalumnos WHERE DNI=@DNI";

                    Eliminar.CommandText = query;

                    Eliminar.Parameters.AddWithValue("@DNI", DNIEliminar);

                    Eliminar.ExecuteNonQuery();

                    MessageBox.Show("Alumno eliminado correctamente.");

                    this.Close();
                }





            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hubo un error al eliminar: " + ex.Message);
            }
        }

    }
    }
