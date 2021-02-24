using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.- Declare 5 cinco variables primitivas numéricas
            byte entero8bits;
            short entero16bits;
            ushort entero16SinSigno;
            int entero32bits;
            long entero64bits;

            //2.- Declare 3 variables primitivas de tipo texto.
            string caracter     = "esto es un caracter";
            char caracterUnicao = 'y';

            //3.- Declare 5 variables numéricas y asígneles un valor.
            byte entero8bit     = 255;
            short entero16bit   = 32767;
            ushort entero16SinSig = 65535;
            int entero32bit     = 2147483647;
            long entero64bit    = 15254778554555;

            //4.- Declare 3 variables de texto e ingrese un valor por teclado.
            string texto = Console.ReadLine();
            char textoChar = Convert.ToChar(Console.ReadLine());

            //5.- Ingrese valores numéricos por teclado y muéstrelos en consola con la frase “El número que ingreso es: ”.
            int valorNumerico = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero que ingreo es: {0}",valorNumerico);

            //6.- Realice 5 ejemplos de conversión implícita.
            int numero = 200000;
            double numeroGrande = numero;

            byte numeroPequenio = 255;
            short numeroMediado = numeroPequenio;

            float numFlotante = 214235436547576658;
            double numeroDouble = numFlotante;

            int entero = 43657657;
            decimal numDecimal = entero;

            char tipoCaracter = '2';
            int tipoEntero = tipoCaracter;

            //7.- Realice 5 ejemplos de conversión explicita.

            double valorNumero = double.Parse("5465768768");
            
            int numero1 = Convert.ToInt32("5465768768");

            double numero2 = 243547657;
            int numero3 = Convert.ToInt32(numero2);

            int numero4 = 255;
            byte numero5 = Convert.ToByte(numero4);


            string numero6= "12324";
            int numero7 = Convert.ToInt32(numero6);

            //8.- Ingrese dos números por teclado y verifique cual es el mayor y cual el menor
            Console.WriteLine("ingrese el primero valor");
            int primerNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo valor");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());
            if (primerNumero > segundoNumero)
            {
                Console.WriteLine("el numero {0} es mayor", primerNumero);
            }
            else
            {
                Console.WriteLine("el numero {0} es mayor", segundoNumero);
            }

            //9.- Ingrese un numero por teclado y verifique si es par.
            Console.WriteLine("ingrese un numero entero");
            int numeroPar = Convert.ToInt32(Console.ReadLine());

            if (numeroPar % 2== 0)
            {
                Console.WriteLine("el numero {0} es par", numeroPar);
            }
            else
            {
                Console.WriteLine("el numero {0} no es par", numeroPar);
            }


            //10.- Ingrese un numero por teclado y verifique si es múltiplo de 3, 5 o 7.
            Console.WriteLine("ingrese un numero entero");
            int numMultiplo = Convert.ToInt32(Console.ReadLine());
            int multiplo1 = 3;
            int multiplo2 = 5;
            int multiplo3 = 7;

            if (numMultiplo % multiplo1 == 0)
            {
                Console.WriteLine("el numero {0} es multiplo de  {1}", numMultiplo, multiplo1);
            }
            else if (numMultiplo % multiplo2 == 0)
            {
                Console.WriteLine("el numero {0} es multiplo de  {1}", numMultiplo, multiplo2);
            }
            else if (numMultiplo % multiplo3 == 0)
            {
                Console.WriteLine("el numero {0} es multiplo de  {1}", numMultiplo, multiplo3);
            }
            else
            {
                Console.WriteLine("el numero {0} no es multiplo de  {1}, ni {2} , ni {3}", numMultiplo, multiplo1, multiplo2, multiplo3);
            }
        }
    }
}