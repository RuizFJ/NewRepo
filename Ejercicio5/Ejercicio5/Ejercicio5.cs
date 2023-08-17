using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(VentanaC.Text) && !String.IsNullOrWhiteSpace(VentanaP.Text)
                && double.TryParse(VentanaC.Text, out double cantidad) && double.TryParse(VentanaP.Text, out double precio))
            {
                double resultado = (precio * 0.89) * cantidad;
                VentanaT.Text = Convert.ToString(resultado);
            }
            else
            {
                VentanaT.Text = "";
                MessageBox.Show("Por favor, ingrese datos validos");
            }
        }

        private void VentanaP_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (!String.IsNullOrWhiteSpace(VentanaP.Text))
                {
                    double precio = Convert.ToDouble(VentanaP.Text);
                    if (precio == 0)
                    {
                        MessageBox.Show("El precio debe ser mayor a 0");
                        VentanaP.Text = "";
                    }
                    else
                    {
                        precio = 0;
                    }
                }
                else
                {

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error el dato ingresado no es numerico");
                VentanaP.Text = "";
            }
        }

        private void VentanaC_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!String.IsNullOrWhiteSpace(VentanaC.Text))
                {
                    double cantidad = Convert.ToDouble(VentanaC.Text);
                    if (cantidad == 0)
                    {
                        MessageBox.Show("El precio debe ser mayor a 0");
                        VentanaC.Text = "";
                    }
                    else
                    {
                        cantidad = 0;
                    }
                }
                else
                {

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error el dato ingresado no es numerico");
                VentanaC.Text = "";
            }
        }
    }
}
