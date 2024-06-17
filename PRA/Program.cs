using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PRA
{
    class DatosAlumno
    {
        public string Nombre;
        public string DNI;
        public int Legajo;
        public bool Libre;
        public string Materia;
        public int Inasistencias;
        public int Nota1erParcial;
        public int Nota2doParcial;
        public int NotaFinal;
        public bool MateriaAprobada;
    }
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PRA());
        }
    }
}
