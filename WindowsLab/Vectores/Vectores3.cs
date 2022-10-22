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

namespace WindowsLab.Vectores
{
    public partial class Vectores3 : Form
    {
        string[] nombres;
        double[] sueldo1;
        double[] sueldo2;
        double[] sueldo3;
        double[] sueldo4;
        double[] suma;
        public Vectores3()
        {
            InitializeComponent();
        }

        private void GetNombres(string[] nombres)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingrese el nombre del Operario");
                nombres[i] = nombre;
            }
        }

        private void GetSueldo(double[] sueldos)
        {
            for (int i = 0; i < sueldos.Length; i++)
            {
                double sueldo = Convert.ToDouble(Interaction.InputBox("Ingrese el sueldo"));
                sueldos[i] = sueldo;
            }

        }

        private double SumaSueldos(double[]sueldos)
        {
            double suma = 0;
            foreach (var item in sueldos)
            {
                suma += item;
            }
            return suma;
        }

        private void Mostrar(string[]nombres, double[]suma)
        {
            double totalSueldo1 = SumaSueldos(sueldo1);
            double totalSueldo2 = SumaSueldos(sueldo2);
            double totalSueldo3 = SumaSueldos(sueldo3);
            double totalSueldo4 = SumaSueldos(sueldo4);

            suma = new double[] { totalSueldo1, totalSueldo2, totalSueldo3, totalSueldo4 };
            double maxSueldo = suma[0];

            string NombreDestacado = "";


            for (int i = 0; i < suma.Length; i++)
            {
                if (suma[i] > maxSueldo)
                {
                    maxSueldo = suma[i];
                    NombreDestacado = nombres[i];

                }
            }

            MessageBox.Show($"El operario que gano mejor en los ultimos 3 meses fue: {NombreDestacado}");

        }   
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            nombres = new string[4];
            sueldo1 = new double[3];
            sueldo2 = new double[3];
            sueldo3 = new double[3];
            sueldo4 = new double[3];


            GetNombres(nombres);
            GetSueldo(sueldo1);
            GetSueldo(sueldo2);
            GetSueldo(sueldo3);
            GetSueldo(sueldo4);

            Mostrar(nombres, suma);

        }
    }
}
