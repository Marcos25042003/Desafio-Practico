using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio #3, Desafio Práctico";
            Console.WriteLine("\n\tEjercicio #3, Desafio Práctico");
            Console.WriteLine("\tPrograma para saber el funcionamiento de compuertas lógicas\n");
            //Declaración de las variables
            int opcion;
            char estado1, estado2;
            //Menú en pantalla y lectura de datos
            Console.WriteLine("\t\t\t Bienvenido!\n");
            Console.WriteLine("\t-- Seleccione el tipo de compuerta a comprobar --\n ");
            Console.WriteLine("\t1. NAND ");
            Console.WriteLine("\t2. XOR ");
            Console.WriteLine("\t3. Salir \n");
            Console.Write("\tSeleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1://Comprobación de la compuerta NAND
                    Console.Clear();
                    Console.WriteLine("\n\tEjercicio #3, Desafio Práctico");
                    Console.WriteLine("\tPrograma para saber el funcionamiento de compuertas lógicas\n");
                    Console.WriteLine("\t--Comprobación de la compuerta NAND--");
                    Console.WriteLine("\n\tDigite el primer estado lógico");
                    Console.WriteLine("\tIMPORTANTE! digite solamente los caracteres F o V:"); 
                    estado1 = char.Parse(Console.ReadLine());
                    Console.WriteLine("\n\tDigite el segundo estado lógico");
                    Console.WriteLine("\tIMPORTANTE! digite solamente los caracteres F o V:");
                    estado2 = char.Parse(Console.ReadLine());
                    if ((estado1 == 'f' && estado2 == 'f') || (estado1 == 'F' && estado2 == 'F') || (estado1 == 'f' && estado2 == 'v') || (estado1 == 'F' && estado2 == 'V') || (estado1 == 'v' && estado2 == 'f') || (estado1 == 'V' && estado2 == 'F'))
                    {
                        Console.WriteLine("\tEl resultado de los estados digitados según la compuerta NAND es: V");
                    }
                    else
                    {
                        Console.WriteLine("\tEl resultado de los estados digitados según la compuerta NAND es: F");
                    }
                    break;

                case 2://Comprobación de la compuerta XOR
                    Console.Clear();
                    Console.WriteLine("\n\tEjercicio #3, Desafio Práctico");
                    Console.WriteLine("\tPrograma para saber el funcionamiento de compuertas lógicas\n");
                    Console.WriteLine("\t--Comprobación de la compuerta XOR--\n");
                    Console.WriteLine("\n\tDigite el primer estado lógico");
                    Console.WriteLine("\tIMPORTANTE! digite solamente los caracteres F o V:");
                    estado1 = char.Parse(Console.ReadLine());
                    Console.WriteLine("\n\tDigite el segundo estado lógico");
                    Console.WriteLine("\tIMPORTANTE! digite solamente los caracteres F o V:");
                    estado2 = char.Parse(Console.ReadLine());
                    if ((estado1 == 'f' && estado2 == 'v') || (estado1 == 'F' && estado2 == 'V') || (estado1 == 'v' && estado2 == 'f') || (estado1 == 'V' && estado2 == 'F'))
                    {
                        Console.WriteLine("\tEl resultado de los estados digitados según la compuerta XOR es: V\n");
                    }
                    else
                    {
                        Console.WriteLine("\tEl resultado de los estados digitados según la compuerta XOR es: F\n");
                    }
                    break;

                case 3://Opción salir
                    Console.Clear();
                    Console.WriteLine("\n\tEjercicio #3, Desafio Práctico");
                    Console.WriteLine("\tPrograma para saber el funcionamiento de compuertas lógicas\n");
                    Console.WriteLine("\tUsted ha escogido salir del programa, tenga buen dia!...\n");
                    break;

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\t*********************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*     Este programa fue diseñado por:       *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*                Marcos                     *");
            Console.WriteLine("\t*                                           *");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n");
            Console.WriteLine("\t--> Fin del Programa");
            Console.Write("\n\tPuede presionar cualquier tecla para cerrar esta ventana...");
            Console.ReadKey();
        }
    }
}
