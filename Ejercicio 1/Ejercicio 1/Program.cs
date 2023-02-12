using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 30;
            Console.WindowWidth = 70;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "programa para calcular el perimetro de una elipse";
            Console.Write("\t Programa para calcular perimetro de una elipse ");
            Console.Write("\n\n");
            // declaracion de variables 
            double a, b, perimetro, p1, pi;
            pi = Math.PI;
            // entrada
            Console.Write("\tInserte el valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\tInserte el valor de B: ");
            b = double.Parse(Console.ReadLine());
            // procesos
            perimetro = pi*((3*(a+b))-Math.Sqrt(((a*3)+b)*((b*3)+a)));
            //salida 
            Console.Write("\tEl valor del perimetro de la elipse es de: " + perimetro);
            Console.ReadKey();






        }
    }
}
