using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Tienda_Ejer1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(VentanaCantidad.Text))
                {
                    double cantidad = double.Parse(VentanaCantidad.Text);
                    if (cantidad <= 0)
                    {
                        MessageBox.Show("Error el dato debe ser mayor a cero");
                        VentanaCantidad.Text = "";
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error dato invalido, ingrese uno valido");
                VentanaCantidad.Text = "";
            }


        }

        private void Canti_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(VentanaPrecio.Text))
                {
                    double precio = double.Parse(VentanaPrecio.Text);
                    if (precio <= 0)
                    {
                        MessageBox.Show("Error el dato debe ser mayor a cero");
                        VentanaPrecio.Text = "";
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error dato invalido, ingrese uno valido");
                VentanaPrecio.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tot_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {

            int total2 = Convert.ToInt32(VentanaCantidad.Text) * Convert.ToInt32(VentanaPrecio.Text);
            VentanaTotal.Text = Convert.ToString(total2);




        }

    }
}