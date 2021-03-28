using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Cuenta
    {
        
        
        public Cuenta(string nombreCliente, string numeroCuenta, int saldo)
        {
            NombreCliente = nombreCliente;
            NumeroCuenta = numeroCuenta;
            Saldo = saldo;
        }

        public Cuenta()
        {
            NombreCliente = "null";
            NumeroCuenta = "null";
            Saldo = 0;
        }

        public string NombreCliente { get; set; }
        public string NumeroCuenta { get; set;  }
        public int Saldo { get; set; }

        public void IngresarSaldo()
        {
            Console.WriteLine("su saldo Actual es de:{0}", Saldo);
            Console.WriteLine("Ingrese su saldo a incrementar");
            int saldoIncrementar = Convert.ToInt32(Console.ReadLine());
            if (saldoIncrementar>=0)
            {
                Saldo = Saldo + saldoIncrementar;
                Console.WriteLine("su nuevo saldo es: {0}", Saldo);
            }
            else
            {
                Console.WriteLine("valor incorrecto");
            }
        }

        public void ReintegrarSaldo()
        {
            if (Saldo==0)
            {
                Console.WriteLine("No tiene saldo para su retiro");
            }
            else
            {
                Console.WriteLine("su saldo Actual es de:{0}", Saldo);
                Console.WriteLine("Ingrese monto a retirar");
                int saldoRetiro = Convert.ToInt32(Console.ReadLine());
                if (saldoRetiro <= Saldo)
                {
                    Saldo = Saldo - saldoRetiro;
                    Console.WriteLine("su nuevo saldo es: {0}", Saldo);
                }
                else
                {
                    Console.WriteLine("valor incorrecto");
                }
            }
            
        }

        public void TransferirSaldo()
        {
            if (Saldo == 0)
            {
                Console.WriteLine("No tiene saldo para su transferencia");
            }
            else
            {
                Console.WriteLine("su saldo Actual es de:{0}", Saldo);
                Console.WriteLine("Ingrese monto a retirar");
                int saldoTransferencia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese monto a retirar");
                string cuentaTransf = Console.ReadLine();

                if (saldoTransferencia <= Saldo)
                {
                    Saldo = Saldo - saldoTransferencia;
                    Console.WriteLine("se realizo la trasferencia de {0} a la cuenta:{1}", Saldo, cuentaTransf);
                }
                else
                {
                    Console.WriteLine("transferencia no realizada");
                }
            }

        }


    }
}
