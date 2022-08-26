using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWinForm
{
    public partial class AltaAlumno : Form
    {
        Alumno alumnoCreado;
        public AltaAlumno()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.txb_nombre.Text;
            string apellido = this.txb_apellido.Text;
            int.TryParse(this.txb_dni.Text, out int dni);
            int.TryParse(this.txb_telefono.Text, out int telefono);
            string direccion = this.txb_direccion.Text;

            if (telefono <= 0 || string.IsNullOrEmpty(direccion))
            {
                alumnoCreado = new Alumno(nombre, apellido, dni);
            }
            else
            {
                alumnoCreado = new Alumno(nombre, apellido, dni, telefono, direccion);
            }
        }

        public Alumno GetAlumno()
        {
            return alumnoCreado;
        }
    }
}
