using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C01_El_Temporizador
{
    public class Temporizador
    {
        public delegate void DelegadoTemporizador();

        public event DelegadoTemporizador TiempoCumplido;

        private int intervalo;

        public int Intervalo
        {
            get { return intervalo; }
        }

        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;
        }


        public void DetenerTemporizador()
        {

        }
        public void IniciarTemporizador()
        {
            CorrerTiempo();
        }
        private void CorrerTiempo()
        {
            if(TiempoCumplido is not null)
            {
                TiempoCumplido.Invoke();
                Thread.Sleep(intervalo);
            }
        }
    }
}
