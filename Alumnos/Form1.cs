using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        private Alumnos alumns = new Alumnos();
        private int sumaNotas = 0;
        public Form1()
        {
            InitializeComponent();
            txtLista.Text = "";
        }

        /// <summary>
        /// Metodo para funcionar el programa, añade los datos de los cuadros de texto a una lista
        /// de alumnos, y posteriormene añade estos a un cuadro de texto y realiza calculos con ellos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardaAlum_Click(object sender, EventArgs e)
        {
            string aprob = "Aprobado";

            Alumno alum = new Alumno();

            alum.Nombre = txtAlumno.Text;
            alum.Nota = int.Parse(txtNota2.Text);

            alumns.AgregarAlumno(alum);

            txtAlumno.Clear();
            txtNota2.Value = 0;

            if(alum.Aprobado)
                aprob="Aprobado";
            else
                aprob="Suspendido";


            txtLista.Items.Add(txtLista.Text + alum.Nombre + "\t" + "Nota: " + Convert.ToString(alum.Nota) + "\t" + aprob);

            sumaNotas = sumaNotas + alum.Nota; 

            txtMedia.Text = Convert.ToString(alumns.MediaNotas(sumaNotas)); 

        }
    }
}
