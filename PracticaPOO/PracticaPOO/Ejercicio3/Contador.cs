using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador
{
    public class Contador
    {
        private int cont;

        //constructor vacio
        public Contador()
        {
        }

        //constructor con parametros
        public Contador(int cont)
        {
            this.cont = cont;
        }

        //constructor copia


        //metodos
        public void IncrementarContador()
        {
            cont = cont + 1;
        }

        public void DecrementarContador()
        {
            cont = cont - 1;
            if (cont < 0)
            {
                cont = 0;
            }
        }

        // properties
        public int Cont
        {
            get { return cont; }
            set
            {
                if (value < 0)
                {
                    cont = value;
                }
                else
                {
                    cont = 0;
                }
            }
        }
    }
}
