using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;

        private short tinta;
        private ConsoleColor color;

        public Boligrafo(short tinta,ConsoleColor color)
        {
            SetTinta(tinta);
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            short tintaResultante = GetTinta();
            
            if(tinta < 0)
            {
                //tintaResultante -= tinta;
                for (int i = 0; i > tinta; i--)
                {
                    tintaResultante--;
                    if(tintaResultante == 0)
                    {
                        break;
                    }
                }
            }
            else
            {
                if(tinta > 0)
                {
                    for (int i = 0; i < tinta; i++)
                    {
                        tintaResultante++;
                        if (tintaResultante == 100)
                        {
                            break;
                        }
                    }
                }
            }

            if(tintaResultante >= 0 && tintaResultante <= cantidadTintaMaxima)
            {
                this.tinta = tintaResultante;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short tintaDisponible = GetTinta();
            StringBuilder sb = new StringBuilder("");

            if(gasto < 0)
            {
                for (int i = 0; i < tintaDisponible; i++)
                {
                    sb.Append("*");
                }
                dibujo = sb.ToString();
                SetTinta(gasto);
                return true;
            }
            dibujo = sb.ToString();
            return false;
        }
    }
}
