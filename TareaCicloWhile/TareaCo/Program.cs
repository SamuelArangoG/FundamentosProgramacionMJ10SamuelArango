using System;


namespace TareaCo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int número = 0;

            Console.WriteLine("Bienvenido, digite los números que quiere sumar y cierre la secuencia escribiendo un número negativo");
            while (número >= 0)
            {
                número = int.Parse(Console.ReadLine());
                acumulador = acumulador + número;
            }
            Console.WriteLine($"El resultado de la suma es : {acumulador} ");
        }
    }
}
