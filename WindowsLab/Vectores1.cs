using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab
{
    public partial class Vectores1 : Form
    {
        int[] notas = new int[3];
        public Vectores1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            MessageBox.Show("El nombre del alumno es: " + nombre);

        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                int nota = Convert.ToInt32(Interaction.InputBox("Ingrese la nota"));
                notas[i] = nota;
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int suma = 0;

            foreach (var item in notas)
            {
               suma += item; 
            }

            MessageBox.Show(Convert.ToString(suma));


            int promedio = suma / notas.Length;
            int notaMaxima = notas.Max();
           

            if (promedio < 4)
            {
                MessageBox.Show("El promedio de las notas es: " + promedio + " La máxima nota es: " + notaMaxima + " Debe ir al recuperatorio");
            }
            else if (promedio >= 4 && promedio <= 7)
            {
                MessageBox.Show("El promedio de las notas es: " + promedio + " La máxima nota es: " + notaMaxima + " Bien!");

            }else if (promedio > 7)
            {
                MessageBox.Show("El promedio de las notas es: " + promedio + " La máxima nota es: " + notaMaxima + " Muy Bien!");
            }

        }
    }
}
