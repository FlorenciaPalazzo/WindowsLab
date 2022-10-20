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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            

            for (int i = 1; i <= 12; i++)
            {
                MessageBox.Show(num + "x" + i + "=" + (num * i));
             
            }

        }
    }
}
