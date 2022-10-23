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

namespace WindowsLab.Vectores
{
    public partial class Vectores4A : Form
    {
        int[] edades;
        string[] nombres; 
        public Vectores4A()
        {
            InitializeComponent();
        }

        private void GetNombres(string[]nombres)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingrese el nombre");
                nombres[i] = nombre; 
            }
        }

        private void GetEdades(int[] edades)
        {
            for (int i = 0; i < edades.Length; i++)
            {
                int edad = Convert.ToInt32(Interaction.InputBox("Ingrese la edad"));
                edades[i] = edad;
            }
        }

        private void Mostrar(string[] name, int[]age)  //name y age es un parametro cualquiera que hace referencia 
                                                          // para cuando se invoque el metodo
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (age[i] >= 18)
                {

                    MessageBox.Show($"Nombre: {name[i]} \n Edad: {age[i]} ");
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            nombres = new string[3];
            edades = new int[3];

            GetNombres(nombres);
            GetEdades(edades);

            Mostrar(nombres,edades);

        }
    }
}
