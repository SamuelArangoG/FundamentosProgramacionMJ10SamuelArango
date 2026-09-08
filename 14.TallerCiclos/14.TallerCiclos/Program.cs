using System;
using System.Security.Cryptography;


namespace _14.TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Algoritmo que permita calcular el promedio de calificaciones, el algoritmo 
            le permitirá al usuario, introducir tantas calificaciones como así desee, 
            en el momento en que seleccione que no desea continuar capturando
            calificaciones, el algoritmo debe presentar el promedio de las
            calificaciones capturadas previamente*/
            /*int promedio;
            int calificacion;
            bool continuar = true;
            int contador=0;
            int acumulador=0;
            string respuesta;
            Console.WriteLine("Escriba las calificaciones de las cuales quiere sacar su promedio");
            do
            {
                contador++;
                calificacion = int.Parse(Console.ReadLine());
                acumulador += calificacion;
                Console.WriteLine("Desea continuar? (si/no)");
                respuesta = Console.ReadLine().Trim().ToLower();
                if ((respuesta == "si" || respuesta == "sí"))
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }
            } while (continuar);
            promedio = acumulador / contador;
            Console.WriteLine($"El promedio de las calificaciones ingresadas es de {promedio}");*/


            /*2.Se requiere un algoritmo para mostrar por pantalla los divisores de un 
            número ingresado por teclado. 
            Tener en cuenta que dados dos números enteros a y b, se dice que b es
            divisor de a si se cumple que al efectuar una división entera a/ b el
            residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
            una división de dos números.
            Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
            2, 1 que son los divisores del número 6.*/
            /*int numero;
            int contador;
            int residuo;
            Console.WriteLine("Digite el número del cuál desea obtener sus divisores");
            numero = int.Parse(Console.ReadLine());
            contador = numero;
            Console.WriteLine($"Los divisores del número {numero} son:");
            while (contador > 0)
            {
                residuo = numero % contador;
                if (residuo == 0)
                {
                    Console.WriteLine(contador);
                }
                contador--;*/

          /*3.Dados dos números enteros ingresados por teclado: b que es la base y
            e que es el exponente, se requiere calcular el resultado de la
            potenciación.
            Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32
            Mostrar por pantalla el resultado de la potenciación. 
            Seguir pidiendo por teclado la base y el exponente y realizar la
            potenciación correspondiente, hasta que el usuario ingrese por teclado
            el carácter de escape ‘n’ */
            int e;
            int b;
            char respuesta= 'n';
            while (respuesta == 'n')
            {
                Console.WriteLine("Desea seguir usando el programa? Si no, escriba n");
                respuesta =Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
