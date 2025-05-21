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
            int num;
            do
            {
                Console.WriteLine(" ------------------------------------");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|               PISO 3               |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine(" ------------------------------------");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|               PISO 2               |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine(" ------------------------------------");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|               PISO 1               |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine(" ------------------------------------");
                Console.Write("Que piso desea analizar: ");
                num = int.Parse(Console.ReadLine());
                Console.Clear();

                if (num == 1)
                {
                    Piso1();
                }
                else if (num == 2)
                {
                    Piso2();
                }
                else if (num == 3)
                {
                    Piso3();
                }
                else
                {
                    Console.WriteLine("INGRESE UN VALOR VALIDO");
                }


            }
            while (true);
            Console.ReadKey();
        }
        static void Piso1()
        {
            float tem;
            Random R = new Random();
            tem = R.Next(25, 150);
            Console.WriteLine("\t \t \t \t \t \t ***** PISO 1 *****\t \t \t \t\n");
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                AGUA                |                                    |");
            Console.WriteLine("|            TEMPERATURA             |              SENSORES              |                                    |                                    |");
            Console.WriteLine("|            DEL SECTOR              |              DE  HUMO              |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                 5%                 |                OFF                 |                OFF                 |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------------------------------------");
        }
        static void Piso2()
        {
            float tem;
            Random R = new Random();
            tem = R.Next(25, 150);
            Console.WriteLine("\t \t \t \t \t \t ***** PISO 2 *****\t \t \t \t\n");
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                AGUA                |                                    |");
            Console.WriteLine("|            TEMPERATURA             |              SENSORES              |                                    |                                    |");
            Console.WriteLine("|            DEL SECTOR              |              DE  HUMO              |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                 5%                 |                OFF                 |                OFF                 |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------------------------------------");
        }
        static void Piso3()
        {
            float tem;
            Random R = new Random();
            tem = R.Next(25, 150);
            Console.WriteLine("\t \t \t \t \t \t ***** PISO 3 *****\t \t \t \t\n");
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                AGUA                |                                    |");
            Console.WriteLine("|            TEMPERATURA             |              SENSORES              |                                    |                                    |");
            Console.WriteLine("|            DEL SECTOR              |              DE  HUMO              |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                 5%                 |                OFF                 |                OFF                 |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine("|                                    |                                    |                                    |                                    |");
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
