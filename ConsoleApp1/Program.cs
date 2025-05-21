using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void Pisos()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.WriteLine("\t=================================");
                Console.WriteLine("\t*****SISTEMA CONTRA INCENDIOS*****    ");
                //Console.WriteLine("\t=================================\n");
                Console.ResetColor();
                Console.WriteLine(" ---------------------------------------");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\tPISO 3\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine(" ---------------------------------------");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\tPISO 2\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine(" ---------------------------------------");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\tPISO 1\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t|");
                Console.WriteLine(" ---------------------------------------\n");

                string opcion;
                Console.WriteLine("INGRESE EL PISO A INSPECCIONAR:  ");
                opcion = Console.ReadLine();


                if (opcion == "1")
                {
                    Piso1();

                }
                else if (opcion == "2")
                {
                    Piso2();
                }
                else if (opcion == "3")
                {
                    Piso3();
                }
                else
                {
                    Console.WriteLine("INGRESE UN VALOR VALIDO");
                }

                Console.ReadKey();

            }

            
        }
        static void Piso1()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=========================================");
            Console.WriteLine("\t\tPISO 1");
            Console.WriteLine("=========================================\n");
            Console.ResetColor();
            float tem;
            Random R = new Random();
            tem = R.Next(20, 150);
            float humo;
            Random R1 = new Random();
            humo = R1.Next(0, 51);
            Console.WriteLine("HOLA Piso 1");
        }
        static void Piso2()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=========================================");
            Console.WriteLine("\t\tPISO 2");
            Console.WriteLine("=========================================\n");
            Console.ResetColor();
            float tem;
            Random R = new Random();
            tem = R.Next(20, 150);
            float humo;
            Random R1 = new Random();
            humo = R1.Next(0, 51);
            Console.WriteLine("HOLA Piso 2");
        }
        static void Piso3()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=========================================");
            Console.WriteLine("\t\tPISO 3");
            Console.WriteLine("=========================================\n");
            Console.ResetColor();
            float tem;
            Random R = new Random();
            tem = R.Next(20, 150);
            float humo;
            Random R1 = new Random();
            humo = R1.Next(0, 51);
            Console.WriteLine("HOLA Piso 3");
        }

    }
}
