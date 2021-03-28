using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("ingrese un valor para el contador");
            int cont = Convert.ToInt32(Console.ReadLine()); // contador 
            Contador contador1 = new Contador(cont);
            contador1.IncrementarContador();
            Console.WriteLine("incremento a  {0}", contador1.Cont);

            contador1.DecrementarContador();
            Console.WriteLine("decremento a  {0}", contador1.Cont);


            //Console.WriteLine(operador1.Suma(numero1, numero2));
        }
    }
}
