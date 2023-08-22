using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activities
{
    public partial class PjActivities : Form
    {
        public PjActivities()
        {
            InitializeComponent();
        }

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TxtActividad.Text))
            {
                lstActividad.Items.Add(TxtActividad.Text);
                TxtActividad.Text = "";

            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor valido ");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar las actividades ", "Advertencia",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lstActividad.Items.Clear();
            }
            else
            {
                return;
            }

        }

        private void btnAñdir_Click(object sender, EventArgs e)
        {
            TxtActividad.Focus();
            btnAñdir.Enabled = true;
            btnEliminar.Enabled = true;
            TxtActividad.Enabled = true;
            btnGuardar.Enabled = true;
        }
    }
}
