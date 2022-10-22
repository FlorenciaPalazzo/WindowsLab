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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void btnMostrarNombre_Click(object sender, EventArgs e)
        {
            if (dateFecha.Value.Date == DateTime.Now.Date)
            {
                Imprimir(txtNombre.Text,txtApellido.Text);
            }
            else 
            {
                Imprimir(txtNombre.Text, txtApellido.Text, dateFecha.Value);
            }            
        }

        private void Imprimir(string nombre, string apellido)
        {
            MessageBox.Show("El nombre y el apellido es: " + nombre + " " + apellido);
        }

        private void Imprimir(string nombre, string apellido, DateTime fecha)
        {
            int anioNacimiento= fecha.Year;

            int edad = DateTime.Today.Year - anioNacimiento;

            MessageBox.Show("El nombre y el apellido es: " + nombre + " " + apellido +" "+ "y la edad "+ edad );
        }

    }
}
