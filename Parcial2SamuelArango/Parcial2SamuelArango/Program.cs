using System;
using System.Diagnostics;
using System.Runtime.Remoting.Contexts;


namespace Parcial2SamuelArango
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En el programa de Ingeniería de Sistemas, que cuenta con 15 estudiantes, se desea procesar información estadística sobre la ocupación y el género de los alumnos.
            Utilizando obligatoriamente una estructura repetitiva, el programa debe realizar las siguientes acciones por cada estudiante:
            Ingreso de Datos: Solicitar por teclado la ocupación del estudiante y su género. Para evitar errores de escritura, se deben utilizar códigos estandarizados:
                    Ocupación: Digitar T si trabaja o E si estudia.
            Género: Digitar H si es hombre o M si es mujer.
            Cálculo de Porcentajes: Al finalizar el ingreso de los 15 estudiantes, calcular y mostrar el porcentaje de estudiantes que trabajan y el porcentaje de los que estudian respecto al total del grupo.
            Cálculo de Cruces(Condicionales): A medida que se procesan los datos, determinar y mostrar:
                        La cantidad total de mujeres que trabajan.
            La cantidad total de hombres que estudian.
            Reporte Final: Mostrar claramente en pantalla los porcentajes calculados y los dos conteos específicos solicitados.*/
            string ocupación;
            string género;
            int contadorT = 0;
            int contadorE = 0;
            int contadorH = 0;
            int contadorM = 0;
            float porcentajeT = 0f;
            float porcentajeE = 0f;
            int contadorHE = 0;
            int contadorMT = 0;
            //Nota: T=Trabajadores-E=Estudiantes-H=Hombres-M=Mujeres
            for (int estudiantes = 1; estudiantes <= 15; estudiantes++)
            {
                Console.WriteLine("Bienvenido, cuál es su ocupación actualmente, Trabaja(T) o Estudia(E)?");
                ocupación = Console.ReadLine().Trim().ToLower();
                if(ocupación=="t")
                {
                    contadorT++;
                }
                else if(ocupación=="e")
                {
                    contadorE++;
                }
                Console.WriteLine("Ustéd es Hombre(H), o Mujer(M)?");
                género = Console.ReadLine().Trim().ToLower();
                if (género == "h")
                {
                    contadorH++;
                }
                else if (género == "m")
                {
                    contadorM++;
                }
                if(género=="m")
                {
                    if(ocupación=="t")
                    {
                        contadorMT++;
                    }
                }
                else
                {
                    if (ocupación == "e")
                    {
                        contadorHE++;
                    }
                }
            }
            porcentajeE = contadorE * 100f / 15f;
            porcentajeT = contadorT * 100f / 15f;
            Console.WriteLine($"El porcentaje de estudiantes que actualmente trabajan es de {porcentajeT}%");
            Console.WriteLine($"El porcentaje de estudiantes que actualmente estudian es de {porcentajeE}%");
            Console.WriteLine($"Dentro del grupo de estudiantes, las mujeres que actualmente trabajan son {contadorMT} y los hombres que actualmente estudian son {contadorHE}");


        }
    }
}
