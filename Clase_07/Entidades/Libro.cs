using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;

        public string this[int i]
        {
            get 
            {
                if(paginas is not null && i >= 0)
                {
                    return paginas[i];
                }

                return string.Empty;
            }

            set
            {
                if(paginas is not null && i >= 0)
                {
                    if(i < paginas.Count)
                    {
                        paginas[i] = value;
                    }
                    else
                    {
                        paginas.Add(value);
                    }
                }
            }
        }

        public Libro()
        {
            paginas = new List<string>();
        }
    }
}
