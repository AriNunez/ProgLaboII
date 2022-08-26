using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWindowsForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_loguear_Click(object sender, EventArgs e)
        {
            string usuario = this.txb_ingresoUsuario.Text.ToLower();
            string password = this.txb_ingresoPassword.Text;

            if(true)
            {
                MenuPrincipal frmMenuPrin = new MenuPrincipal();
                MessageBox.Show("Logueado!!");
                this.BackColor = Color.Green;
                frmMenuPrin.Show();
                this.Hide();
            }

            //if (usuario == "pepe" && password == "RuFoSo")
            //{
            //    MessageBox.Show("Logueado");
            //    this.BackColor = Color.Green;
            //}
            //else
            //{
            //    MessageBox.Show("Usuario y password incorrectos!");
            //    this.BackColor = Color.Red;
            //}
        }


        //private void btn_mensaje_Click(object sender, EventArgs e)
        //{
        //    //TODO: 1 - Detectar el tesxto del TEXTBOX
        //    string mensaje = this.txb_ingresoUsuario.Text;
        //    //TODO: 2 - Reemplazar el texto en el LABE
        //}
    }
}
