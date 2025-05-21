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
                
            }
            while (true);
            Console.ReadKey();
        }
    }
}
