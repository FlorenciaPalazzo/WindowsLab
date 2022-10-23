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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtEdad.Text);

            bool edadCero= edad == 0;
            bool menor18 = edad < 18;
            bool mayor18 = (edad > 18) && (edad<60);
            bool mayor60 = edad >= 60;

            if(edad == 0 )
            {
                MessageBox.Show("ERROR");
            }
             else if(edad < 18)
            {
                MessageBox.Show("menor de edad");
            }else if ((edad > 18) && (edad < 60))
            {
                MessageBox.Show("mayor de edad");
            }else if (edad >= 60)
            {
                MessageBox.Show("adulto mayor");
            }

        }
    }
}
