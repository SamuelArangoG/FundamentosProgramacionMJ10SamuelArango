using System;


namespace _7.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, numero 2, numero 3 respectivamente. El algoritmo debe comprobar si los números son diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en pantalla los numeros de menor a mayor.
            /*int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            Console.WriteLine("Por favor digite 3 valores diferentes");
            Console.WriteLine("Digite el primer valor");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo valor");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el tercer valor");
            numero3 = int.Parse(Console.ReadLine());
            if (numero1 != numero2 && numero2 != numero3)
            {
                if (numero1 > numero2)
                {
                    if (numero1 > numero3)
                    {
                        if (numero2 > numero3)
                        {
                            Console.WriteLine("Los números ordenados de mayor a menor son: " + numero1 + " " + numero2 + " " + numero3);
                        }
                        else
                        {
                            Console.WriteLine("Los números ordenados de mayor a menor son: " + numero1 + " " + numero3 + " " + numero2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Los números ordenados de mayor a menor son: " + numero3 + " " + numero1 + " " + numero2);
                    }
                }
                else
                {
                    if (numero2 > numero3)
                    {
                        if (numero3 > numero1)
                        {
                            Console.WriteLine("Los números ordenados de mayor a menor son: " + numero2 + " " + numero3 + " " + numero1);
                        }
                        else
                        {
                            Console.WriteLine("Los números ordenados de mayor a menor son: " + numero2 + " " + numero1 + " " + numero3);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Los números ordenados de mayor a menor son: " + numero3 + " " + numero2 + " " + numero1);
                    }
                }
            }*/

            //2.El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si cuenta con munición y si se encuentra en estado invencible, crear un programa que:
            //a. permita ingresar por teclado si el personaje está en estado invencible(true)
            //b. La cantidad de munición que tiene el personaje en el momento será calculada por el sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#
            //c.Si el personaje del juego está en estado invencible(true) y su cantidad de muncición está entre 1 y 10, mostrar un mensaje en la consola "El personaje está disparando", en caso contrario, no hacer nada.
            /*bool invencible = false;
            Console.WriteLine("¿El personaje se euentra en estado invncible? (true/false):");
            string entrada = Console.ReadLine();

            bool.TryParse(entrada, out invencible);
            Random rnd = new Random();
            int municion = rnd.Next(1, 11);

            if (invencible && municion >= 1 && municion <= 10)
            {
                Console.WriteLine("El personaje está disparando");
            }*/

            //3.Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1,y1), P"(x2, y2), P3(x3, y3). Luego calcular la distancia entre los puntos P1 y P2, P2 y P3, P1 y P3. La distancia entre dos puntos está dada por la siguiente formula:
            //d = √((x2 - x1)² +(y2 - y1)²)

            //Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con dichas distancias se puede construir un triángulo, consultar las condiciones que se deben cumplir para realizar dicha construcción. En caso contrario, decir cuál o cuáles de las condiciones no se cumplen.
            int x1;
            int x2;
            int x3;
            int y1;
            int y2;
            int y3;
            Console.WriteLine("Ingrese las coordenadas del punto P1");
            Console.WriteLine("x1:");
            x1=int.Parse(Console.ReadLine());
            Console.WriteLine("y1:");
            y1 = int.Parse(Console.ReadLine());

         
        }
    }
}
