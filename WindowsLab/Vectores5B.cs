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
    public partial class Vectores5B : Form
    {
        string[] provincias;
        double[,] temperaturas;
        double[,] tempMedia;

        double[] tempTrim;

        public Vectores5B()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            provincias = new string[4];
            temperaturas = new double[4, 3];

            for (int i = 0; i < provincias.Length; i++)
            {
                string provincia = Interaction.InputBox($"Ingrese el nombre de la provincia nro {i+1}");
                provincias[i] = provincia;

                for (int j = 0; j < temperaturas.GetLength(1); j++)
                {
                    double temperatura = Convert.ToInt32(Interaction.InputBox($"Ingrese la temperatura de la provincia nro {j+1}"));
                    temperaturas[i,j] = temperatura;
                }
            }
        }

        private void ImprimirTemp()
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                MessageBox.Show($"Provincia: {provincias[i]}");
                for (int j = 0; j < temperaturas.GetLength(1); j++)
                {
                    MessageBox.Show($" Temperaturas: {temperaturas[i,j]}");
                }
            }
        }

        private void CalculoTempMedia()
        {
            
            tempTrim = new double[4];

            for (int i = 0; i < temperaturas.GetLength(0); i++)
            {
                double suma = 0;

                for (int j = 0; j < temperaturas.GetLength(1); j++)
                {
                    suma += temperaturas[i, j];
                }
                tempTrim[i] = suma / tempTrim.Length;
            }
        }

        private void ImprimirTempTrim()
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                MessageBox.Show($"Temperatura trimestral promedio de {provincias[i]} es de {tempTrim[i]}");

            }
        }

        private void MayorTemperatura()
        {
            double mayor = tempTrim[0];
            string prov = provincias[0];

            for (int i = 0; i < provincias.Length; i++)
            {
                if (tempTrim[i]> mayor)
                {
                    mayor = tempTrim[i];
                    prov = provincias[i];
                        
                }
            }
            MessageBox.Show($"La provincia con mayor temperatura trimestrarl es: {prov} con {mayor} grados");

        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            Vectores5B ma = new Vectores5B();
            ma.Cargar();
            ma.ImprimirTemp();
            ma.CalculoTempMedia();
            ma.ImprimirTempTrim();
            ma.MayorTemperatura();
        }
    }
}
