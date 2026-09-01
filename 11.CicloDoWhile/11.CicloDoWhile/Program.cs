using System;

namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;
            do
            {
                acumulador += contador;
                contador++;
            } while (contador <= 5);

            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");*/



            //Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar.
            /* int contador = 1;
             int numero = 1;
             bool continuar = true;
             do
             {
                 Console.WriteLine("Introduzca el número para ver su tabla de multiplicar");
                 numero=int.Parse(Console.ReadLine());
                 do
                 {
                     Console.WriteLine($"{numero}x{contador}={numero * contador}");
                     contador++;
                 } while (contador <= 10);
                 contador = 1;
                 Console.WriteLine("¿Desea continuar? (s/n):");
                 string respuesta = Console.ReadLine().ToLower();

                 if (respuesta == "n")
                 {
                     continuar = false;
                 }

             } while (continuar == true);

             Console.WriteLine("¡Hasta luego!");*/


            //2. Crear un algoritmo que permita calcular y mostrar por pantalla los números primos hasta el número 100
            int contador = 2;
            int contador2 = 1;
            int contadorDivisiones = 0;

            do
            {
                do
                {
                    if(contador%contador2==0)
                    {
                        contadorDivisiones++;
                    }
                    contador2++;
                } while (contador2 <= contador);
                contador2 = 1;
                if(contadorDivisiones==2)
                {
                    Console.WriteLine(contador);
                }
                contadorDivisiones = 0;
                contador++;
            } while (contador <= 100);
        }

    }
}
