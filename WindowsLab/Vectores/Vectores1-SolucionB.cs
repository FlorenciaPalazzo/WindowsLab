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
        string[] alumnos ;
       
        double[] notas1 ;
        double[] notas2 ;
        double[] notas3 ;
        double[] notas4 ;
        double[] promedio ;
        double[] notaMax ;
        public Vectores1A()
        {
            InitializeComponent();
        }

       

        //Toma Nombres
        private void GetNombres(string[]alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
               alumnos[i] = Interaction.InputBox("Ingrese el nombre del alumno");

            }
        }

        //Toma notas
        private void GetNotas(double[] notas)
        {

            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = Convert.ToDouble(Interaction.InputBox("Ingrese la nota del alumno"));
            
            }

        }
        //Devuelve mayor nota
        private double  MayorNota(double[]notas)
        {
            double mayor = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if(mayor < notas[i])
                {
                    mayor = notas[i];   
                }
            }
            return mayor;
        }

        //Devuelve el promedio
        private double CalculoPromedio(double[]notas)
        {
            double suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }
            return suma/ notas.Length;
        }

        private void Mostrar(string[]alumnos, double[]notaMax, double[]promedio)
        {
            double promedio1 = CalculoPromedio(notas1);
            double promedio2 = CalculoPromedio(notas2);
            double promedio3 = CalculoPromedio(notas3);
            double promedio4 = CalculoPromedio(notas4);

            double notaMax1 = MayorNota(notas1);
            double notaMax2 = MayorNota(notas2);
            double notaMax3 = MayorNota(notas3);
            double notaMax4 = MayorNota(notas4);

            promedio = new double[] { promedio1, promedio2, promedio3, promedio4 };
            notaMax= new double[] { notaMax1, notaMax2, notaMax3,notaMax4 };

            for (int i = 0; i < alumnos.Length; i++)
            {
                if (promedio[i]<4)
                {
                    MessageBox.Show($"Promedio de {alumnos[i]}: {promedio[i]}\n Mayor nota: {notaMax[i]}\n Debes ir a recuperatorio");
                       
                }else if(promedio[i]>=4 && promedio[i] <= 7)
                {
                    MessageBox.Show($"Promedio de {alumnos[i]}: {promedio[i]}\n Mayor nota: {notaMax[i]}\n Bien!");

                } else 
                {
                    MessageBox.Show($"Promedio de {alumnos[i]}: {promedio[i]}\n Mayor nota: {notaMax[i]}\n Muy Bien!");
                }
            }
        }

        //Eventos
       
        private void btnCargar_Click(object sender, EventArgs e)
        {
          alumnos = new string[4];
          notas1=  new double[3];
          notas2 = new double[3];
          notas3 = new double[3];
          notas4 = new double[3];

          GetNombres(alumnos);
          GetNotas(notas1);
          GetNotas(notas2);
          GetNotas(notas3);
          GetNotas(notas4);

          Mostrar(alumnos, notaMax, promedio);

        }

       
    }
}

