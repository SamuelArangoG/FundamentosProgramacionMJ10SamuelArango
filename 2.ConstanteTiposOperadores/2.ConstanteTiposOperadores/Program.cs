using System;
using System.ComponentModel;

namespace _2.ConstanteTiposOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constantes
            const string iva = "19%";
            string nombre = "Samuel";
            nombre = "Arango";
            //iva = "20%"; que a una constante no se le puede cambiaer su valor

            //Tipos de Datos
            byte dato1 = 255;
            int dato2 = -256;
            ulong dato3 = 1236333;
            float dato4 = 5.3f;
            double dato5 = 2123.3265;
            char dato6 = ' '; //Almacena un solo caracter
            string dato7 = "hasnsd7183!%%&DSAasda";
            bool dato8 = false;//true or false
            object dato9 = new object();
            //Operadores
            //Numéricos
            //cambio de signo
            int dato10 = 5;
            int dato11 = -dato10;
            int dato12 = +dato11;
            int dato13 = -dato12;
            Console.WriteLine("dato10: {0}, dato11:{1}, dato12:{2} dato13:{3}", dato10, dato11, dato12, dato13);
            //Operadores aritméticos
            int dato14 = 5 + 3;//suma
            int dato15 = dato14 - 2;//resta
            int dato16 = 10 * 3;//Producto
            //División
            //float dato17 = 5.0f / 3.0f; Forma 1
            //float dato17 = (float)5 / 3; Forma 2
            float dato17 = 5f / 3; //Forma 3
            Console.WriteLine("suma:{0}, resta:{1}, producto:{2}, división:{3}", dato14, dato15, dato16, dato17);
            //Operadores de incremento y decremento
            int dato18 = 1;
            dato18++;//dato18=dato18+1
            dato18--;//dato18=dato18-1
            dato18 += 3;//dato18=dato18+3
            dato18 -= 2;//dato18=dato18-2
            dato18 *= 5;//dato18=dato18*5
            dato18 /= 3;//dato18=dato18/3
       /3
   /3
}
