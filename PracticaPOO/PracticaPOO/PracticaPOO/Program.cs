using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    //crear una clase cuenta con los metodos ingreso, reintegro y transferencia
    class Program
    {
        static void Main(string[] args)
        {

            Cuenta cuenta = new Cuenta("tatiana","123avb",100);
            Console.WriteLine("tu cuenta| nombre:{0}, cuenta:{1} con saldo:{2}", cuenta.NombreCliente, cuenta.NumeroCuenta, cuenta.Saldo);

            while (true)
            {
                Console.WriteLine("¿Que desea realizar?");
                Console.WriteLine("1. Ingresar dinero");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. transferencia");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        cuenta.IngresarSaldo();
                        break;
                    case 2:
                        cuenta.ReintegrarSaldo();
                        break;
                    case 3:
                        cuenta.TransferirSaldo();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
