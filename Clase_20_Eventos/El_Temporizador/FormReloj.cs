using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Temporizador
{
    public partial class FormReloj : Form
    {
        private Temporizador temporizador;
        public FormReloj()
        {
            InitializeComponent();
            temporizador = new Temporizador(1000);
            temporizador.TiempoCumplido += AsignarHora;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            temporizador.IniciarTemporizador();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            temporizador.DetenerTemporizador();
        }

        private void AsignarHora()
        {
            if(lblReloj.InvokeRequired)
            {
                Action asignarHora = AsignarHora;
                lblReloj.Invoke(asignarHora);
            }
            else
            {
                lblReloj.Text = DateTime.Now.ToString("dd/MM//yyyy HH:mm:ss");
            }
        }
    }
}
