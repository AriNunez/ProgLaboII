using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace EjercicioI02
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            lstPais.Items.AddRange(new String[] { "Argentina", "Chile", "Uruguay" });
            numEdad.Maximum = 120;
            numEdad.Minimum = 0;
            rdbMasculino.Checked = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int edad = (int)numEdad.Value;
            string genero = ComprobarGenero();
            string pais = (string)lstPais.SelectedItem;
            string[] cursos = ComprobarCursos();
            Ingresante ingresante;

            if(!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(pais))
            {
                if(rdbMasculino.Checked || rdbFemenino.Checked || rdbNoBinario.Checked)
                {
                    if(cursos is not null)
                    {
                        ingresante = new Ingresante(nombre, direccion, genero, pais, cursos, edad);
                        MessageBox.Show(ingresante.Mostrar(), "", MessageBoxButtons.OK);
                    }
                }
            }
            
        }

        private string ComprobarGenero()
        {
            string genero = string.Empty;

            foreach (RadioButton item in grbGenero.Controls)
            {
                if(item.Checked)
                {
                    genero = item.Text;
                }

            }

            //if(rdbMasculino.Checked)
            //{
            //    genero = rdbMasculino.Text;
            //}
            //else
            //{
            //    if (rdbFemenino.Checked)
            //    {
            //        genero = rdbFemenino.Text;
            //    }
            //    else
            //    {
            //        if (rdbNoBinario.Checked)
            //        {
            //            genero = rdbNoBinario.Text;
            //        }
            //    }
            //}

            return genero;
        }

        private string[] ComprobarCursos()
        {
            string[] cursos = new string[grbCursos.Controls.Count];
            int i = 0;

            foreach (CheckBox item in grbCursos.Controls)
            {
                if(item.Checked)
                {
                    cursos[i] = item.Text;
                }
                i++;
            }

            //if(chkCSharp.Checked)
            //{
            //    cursos[0] = chkCSharp.Text;
            //}            
            //if(chkCPlus.Checked)
            //{
            //    cursos[1] = chkCPlus.Text;
            //}            
            //if(chkJavaScript.Checked)
            //{
            //    cursos[2] = chkJavaScript.Text;
            //}

            return cursos;
        }
    }
}
