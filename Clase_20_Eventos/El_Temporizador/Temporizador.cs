using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace El_Temporizador
{
    public class Temporizador
    {
        public delegate void DelegadoTemporizador();

        public event DelegadoTemporizador TiempoCumplido;

        private int intervalo;
        Task hilo;
        private CancellationToken cancelToken;
        private CancellationTokenSource cancelTokenSource;

        public int Intervalo
        {
            get { return intervalo; }
        }

        public bool EstaActivo
        {
            get { return hilo is not null && hilo.Status == TaskStatus.Running; }
        }

        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;
        }


        public void DetenerTemporizador()
        {
            if (EstaActivo)
            {
                cancelTokenSource.Cancel();
            }
        }
        public void IniciarTemporizador()
        {
            if(!EstaActivo)
            {
                cancelTokenSource = new CancellationTokenSource();
                cancelToken = cancelTokenSource.Token;
                hilo = new Task(CorrerTiempo);
                hilo.Start();
            }
        }
        private void CorrerTiempo()
        {
            if (TiempoCumplido is not null && !cancelToken.IsCancellationRequested)
            {
                TiempoCumplido.Invoke();
                Thread.Sleep(intervalo);
            }
        }
    }
}
