namespace Conversion_Ejer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VentanaResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {


                if (Metros.SelectedItem.ToString() == "Metros" && ListaC.SelectedItem.ToString() == "Centimetros" && !String.IsNullOrWhiteSpace(VentanaCantidad.Text))
                {

                    int resultado = int.Parse(VentanaCantidad.Text) * 100;
                    VentanaResult.Text = Convert.ToString(resultado);
                }

                if (Metros.SelectedItem.ToString() == "Metros" && ListaC.SelectedItem.ToString() == "Pulgadas" && !String.IsNullOrWhiteSpace(VentanaCantidad.Text))
                {
                    double resultado = double.Parse(VentanaCantidad.Text) * 39.37;
                    VentanaResult.Text = Convert.ToString(resultado);
                }

                if (Metros.SelectedItem.ToString() == "Metros" && ListaC.SelectedItem.ToString() == "Pies" && !String.IsNullOrWhiteSpace(VentanaCantidad.Text))
                {
                    double resultado = double.Parse(VentanaCantidad.Text) * 3.281;
                    VentanaResult.Text = Convert.ToString(resultado);
                }

                if (Metros.SelectedItem.ToString() == "Metros" && ListaC.SelectedItem.ToString() == "Yardas" && !String.IsNullOrWhiteSpace(VentanaCantidad.Text))
                {
                    double resultado = double.Parse(VentanaCantidad.Text) * 1.094;
                    VentanaResult.Text = Convert.ToString(resultado);
                }
                else if (String.IsNullOrWhiteSpace(VentanaCantidad.Text))
                {
                    MessageBox.Show("Por favor, ingrese un dato válido o rellene el espacio en blanco");
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error dato ingresado invalido");
                VentanaCantidad.Text = "";



            }
        }

        private void VentanaCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!String.IsNullOrWhiteSpace(VentanaCantidad.Text))
                {
                    double resultado = double.Parse(VentanaCantidad.Text);
                    if (resultado <= 0)
                    {
                        MessageBox.Show("La cantidad tiene que ser mayor a cero");
                        VentanaCantidad.Text = "";
                    }
                }
            } catch (FormatException)
            {
                MessageBox.Show("Dato invalido");
                VentanaCantidad.Text = "";
            }
        }
    }
}