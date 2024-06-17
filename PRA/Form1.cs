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
    public partial class PRA : Form
    {
        public PRA()
        {
            InitializeComponent();
        }

        DatosAlumno alumno = new DatosAlumno();
        private void PRA_Load(object sender, EventArgs e)
        {

        }
        public void cargaDatos_Click(object sender, EventArgs e)
        {
            Form2 Insert = new Form2();
            Insert.ShowDialog();
        }

        private void eliminarDatos_Click(object sender, EventArgs e)
        {
            Form3 Delete = new Form3();
            Delete.ShowDialog();
        }

        public void modificarDatos_Click(object sender, EventArgs e)
        {
            Form4 Modificar = new Form4();
            Modificar.ShowDialog();
        }

        public void salida_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(("¿Estás seguro de querer salir?"), "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes){
                Application.Exit();
            }
        }

        private void enlistarAlumno_Click(object sender, EventArgs e)
        {
            Form5 Enlistar1 = new Form5();
            Enlistar1.ShowDialog();
        }

        private void enlistarTodo_Click(object sender, EventArgs e)
        {
            Form6 EnlistarTodo = new Form6();
            EnlistarTodo.ShowDialog();
        }
    }
}
