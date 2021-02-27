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
            int suma = 0;
            for (int numero = 1; numero <= 100; numero++)
            {
                suma = numero * (numero + 1) / 2;
            }
            Console.WriteLine("La suma es: {0}", suma);


            //7.Que imprima la suma de todos los números pares que van del 1 al 100.
            int sumaPares = 0;
            for (int numero = 2; numero <= 100; numero= numero +2)
            {
                sumaPares = sumaPares + numero;
            }
            Console.WriteLine("La suma de numeros pares es: {0}", sumaPares);


            //8.Que imprima la suma de todos los números impares que van del 1 al 100.
            int sumaImpar= 0;
            for (int numero = 1; numero <= 100; numero=numero + 2)
            {
                sumaImpar = sumaImpar + numero;
            }
            Console.WriteLine("La suma de numeros impartes es: {0}", sumaImpar);


            //9.Que imprima la suma de todos los números pares que van del 1 al 100 y diga cuántos hay.
            int sumPares = 0;
            int cantidad = 0;
            for (int numero = 2; numero <= 100; numero = numero + 2)
            {
                sumPares = sumPares + numero;
                cantidad++;
            }
            Console.WriteLine("La suma de {0} numeros pares es: {1}", cantidad, sumPares);


            //10.Que imprima la suma de todos los números impares que van del 1 al 100 y diga cuántos hay.
            int sumImpar = 0;
            int cantidad1 = 0;
            for (int numero = 1; numero <= 100; numero = numero + 2)
            {
                sumImpar = sumImpar + numero;
                cantidad1 ++;
            }
            Console.WriteLine("La suma de {0} numeros impares es: {1}", cantidad1, sumImpar);

            //11.Que pida dos números y muestre todos los números que van desde el primero al segundo.Se debe controlar que los valores son correctos.
            Console.WriteLine("Digite el primero numero");
            int primerNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            int segundoNum = Convert.ToInt32(Console.ReadLine());

            if (primerNum >= segundoNum)
            {
                Console.WriteLine("el primer numero es menor al segundo");
            }
            else
            {
                for (int index = primerNum; index <= segundoNum; index++)
                {
                    Console.WriteLine(primerNum);
                    primerNum++;
                }
            }

            //12.Que pida dos números y muestre todos los números pares que van desde el primero al segundo. Se debe controlar que los valores son correctos.

            Console.WriteLine("Digite el primero numero");
            int primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            if (primerNumero >= segundoNumero)
            {
                Console.WriteLine("el primer numero es menor al segundo");
            }
            else
            {
                for (int index = primerNumero % 2 == 0 ? index= primerNumero : index = primerNumero + 1; index <= segundoNumero; index=index+2)
                {
                    Console.WriteLine(index);
                }
            }

            //13.Que pida dos números y muestre todos los números impares que van desde el primero al segundo. Se debe controlar que los valores son correctos.
            Console.WriteLine("Digite el primero numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 >= numero2)
            {
                Console.WriteLine("el primer numero es menor al segundo");
            }
            else
            {
                for (int index = numero1 % 2 == 0 ? index = numero1+1 : index = numero1; index <= numero2; index = index + 2)
                {
                    Console.WriteLine(index);
                }
            }


            //14.Que pida dos números y sume todos los números que van desde el primero al segundo.Se debe controlar que los valores son correctos.
            Console.WriteLine("Digite el primero numero");
            int num1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("el primer numero es menor al segundo");
            }
            else
            {
                int sumaNum = 0;
                for (int numero = num1; numero <= num2; numero++)
                {
                    sumaNum = numero * (numero + 1) / 2;
                }
                Console.WriteLine("La suma es: {0}", sumaNum);
            }


            //15.Que pida dos números y multiplique todos los números que van desde el primero al segundo.Se debe controlar que los valores son correctos.
            Console.WriteLine("Digite el primero numero");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 >= number2)
            {
                Console.WriteLine("el primer numero es menor al segundo");
            }
            else
            {
                int multiplicar = number1;
                for (int numero = number1; numero <= number2; numero++)
                {
                    multiplicar = multiplicar * numero;
                }
                Console.WriteLine("La multiplicacion del {0} al {1} es: {2}", number1, number2, multiplicar / number1);
            }


            //16.Que pida un número y muestre en pantalla el mismo número de asteriscos.
            Console.WriteLine("Digite el primero numero");
            int numAsterisco = Convert.ToInt32(Console.ReadLine());
            int cont = 1;
            while(cont <=numAsterisco){
                Console.Write("*");
            }

            //17.Que muestre los números del 1 al 100 en una tabla de 10x10.



            //18.Que escriba las tablas de multiplicar del 0 al 10.
            for (int fila = 1; fila <= 10; fila++)
            {
                for (int columna = 1; columna <= 10; columna++)
                {
                    int total = fila * columna;
                    Console.WriteLine("{0} ", total);
                    // Console.Write(matrizBi[fila, columna]);
                    if (total < 10)
                    {
                        Console.WriteLine(" ");
                    }
                }
            }

            //19.Que muestre la tabla de multiplicar de un número cualquiera.
            Console.WriteLine("Digite un numero para la tabla de multiplicar");
            int numeroT = Convert.ToInt32(Console.ReadLine());
            for (int contar = 1; contar <= 10; contar++)
            {
                int resultado = contar * numeroT;
                Console.WriteLine("{0} x {1} = {2} ", contar, numeroT, resultado);
            }

            //20.Que haga un menú del tipo “desea salir(S/ N)” y el programa no termine hasta que el usuario teclee “S”.
            bool bandera = false;
            string respuesta;
            do
            {
                bandera = true;
                Console.WriteLine("Desea salir (S/N)");
                respuesta = Console.ReadLine();
                if (respuesta == "S" || respuesta == "s") bandera = false;
            } while (bandera);
            Console.WriteLine("salio del programa");

            //21.Que calcule el factorial de un número cualquiera y lo muestre en pantalla.
            Console.WriteLine("Digite un numero");
            int numeroFac = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int numero = factorial; numero <= numeroFac; numero++)
            {
                factorial = factorial * numero;
            }
            Console.WriteLine("El factorial de {0} es:  {1}", numeroFac, factorial);

            //22.Que calcule la media de 10 números.
            double[] rangoNumeros = { 10, 30, 15, 48, 58, 78, 70, 25, 60, 4 };
            double sumatoria = 0;
            foreach (double num in rangoNumeros)
            {
                sumatoria = sumatoria + num;
            }
            double media = sumatoria / rangoNumeros.Length;
            Console.WriteLine("la media es :{0} ", media);

            //23.Que calcule la media de X números, se dejarán de solicitar números hasta que se introduzca el cero.

            //24.Que calcule la suma de los cuadrados de los 100 primeros números.

            //25.Que escriba los primeros 25 dígitos de la sucesión de Fibonacci.
            int limite = 25;
            int aux = 0;
            int primNum = 0;
            int segunNum = 1;

            int contador = 1;

            while (contador <= limite)
            {
                aux = primNum;
                primNum = segunNum;
                segunNum = aux + primNum;
                Console.WriteLine(segunNum);
                contador++;
            }
        }
    }
}
