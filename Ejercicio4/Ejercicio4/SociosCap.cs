using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class SociosCap : Form
    {
        Double Socio1, Socio2, Socio3;

        public SociosCap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            


        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Ventana1.Text) && !String.IsNullOrWhiteSpace(Ventana2.Text)
                && !String.IsNullOrWhiteSpace(Ventana3.Text) && double.TryParse(Ventana1.Text, out double Socio1)
                 && double.TryParse(Ventana2.Text, out double Socio2) && double.TryParse(Ventana3.Text, out double Socio3))
            {
                double resultado = Socio1 + Socio2 + Socio3;
                Capital.Text = Convert.ToString(resultado);

                double porcen1 = (Socio1 * 100) / resultado;
                double porcen2 = (Socio2 * 100) / resultado;
                double porcen3 = (Socio3 * 100) / resultado;

                Porce1.Text = Convert.ToString(porcen1);
                Porce2.Text = Convert.ToString(porcen2);
                Porce3.Text = Convert.ToString(porcen3);

                Ventana1.Text = "";
                Ventana2.Text = "";
                Ventana3.Text = "";


            }
            else
            {
                MessageBox.Show("Por favor, inrese un dato vaido");
                Capital.Text = "";
            }

            

        }

        private void Ventana1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!String.IsNullOrWhiteSpace(Ventana1.Text))
                {




                    Socio1 = Convert.ToDouble(Ventana1.Text);
                    if (Socio1 == 0)
                    {

                        MessageBox.Show("Error ingrese un dato valido");
                        Ventana1.Text = "";
                        Socio1 = 0;


                    }

                }
                else
                {
                    Socio1 = 0;

                }
            } catch (FormatException ex)
            {
                MessageBox.Show("ERROR DATO INVALIDO");
                Ventana1.Text = "";
            }
        }

        private void Ventana2_TextChanged(object sender, EventArgs e)
        {
            try { 
            if (!String.IsNullOrWhiteSpace(Ventana2.Text))
            {


                

                    Socio2 = Convert.ToDouble(Ventana2.Text);
                    if (Socio2 <= 0)
                    {
                        MessageBox.Show("Error ingrese un dato valido");
                        Ventana2.Text = "";
                    }
                
            }
            else
            {
                Socio2 = 0;
            }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR DATO INVALIDO");
                Ventana2.Text = "";
            }

        }

        private void Ventana3_TextChanged(object sender, EventArgs e)
        {
            try { 

            if (!String.IsNullOrWhiteSpace(Ventana3.Text))
            {


                

                    Socio3 = Convert.ToDouble(Ventana3.Text);
                    if (Socio3 <= 0)
                    {
                        MessageBox.Show("Error ingrese un dato valido");
                        Ventana3.Text = "";
                    }
                
            }
            else
            {
                Socio3 = 0;
            }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR DATO INVALIDO");
                Ventana3.Text = "";
            }
        }

        private void Capital_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
