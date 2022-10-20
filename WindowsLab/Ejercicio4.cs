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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            const double PI = 3.14;
            double radio = Convert.ToDouble(txtRadio.Text);

            MessageBox.Show("El área del cículo es: " + (radio * PI));

        }

        private void btnTrapecio_Click(object sender, EventArgs e)
        {
            double baseMayor = Convert.ToDouble(txtBaseMayor.Text); 
            double baseMenor = Convert.ToDouble(txtBaseMenor.Text);

            double altura = Convert.ToDouble(txtAltura.Text);
            double calculo = (((baseMayor + baseMenor) / 2) * altura);

            MessageBox.Show("El área del trapecio es: " + calculo);
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            double baseRectangulo = Convert.ToDouble(txtAlturaRectangulo.Text);
            double alturaRectangulo = Convert.ToDouble(txtBaseRectangulo.Text);

            MessageBox.Show("El área del rectangulo es: " + (baseRectangulo * alturaRectangulo));
        }

    }
}
