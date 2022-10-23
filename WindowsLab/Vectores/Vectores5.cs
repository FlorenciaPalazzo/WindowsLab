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
    public partial class Vectores5 : Form
    {
        string[] provincias;
        double[] temp1;
        double[] temp2;
        double[] temp3;
        double[] temp4;
        double[] temperaturas;

        public Vectores5()
        {
            InitializeComponent();
        }

        public void GetNombres(string[]provincias)
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                string provincia = Interaction.InputBox("Ingrese el nombre de la provincia");
                provincias[i] = provincia;
            }
        }

        public void GetTemperaturas(double[] temperaturas)
        {
            for (int i = 0; i < temperaturas.Length; i++)
            {
                double temperatura = Convert.ToDouble(Interaction.InputBox("Ingrese la temperatura media trimestral"));
                temperaturas[i] = (temperatura);
            }
        }

        public double MediaTemperatura(double[] temperaturas)
        {
            double suma = 0;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                suma += temperaturas[i];

            }
            return suma/ temperaturas.Length;
        }


        private void Mostrar(string[] provincias, double[]temp)
        {
            double t1 = MediaTemperatura(temp1);
            double t2 = MediaTemperatura(temp2);
            double t3 = MediaTemperatura(temp3); 
            double t4 = MediaTemperatura(temp4);

            temp = new double[4] { t1, t2, t3, t4 };
            double tempMax = 0;
            string provincia = "";

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i]> tempMax)
                {
                    tempMax = temp[i];
                    provincia = provincias[i]; 
                }
            }

            MessageBox.Show($"La temperatura maxima es de la provincia de {provincia} con {tempMax}grados "); 
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            provincias = new string[4];
            temp1 = new double[3];
            temp2 = new double[3];
            temp3 = new double[3];
            temp4 = new double[3];

            GetNombres(provincias);
            GetTemperaturas(temp1);
            GetTemperaturas(temp2);
            GetTemperaturas(temp3);
            GetTemperaturas(temp4);

            Mostrar(provincias,temperaturas);
            
        }
    }
}
