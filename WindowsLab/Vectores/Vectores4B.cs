using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;
namespace WindowsLab
{
   
public partial class Vectores4B : Form
    {

        private string[] operarios;
        private int[,] sueldos;
        private int[] sueldosTot;



        public Vectores4B()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            operarios = new string[4];
            sueldos = new int[4, 3];

            for (int i = 0; i < operarios.Length; i++)
            {
                string operario = Interaction.InputBox($"Ingrese el nombre del operario {i+1} ");
                operarios[i] = operario;

                for (int j = 0; j < sueldos.GetLength(1); j++)
                {
                    int sueldo = Convert.ToInt32(Interaction.InputBox($"Ingrese el valor del sueldo nro: {j+1}"));
                    sueldos[i, j] = sueldo;   
                }
            }
        }


        public void CalcularSueldos()
        {
            sueldosTot = new int[4];

            for (int i = 0; i < sueldos.GetLength(0); i++)
            {
            int suma = 0;
                for (int j = 0; j < sueldos.GetLength(1); j++)
                {
                    suma = suma + sueldos[i, j];
                }
                sueldosTot[i] = suma;
            }
        }

        private void ImprimirTotalPagado()
        {
            for (int i = 0; i < sueldosTot.Length; i++)
            {
                MessageBox.Show($"Nombre:{operarios[i]}\n Sueldo Total: {sueldosTot[i]} ");
            }
        }

        private void EmpleadoMayorSueldo()
        {
            string nombre = operarios[0];
            int sueldoMayor = sueldosTot[0];

            for (int i = 0; i < sueldosTot.Length; i++)
            {
                if (sueldosTot[i]> sueldoMayor)
                {
                    sueldoMayor = sueldosTot[i];
                    nombre = operarios[i];
                }
            }
            MessageBox.Show($"EL operario con mayor sueldo es: {nombre} con {sueldoMayor}pesos");
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            Vectores4B ma = new Vectores4B();
            Cargar();
            CalcularSueldos();
            ImprimirTotalPagado();
            EmpleadoMayorSueldo();
        }
    }
}


