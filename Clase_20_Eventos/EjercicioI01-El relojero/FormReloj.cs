using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C01_El_Temporizador

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

        private void AsignarHora()
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM//yyyy HH:mm:ss");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            temporizador.IniciarTemporizador();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {

        }

        private void FormReloj_Load(object sender, EventArgs e)
        {

        }
    }
}
