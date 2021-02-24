using System;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Que pida un número y diga si es primo o no.
            Console.WriteLine("ingrese un numero entero");
            int numeroPrimo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el numero divisor");
            int numeroDivisor = Convert.ToInt32(Console.ReadLine());

            if (numeroPrimo%numeroDivisor ==0)
            {
                Console.WriteLine("el numero {0} es primo de {1}",numeroPrimo, numeroDivisor);
            }
            else
            {
                Console.WriteLine("el numero {0} no es primo de {1}", numeroPrimo, numeroDivisor);
            }


            //2.Que muestre los números del 1 al 100.
            for (int numeroinicial = 1; numeroinicial <= 100; numeroinicial++)
            {
                Console.WriteLine(numeroinicial);
            }

            //3.Que muestre los números del 100 al 1.
            for (int numeroInicial = 100; numeroInicial >= 1; numeroInicial--)
            {
                Console.WriteLine(numeroInicial);
            }

            //4.Que muestre los números pares que haya del 1 al 100.
            for (int numeroInicial = 2; numeroInicial <= 100; numeroInicial= numeroInicial+2)
            {
                Console.WriteLine(numeroInicial);
            }

            //5.Que muestre los números impares que haya del 1 al 100.
            for (int numeroInicial = 1; numeroInicial <= 100; numeroInicial = numeroInicial + 2)
            {
                Console.WriteLine(numeroInicial);
            }

            //6.Que imprima la suma de todos los números que van del 1 al 100.


            //7.Que imprima la suma de todos los números pares que van del 1 al 100.


            //8.Que imprima la suma de todos los números impares que van del 1 al 100.


            //9.Que imprima la suma de todos los números pares que van del 1 al 100 y diga cuántos hay.

            //10.Que imprima la suma de todos los números impares que van del 1 al 100 y diga cuántos hay.

            //11.Que pida dos números y muestre todos los números que van desde el primero al segundo.Se debe controlar que los valores son correctos.

            //12.Que pida dos números y muestre todos los números pares que van desde el primero al segundo. Se debe controlar que los valores son correctos.

            //13.Que pida dos números y muestre todos los números impares que van desde el primero al segundo. Se debe controlar que los valores son correctos.

            //14.Que pida dos números y sume todos los números que van desde el primero al segundo.Se debe controlar que los valores son correctos.

            //15.Que pida dos números y multiplique todos los números que van desde el primero al segundo.Se debe controlar que los valores son correctos.

            //16.Que pida un número y muestre en pantalla el mismo número de asteriscos.

            //17.Que muestre los números del 1 al 100 en una tabla de 10x10.
            //18.Que escriba las tablas de multiplicar del 0 al 10.

            //19.Que muestre la tabla de multiplicar de un número cualquiera.

            //20.Que haga un menú del tipo “desea salir(S/ N)” y el programa no termine hasta que el usuario teclee “S”.
            //21.Que calcule el factorial de un número cualquiera y lo muestre en pantalla.

            //22.Que calcule la media de 10 números.

            //23.Que calcule la media de X números, se dejarán de solicitar números hasta que se introduzca el cero.
            //24.Que calcule la suma de los cuadrados de los 100 primeros números.

            //25.Que escriba los primeros 25 dígitos de la sucesión de Fibonacci.

        }
    }
}
