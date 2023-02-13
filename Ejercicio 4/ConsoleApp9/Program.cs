using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            double s, h,he,ss;

            Console.WriteLine("digite las horas de trabajo que realizo");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("digite su salario diario");
            s = double.Parse(Console.ReadLine());


            if (h > 30)
            {
                he = h - 30;
                ss = he*1.25+30*s;
                Console.WriteLine("\tUsted a trabajado la cantidad de" + " " + he + " " + "horas extra, por ende su salario es de" +"  "+ ss + "$");

            }
            else
            {
                ss = h * s;
                Console.WriteLine("\tUsted a trabajado el minimo indispensable por ende su salario base de" +" "+ ss + "$" +" "+ "se mantiene");
            }

            Console.WriteLine("\t\t\t\t\t**************************************");
            Console.WriteLine("\t\t\t\t\t*        UNIVERSIDAD DON BOSCO       *");
            Console.WriteLine("\t\t\t\t\t*             Ejercicio 4            *");
            Console.WriteLine("\t\t\t\t\t*   Douglas Adrian Urquilla Escobar  *");
            Console.WriteLine("\t\t\t\t\t*                                    *");
            Console.WriteLine("\t\t\t\t\t**************************************");
            Console.ReadKey();
        }
    }
}
