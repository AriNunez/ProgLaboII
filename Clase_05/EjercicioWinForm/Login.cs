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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario = txb_ingresoUsuario.Text.ToLower();
            string password = txb_ingresoPassword.Text;

            if(usuario == "pepe" && password == "RuFoSo")
            {
                MenuPrincipal frmMenuPrincipal = new MenuPrincipal(usuario);
                MessageBox.Show("Logueado!");
                frmMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto!");
            }
        }
    }
}
