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
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string materiaFavorita = cmb_materiaFavorita.Text;

            if(Validar())
            {
                if(!string.IsNullOrEmpty(materiaFavorita))
                {

                    for (int i = 0; i < cmb_materiaFavorita.Items.Count; i++)
                    {
                        if(cmb_materiaFavorita.Text == cmb_materiaFavorita.Items[i].ToString())
                        {
                             FormSaludo frmSaludo = new FormSaludo(nombre,apellido,materiaFavorita); 
                             frmSaludo.Show();
                        }
                    }
                }
                

            }
        }

        private bool Validar()
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Se deben completar los siguientes campos:");

            if(String.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                esValido = false;
                sb.AppendLine("Nombre");
            }

            if(String.IsNullOrWhiteSpace(txt_apellido.Text))
            {
                esValido = false;
                sb.AppendLine("Apellido");
            }
            

            if(esValido == false)
            {
                MessageBox.Show(sb.ToString(),"Error",MessageBoxButtons.OK);
            }

            return esValido;
        }
        private void FormIngreso_Load(object sender, EventArgs e)
        {
            cmb_materiaFavorita.Items.Add("Programación I");
            cmb_materiaFavorita.Items.Add("Laboratorio de Computación I");
            cmb_materiaFavorita.Items.Add("Sistema de procesamiento de datos");
            cmb_materiaFavorita.Items.Add("Inglés I");
            cmb_materiaFavorita.Items.Add("Matemática");
            cmb_materiaFavorita.Items.Add("Programación II");
            cmb_materiaFavorita.Items.Add("Laboratorio de Computación II");
            cmb_materiaFavorita.Items.Add("Inglés II");
            cmb_materiaFavorita.Items.Add("Metodología de la investigación");
            cmb_materiaFavorita.Items.Add("Arquitectura y sistemas operativos");
            cmb_materiaFavorita.Items.Add("Estadística");
            cmb_materiaFavorita.Text = cmb_materiaFavorita.Items[0].ToString();
        }
    }
}
