using System;

namespace _15.TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //1.Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
             encuentre y muestre el valor máximo y mínimo de los números ingresados. */
            /* int[] numeros = new int[15];
             int maximo = 0;
             int minimo = 0;

             Console.WriteLine("Ingrese 15 números enteros, luego, observe cuál es el valor mínimo y máximo de los números ingresados");
             for(int i=0; i<=14; i++)
             {
                 numeros[i] = int.Parse(Console.ReadLine());
                 if (i == 0)
                 {
                     maximo = numeros[i];
                     minimo = numeros[i];
                 }
                 if (numeros[i]<minimo)
                 {
                     minimo = numeros[i];
                 }
                 else if (numeros[i]>maximo)
                 {
                     maximo = numeros[i];
                 }
             }
             Console.WriteLine($"De los 15 números ingresados, el valor mínimo es {minimo} y el valor máximo es {maximo}.");*/


            /*2.Escribir un algoritmo que permita:
            a.Crear dos vectores del mismo tamaño. 
            b.Llenarlos con números.
            c.Comparar posición por posición.
            d.Indicar cuántos elementos son iguales.*/
            /*int rango = 0;
            int igualdades = 0;
            Console.WriteLine("Ingrese el rango de los dos vectores que ustéd va a crear.");
            rango = int.Parse(Console.ReadLine());
            int[] Vector1 = new int[rango];
            int[] Vector2 = new int[rango];

            Console.WriteLine("Ingrese los datos que contendrá el Vector 1");
            for (int i = 0; i < rango; i++)
            {
                Vector1[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ahora, ingrese los datos que contendrá el Vector 2");
            for (int i = 0; i < rango; i++)
            {
                Vector2[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i< rango; i++)
            {
                if (Vector1[i] == Vector2[i])
                {
                    igualdades++;
                }
            }
            Console.WriteLine($"En total, hay {igualdades} datos iguales entre ambos vectores");*/

            /*3.Escribir un algoritmo que permita:
            a.Llenar un vector[20] con números enteros(positivos o negativos) ingresados por el
            usuario o generados aleatoriamente.
            b.Calcular y mostrar el promedio aritmético de todos los elementos almacenados en
            el vector.
            c.Recorrer nuevamente el vector para contar e indicar cuántos números son
            mayores que el promedio y cuántos son menores que este. 
            d.Mostrar en pantalla el vector completo junto con los resultados obtenidos.*/
            int[] 
        }
    }
}
