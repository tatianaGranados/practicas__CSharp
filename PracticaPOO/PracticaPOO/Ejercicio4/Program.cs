using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Fraccion fraccion1 = new Fraccion();
            //Fraccion fraccion2 = new Fraccion();

            while (true)
            {
                Console.WriteLine("Operador de fracciones: ¿Que desea realizar?");

                Console.WriteLine("1. sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                int select = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduzca fraccion 1");
                string fraccion1 = Console.ReadLine();
                string fraccion2 = Console.ReadLine();

                int num = fraccion1[0];
                int den = fraccion1[2];

                switch (select)
                {
                    case 1:

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
