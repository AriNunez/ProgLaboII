using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioI01
{
    public partial class FormSaludo : Form
    {
        public FormSaludo(string nombre,string apellido,string materiaFavorita)
        {
            InitializeComponent();
            lbl_mensaje.Text = $"Soy {nombre} {apellido} y mi materia favorita es {materiaFavorita}.";
        }

        private void Saludo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
