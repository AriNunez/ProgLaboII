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

namespace UI
{
    public partial class MenuPrincipal : Form
    {
        List<Jugador> jugadores;
        public MenuPrincipal()
        {
            InitializeComponent();
            jugadores = new List<Jugador>();
        }

        private void agregarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaJugador frmAltaJugador = new AltaJugador();
            DialogResult resultado = frmAltaJugador.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                jugadores.Add(frmAltaJugador.GetJugador());
                this.rtb_informacion.Text += frmAltaJugador.GetJugador().Mostrar() + "\n";
            }
            else
            {
                MessageBox.Show("Carga Cancelada!");
                MessageBox.Show("Carga Cancelada!");
            }
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }


}
