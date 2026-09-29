using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
            pantalla la suma de los elementos de cada columna.
            int[,] matriz = new int[10, 20];
            int[] suma = new int[20];
            Random rnd = new Random();
            for(int j=0; j<20; j++)
            {
                Console.WriteLine("");
                for (int i=0;i<10; i++)
                {
                    matriz[i, j] = rnd.Next(100);
                    Console.WriteLine($"[{i},{j}]:{matriz[i, j]}");
                    suma[j] += matriz[i, j];
                }
            }
            for(int j = 0; j < 20; j++)
            {
                Console.WriteLine($"El valor de la suma de todos los valores de la columna {j} es {suma[j]}");
            }*/

            /*2.Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
              caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la 
              primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la 
              matriz con el intercambio de filas.*//*
            int n = 0;
            int m = 0;
            Random rnd = new Random();
            Console.WriteLine("Escoja las filas que tendrá la matriz");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ahora, escoja las columnas");
            m=int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];
            int[,] matrizIntercambiada = new int[n, m];
            for(int i=0;i<n; i++)
            {
                for(int j=0;j<m; j++)
                {
                    matriz[i, j] = rnd.Next(50);
                    if (i == 0)
                    {
                        matrizIntercambiada[n-1, j] = matriz[i, j];
                    }
                    else if (i == n - 1)
                    {
                        matrizIntercambiada[0, j] = matriz[i, j];
                    }
                    else
                    {
                        matrizIntercambiada[i, j] = matriz[i, j];
                    }
                }
            }
            Console.WriteLine($"Matriz Original----------Matriz Intercambiada");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"[{i},{j}]:{matriz[i, j]}------------------{matrizIntercambiada[i, j]}");
                }
                Console.WriteLine($"");*/
            }
        }
    }
}
