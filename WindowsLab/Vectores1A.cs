using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab
{
    public partial class Vectores1A : Form
    {
        string[] alumnos = new string[4];
        int[] nota1 = new int[3];
        int[] nota2 = new int[3];
        int[] nota3 = new int[3];
        int[] nota4 = new int[3];

        public Vectores1A()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            GetAlumnos(alumnos);
            GetNotas(nota1);
            GetNotas(nota2);
            GetNotas(nota3);
            GetNotas(nota4);
        }


     

        private void GetAlumnos(string[] nombres)
        {
            for (int i = 1; i < nombres.Length; i++)
            {
                nombres[i] = Interaction.InputBox("Ingrese el nombre del alumno");

            }
        }

        private void GetNotas(int[] notas)
        {

            for (int i = 1; i < notas.Length; i++)
            {
                notas[i] = Convert.ToInt32(Interaction.InputBox("Ingrese el nombre del alumno"));
            }

        }

        private void btnResultados_Click(object sender, EventArgs e)
        {

        }
        private int GetPromedio(int[] notas)
        {
            int suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }
            return suma / notas.Length;
        }



        
    }
}
