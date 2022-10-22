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
    public partial class Vectores2 : Form
    {
        double[] precios= new double[3];
        public Vectores2()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            GetNumeros(precios);
            double suma= SumaNumeros(precios);
            MessageBox.Show($"La suma total de los precios es:{suma}");
        }

        private void GetNumeros(double[]precios)
        {
            for (int i = 0; i < precios.Length; i++)
            {
                double precio = Convert.ToDouble(Interaction.InputBox("Ingrese el precio"));
                precios[i] = precio;
            }
        }
        private double SumaNumeros(double[]precios)
        {
            double suma = 0;
            foreach (double precio in precios)
            {
                suma += precio;
            }
            return suma;
        }
    }
}

