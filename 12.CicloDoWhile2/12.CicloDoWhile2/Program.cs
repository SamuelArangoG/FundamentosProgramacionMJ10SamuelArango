using System;
using System.Security.Cryptography.X509Certificates;


namespace _12.CicloDoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente:
            //1. Si el saldo es mayor o igual a 3'000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y "Es apto para el credito"
            //2. Si el saldo es menor a 3'000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y "No es apto para el crédito"
            //El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no desea preguntar más. Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos.
            /*string nombre;
            int cuenta = 0;
            int saldo = 0;
            int contador = 0;
            int acumulador = 0;
            bool repetir = true;
            int promedio = 0;
            do
            {
                Console.WriteLine("Digite su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine($"{nombre}, digite su número de cuenta.");
                cuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba su saldo");
                saldo = int.Parse(Console.ReadLine());
                if (saldo >= 3000000)
                {
                    Console.WriteLine($"{nombre}, con número de cuenta {cuenta}, y con saldo {saldo} es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"{nombre}, con número de cuenta {cuenta}, y con saldo {saldo} no es apto para el crédito");
                }
                contador++;
                acumulador = acumulador + saldo;
                Console.WriteLine("¿Desea volver a preguntar por otro crédito?");
                string respuesta = Console.ReadLine()?.Trim().ToUpper();
                if (respuesta == "N" || respuesta == "NO")
                {
                    repetir = false;
                    Console.WriteLine("Programa finalizado.");
                }
                else if (respuesta == "S" || respuesta == "SI")
                {
                    repetir = true;
                }

            } while (repetir==true);
            promedio = acumulador / contador;
            Console.WriteLine($"Se le preguntó a un total de {contador} usuarios por la información y el promedio de todos los salarios es de {promedio}.");
*/
            //2.Crear un algoritmo que:
            //Permita al usuario ingresar una contraseña
            //Se repita hasta que ingrese la contraseña correcta(por ejemplo:1234)
            //Mostrar cuántos intentos realizó
            int contador = 0;
            string contraseña = "FP_2026";
            string entrada;

            do
            {
                Console.WriteLine("Digite su contraseña");
                entrada = Console.ReadLine();
                contador++;
            } while (entrada != contraseña);
            Console.WriteLine($"Bienvenido, intentos:{contador}");
        }
    }
}
