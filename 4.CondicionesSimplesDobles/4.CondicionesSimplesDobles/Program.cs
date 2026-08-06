using System;

namespace _4.CondicionesSimplesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTRUCTURAS DE CONTROL CONDICIONAL
            //Condicional Simple
            //1. Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web"
            /*byte edad = 0;
           *//* Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToByte(Console.ReadLine());

            if(edad >= 18)
            {
                //Si la condicion es verdadera
                Console.WriteLine("Bienvenido a mi sitio web");
            }*/

            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.

            /*string nombre;
            float sueldo;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if(sueldo > 3000)
            {
                Console.WriteLine("Usted, " + nombre + " debe abonar impuestos");
            }*/

            //Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web". De lo contrario, mostrar el mensaje "No es apto para el contenido de este sitio web".
            /*  byte edad = 0;
              Console.WriteLine("Ingrese su edad");
              edad = Convert.ToByte(Console.ReadLine());

              if(edad >=18)
              {
                  Console.WriteLine("Bienvenido a mi sitio web");
              }
              else
              {
                  Console.WriteLine("No es apto para el contenido de este sitio web");
              }*/
            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. De lo contrario mostrar el mensaje "Persona exenta de impuestos"
            /*string nombre;
            float sueldo;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine("Usted, " + nombre + " debe abonar impuestos");
            }
            else
            {
                Console.WriteLine("Persona exenta de impuestos");
            }*/

            //Crear un algoritmo que permita ingresar dos números. si el primer número es mayor al segundo número, informar su suma y diferencia, en caso contrario informar el producto y la división del primer número respecto al segundo número
            float A;
            float B;
            Console.WriteLine("Ingrese el primer número");
            A = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            B = Convert.ToSingle(Console.ReadLine());

            if(A > B)
            {
                Console.WriteLine("La suma entre ambos números es igual a: " + (A + B) + "\nla resta entre ambos números es igual a: " + (A - B));
            }
            else
            {
                Console.WriteLine("El producto entre ambos números es igual a: " + (A * B) + "\na resta entre ambos números es igua a: " + (A / B));
            }



        }
    }
}
