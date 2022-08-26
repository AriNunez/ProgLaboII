using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        private Persona[] personas;

        public Aula()
        {
            personas = new Persona[3];
        }

        public static bool operator +(Persona p,Aula a)
        {
            if(p != a)
            {
                for (int i = 0; i < a.personas.Length; i++)
                {
                    if (a.personas[i] is null)
                    {
                        a.personas[i] = p;
                        return true;
                    }
                }
            }
            
            return false;
        }

        public static bool operator ==(Persona p, Aula a)
        {
            for (int i = 0; i < a.personas.Length; i++)
            {
                if (a.personas[i] == p)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            return false;
        }

        public static bool operator !=(Persona p, Aula a)
        {
            return !(p == a);
        }
    }
}
