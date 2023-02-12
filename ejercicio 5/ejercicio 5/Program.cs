using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 70;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "programa para calcular el valor de una resistencia";
            Console.Write("\t Programa para calcular resistencias ");
            Console.Write("\n\n");
            // variables 
            char banda1, banda2, banda3;
            int resis, color1, color2, color3;
            double total;
            color1 =0;    
            color2 = 0;
            color3 = 0;
            total = 0;
            // entrada 
            Console.Write("\nLos valores de la resistencia se encuentran de la siguiente manera: \nN=negro\nM=marron\nR=rojo\nn=naranja\nA=amarillo\nV=verde\na=azul\nv=vilotA\nG=gris\nB=blanco\n");
            Console.Write("\nTeniendo en cuenta la lista anterior ingrese la incial de la primer banda: ");
            banda1 = char.Parse(Console.ReadLine());
            Console.Write("\nIngrese la inicial de la segunda banda: ");
            banda2 = char.Parse(Console.ReadLine());
            Console.Write("\nIngrese la inicial de la tercera banda: ");
            banda3 = char.Parse(Console.ReadLine());
            switch (banda1)

            {
                case 'N':
                    color1 = 0;
                    break;
                case 'M':
                    color1 = 10;
                    break;
                case 'R':
                    color1 = 20;
                    break;
                case 'n':
                    color1 = 30;
                    break;
                case 'A':
                    color1 = 40;
                    break;
                case 'V':
                    color1 = 50;
                    break;
                case 'a':
                    color1 = 60;
                    break;
                case 'v':
                    color1 = 70;
                    break;
                case 'G':
                    color1 = 80;
                    break;
                case 'B':
                    color1 = 90;
                    break;

                   default:
                    Console.Write("\nopcion no valida");
                    break;
            }
            switch (banda2)
            {
                case 'N':
                    color2 = 0;
                    break;
                case 'M':
                    color2 = 1;
                    break;
                case 'R':
                    color2 = 2;
                    break;
                case 'n':
                    color2 = 3;
                    break;
                case 'A':
                    color2 = 4;
                    break;
                case 'V':
                    color2 = 5;
                    break;
                case 'a':
                    color2 = 6;
                    break;
                case 'v':
                    color2 = 7;
                    break;
                case 'G':
                    color2 = 8;
                    break;
                case 'B':
                    color2 = 9;
                    break;
                default:
                    Console.Write("\nOpcion invalida");
                    break;
            }
            switch (banda3)
            {
                case 'N':
                    color3 = 1;
                    break;
                case 'M':
                    color3 = 10;
                    break;
                case 'R':
                    color3 = 100;
                    break;
                case 'n':
                    color3 = 1000;
                    break;
                case 'A':
                    color3 = 10000;
                    break;
                case 'V':
                    color3 = 100000;
                    break;
                case 'a':
                    color3 = 1000000;
                    break;

                default:
                    Console.Write("Opcion invalida");
                    break;
            }
            // proceso 
            resis = color1 + color2;
            resis = resis * color3;
            // salida
           if (resis < 1000)
            {
                Console.Write("\nEl valor de la resistencia es de: " + resis + " Ohmios");

            }
            
            else if (resis < 999999)
            {
                total = resis / 1000; 
                Console.Write("\nEl valor de la resistencia es de: " + total+"K Ohmios");
             }

            else  
            {
                total = resis / 1000000;
                Console.Write("\nEl valor de la resistencia es de: " + total + "M Ohmios");
            }
            Console.ReadKey();


        }

    }
}
