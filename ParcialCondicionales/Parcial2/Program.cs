using System;
using System.Diagnostics.Eventing.Reader;
using System.Timers;

namespace Parcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrolle un programa en C# que determine la categoría de consumo de energía de un hogar y calcule el valor que debe pagar por el servicio, de acuerdo con el consumo mensual y el tipo de usuario. (70%)
1.Ingreso de datos
El programa debe solicitar al usuario los siguientes datos:
            Nombre del usuario.
Consumo mensual de energía, expresado en kilovatios-hora(kWh).
Tipo de usuario, que puede ser:
            Residencial
            Comercial
El consumo debe ser un número mayor que 0.
Si el consumo ingresado no es válido, el programa debe mostrar:
Error: el consumo debe ser mayor que 0.
y finalizar el programa.
2.Clasificación del consumo
La categoría del consumo se determina de acuerdo con la cantidad de kWh consumidos durante el mes:


Consumo mensual
Categoría
Hasta 100 kWh
Bajo
Más de 100 y hasta 200 kWh
Medio
Más de 200 y hasta 400 kWh
Alto
Más de 400 kWh
Muy alto
3.Valor por kWh
El valor que se debe pagar por cada kWh depende del tipo de usuario:


Tipo de usuario
Valor por kWh
Residencial
$800
Comercial
$1.200
4.Descuento o recargo
Después de determinar el valor básico del consumo, se debe aplicar un descuento o recargo según la categoría de consumo:


Tipo de usuario
Categoría
Descuento / Recargo
Residencial
Bajo
10 % de descuento
Residencial
Medio
5 % de descuento
Residencial
Alto
Sin descuento ni recargo
Residencial
Muy alto
10 % de recargo
Comercial
Bajo
5 % de descuento
Comercial
Medio
Sin descuento ni recargo
Comercial
Alto
10 % de recargo
Comercial
Muy alto
20 % de recargo
5.Cálculos
El programa debe calcular primero el valor básico del consumo:
valorBase = consumo × valorPorKWh
Posteriormente, debe calcular el valor del descuento o recargo:
            valorAjuste = valorBase × (porcentajeAjuste / 100)
Finalmente, debe determinar el valor total que debe pagar el usuario.
Cuando exista un descuento, el valor del ajuste debe restarse al valor base.
Cuando exista un recargo, el valor del ajuste debe sumarse al valor base.
6.Salida del programa
El programa debe mostrar en pantalla:
Nombre del usuario
Tipo de usuario
Consumo mensual
Categoría de consumo
Valor por kWh
Valor base
Porcentaje de descuento o recargo aplicado
Valor del descuento o recargo
Valor total a pagar
Por ejemplo:
        Nombre: Carlos
        Tipo de usuario: Residencial
        Consumo: 150 kWh
        Categoría: Medio
        Valor por kWh: $800
Valor base: $120.000
Descuento aplicado: 5 %
Valor del descuento: $6.000
Total a pagar: $114.000
El estudiante podrá utilizar las estructuras condicionales estudiadas en clase que considere adecuadas para resolver el problema.*/

            string nombre ="";
            int consumo = 0;
            string TipoUsuario ="";
            byte TipoUsuarionum = 0;
            byte categorianum = 0;
            int valorkWh = 0    ;
            string categoria = "";
            int ValorBase = 0;
            int ValorAjuste = 0;
            int PorcentajeAjuste = 0;
            int TotalPagar = 0;
            Console.WriteLine("Bienvenido, por favor escriba su nombre completo");
            nombre = Console.ReadLine();
            Console.WriteLine(nombre + " por favor escriba su consumo mensual de energía en kWh");
            consumo = int.Parse(Console.ReadLine());
            if(consumo<=0)
            {
                Console.WriteLine("Error: El consumo de energía debe ser mayor a 0");
                Environment.Exit(0);
            }
            Console.WriteLine("Seleccione su tipo de usuario, si es Residencial, presione 1, y si es Comercial, presione 2");
            TipoUsuarionum = Convert.ToByte(Console.ReadLine());
            if (TipoUsuarionum != 1 && TipoUsuarionum != 2)
            {
                Console.WriteLine("Error: El tipo de usuario ingresado no es válido");
                Environment.Exit(0);
            }
            if(TipoUsuarionum==1)
            {
                TipoUsuario = "Residencial";
                valorkWh = 800;
            }
            if(TipoUsuarionum==2)
            {
                TipoUsuario = "Comercial";
                valorkWh = 1200;
            }
            if(0<consumo && consumo<=100)
            {
                categoria = "bajo";
                categorianum = 1;
            }
            if (100 < consumo && consumo <= 200)
            {
                categoria = "medio";
                categorianum = 2;
            }
            if (200 < consumo && consumo <= 400)
            {
                categoria = "alto";
                categorianum = 3;
            }
            if (400 < consumo)
            {
                categoria = "muy alto";
                categorianum = 4;
            }
            //En caso de ser residencial
            switch (TipoUsuarionum)
            {
                case 1:
                    switch (categorianum)
                    {
                        case 1:
                            PorcentajeAjuste = 10;
                            break;
                        case 2:
                            PorcentajeAjuste = 5;
                            break;
                        case 3:
                            PorcentajeAjuste = 0;
                            break;
                        case 4:
                            PorcentajeAjuste = -10;
                            break;
                    }
                    break;
                case 2:
                    switch (categorianum)
                    {
                        case 1:
                            PorcentajeAjuste = 5;
                            break;
                        case 2:
                            PorcentajeAjuste = 0;
                            break;
                        case 3:
                            PorcentajeAjuste = -10;
                            break;
                        case 4:
                            PorcentajeAjuste = -20;
                            break;
                    }
                    break;
            }
            ValorBase = consumo * valorkWh;

            ValorAjuste = ValorBase * PorcentajeAjuste / 100;

            TotalPagar = ValorBase + PorcentajeAjuste;
            Console.WriteLine("Nombre del usuario: " + nombre + "\r\nTipo de usuario: " + TipoUsuario + "\r\nConsumo mensual: " + consumo + "\r\nCategoría de consumo: " + categoria + "\r\nValor por kWh: " + valorkWh + "\r\nValor base: " + "\r\nPorcentaje de descuento o recargo aplicado: " + PorcentajeAjuste + "\r\nValor del descuento o recargo: " + "\r\nValor total a pagar: ");











        }
    }
}
