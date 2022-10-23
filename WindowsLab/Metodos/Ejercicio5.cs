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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text;
            string tipo = txtTipo.Text;
            string sexo = txtSexo.Text;

            if (nombre == "Gabriela")
            {
                if (sexo == "Femenino")
                {

                    switch (tipo)
                    {
                        case "Administrador":
                            MessageBox.Show("Usuario: " + nombre + ", " + "Sexo: " + sexo + ", " + "Rol: " + tipo);
                            break;
                        case "Estandar":
                            MessageBox.Show("Rol incorrecto no es " + tipo);
                            break;
                        case "Invitados":
                            MessageBox.Show("Rol incorrecto no es " + tipo);
                            break;
                        default:
                           MessageBox.Show("Escriba el rol correcto");
                            break;
                    }
                }else { MessageBox.Show("Escriba el sexo correcto"); };
                
            }else { MessageBox.Show("Escriba el nombre correcto"); };
        }
    }
}
