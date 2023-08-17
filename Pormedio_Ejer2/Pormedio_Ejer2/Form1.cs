using System;
using System.Net.NetworkInformation;

namespace Pormedio_Ejer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)

        {
            try
            {

                double nota1 = double.Parse(Ventana1.Text);
                double nota2 = double.Parse(Ventana2.Text);
                double nota3 = double.Parse(Ventana3.Text);

                double suma = (nota1 + nota2 + nota3) / 3;
                Total.Text = Convert.ToString(suma);


            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error dato invalido");
                Total.Text = "";

            }


        }

        private void Ventana1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Ventana1.Text))
                {

                    double nota1 = double.Parse(Ventana1.Text);
                    if (nota1 < 0 || nota1 > 100)
                    {
                        MessageBox.Show("La nota debe de estar entre 0-100");
                        Ventana1.Text = "";
                    }

                }

            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Error dato invalido");
                Ventana1.Text = "";

            }

        }

        private void Ventana2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Ventana2.Text))
                {

                    double nota2 = Convert.ToDouble(Ventana2.Text);
                    if (nota2 < 0 || nota2 > 100)
                    {
                        MessageBox.Show("La nota debe de estar entre 0-100");
                        Ventana2.Text = "";
                    }

                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error dato invalido");
                Ventana2.Text = "";
            }

        }

        private void Ventana3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Ventana3.Text))
                {

                    double nota3 = Convert.ToDouble(Ventana3.Text);
                    if (nota3 < 0 || nota3 > 100)
                    {
                        MessageBox.Show("La nota debe de estar entre 0-100");
                        Ventana3.Text = "";
                    }

                }


            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error dato invalido");
                Ventana3.Text = "";
            }
        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}