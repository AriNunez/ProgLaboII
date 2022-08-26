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
    public partial class AltaJugador : Form
    {
        private Jugador jugadorCreado;

        public AltaJugador()
        {
            InitializeComponent();
        }

        //El get deberia ser una propiedad
        public Jugador GetJugador()
        {
            return jugadorCreado;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            EPosicion posSeleccionada = (EPosicion)this.cmb_posicion.SelectedItem;
            string nombre = this.txt_nombre.Text;
            string numeroCamiseta = this.txt_numeroCamiseta.Text;
            string posicion = this.txt_posicion.Text;
            int.TryParse(this.txt_partidosJugados.Text, out int partidosJugados);

            jugadorCreado = new Jugador(nombre,numeroCamiseta,posicion,partidosJugados);

            this.DialogResult = DialogResult.OK;
        }

        private void AltaJugador_Load(object sender, EventArgs e)
        {
            this.cmb_posicion.DataSource = Enum.GetValues(typeof(EPosicion));
            // agregar en la propiedad del cmb DropDownStyle como DropDownList
        }
    }
}
