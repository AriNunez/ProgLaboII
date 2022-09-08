using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMiForm : Form
    {
        public FrmMiForm()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            if(!string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show($"Hola {nombre}!");
            }
            else
            {
                MessageBox.Show("ERROR!","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSaludarForm_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            FrmSaludar frmSaludar = new FrmSaludar(nombre);

            DialogResult resultado = frmSaludar.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                lblAviso.Text = "Salio todo OK!";
            }
            else
            {
                lblAviso.Text = "Salio todo MAL!";
            }
        }
    }
}
