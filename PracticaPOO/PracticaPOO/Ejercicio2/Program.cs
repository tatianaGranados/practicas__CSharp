using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Libro libro = new Libro("Romeo y Julieta","William S",10,5);
            while (true)
            {
                Console.WriteLine("¿Que desea realizar?");
                Console.WriteLine("1. Agregar un libro");
                Console.WriteLine("2. Prestar un libro");
                Console.WriteLine("3. Devolver un libro");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        libro.Prestamo();
                        break;
                    case 2:
                        libro.Devolucion();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
