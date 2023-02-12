using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 35; // alto de la ventana
            Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            const double PI = 3.14;
            Console.WriteLine("Cálculo de Áreas de Cuerpos Geométricos");
            Console.WriteLine("1. Esfera");
            Console.WriteLine("2. Pirámide");
            Console.WriteLine("3. Cono");
            Console.WriteLine("Elija una opción:");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Ingrese el radio de la esfera en centímetros:");
                    double r = double.Parse(Console.ReadLine());
                    double h = 4 * PI * r * r;
                    Console.WriteLine("El área de la esfera es: " + h + " cm²");
                    break;
                case 2:
                    Console.WriteLine("Ingrese la medida del lado de la base de la pirámide en centímetros:");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura de la pirámide en centímetros:");
                    double cp = double.Parse(Console.ReadLine());
                    double h2 = (b * cp) / 2;
                    Console.WriteLine("El área de la pirámide es: " + h2 + " cm²");
                    break;
                case 3:
                    Console.WriteLine("Ingrese la generatriz del cono en centímetros:");
                    double g = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del cono en centímetros:");
                    double cc = double.Parse(Console.ReadLine());
                    double h3 = Math.PI * g * (g + Math.Sqrt(cc * cc + g * g));
                    Console.WriteLine("El área de la cono es: " + h3 + " cm²");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            Console.ReadLine();
            Console.ReadLine();
            Console.Write("\n\n");
            Console.Write("\t");            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t* *");
            Console.WriteLine("\t*     Este programa fue diseñado por:     *");
            Console.WriteLine("\t* *                                        ");
            Console.WriteLine("\t*               Rodriguez                 *");
            Console.WriteLine("\t* *                                        ");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;            Console.BackgroundColor = ConsoleColor.White;            Console.Write("\t");            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");            Console.ReadKey();
        }
    }
}
