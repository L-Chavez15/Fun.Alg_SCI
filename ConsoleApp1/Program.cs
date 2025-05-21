using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pisos();
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
            tem = R.Next(20, 500);
            float humo;
            Random R1 = new Random();
            humo = R1.Next(0, 51);
            Datos(tem);
            Evacuación(tem,humo);

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
            tem = R.Next(20, 500);
            float humo;
            Random R1 = new Random();
            humo = R1.Next(0, 51);
            Datos(tem);
            Evacuación(tem, humo);
        }
        static void Piso3()
        {
            Console.Clear();
            float tem;
            Random R = new Random();
            tem = R.Next(20, 500);
            float humo;
            Random R1 = new Random();
            humo = R1.Next(0, 51);
            Datos(tem);
            Evacuación(tem, humo);
        }
        static void Datos (float temp)
        {
            Console.WriteLine("Temperatura: ");
            if (temp > 56)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (temp > 35)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(temp + "°C");
            Console.ResetColor ();

            
            Console.WriteLine("SENSORES: ");
            
            if (temp > 50)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("ENCENDIDOS\n");
                Console.ResetColor();
            }
            
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("APAGADOS\n");
                Console.ResetColor();
            }
            Console.WriteLine("LUCES ESTROBOSCÓPICAS: ");

            if (temp > 50)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("ENCENDIDOS\n");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("APAGADOS\n");
                Console.ResetColor();
            }


        }
        static void Evacuación(float temp, float sensores)
        {
            Console.WriteLine("\nRecomendación:");
            if (temp > 80 || sensores > 70)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡EVACUAR INMEDIATAMENTE!");
                for (int i = 0; i < 100; i++)
                {
                    Console.Beep(1000, 300); 
                    Thread.Sleep(200);       
                }
            }
            else if (temp > 70 || sensores > 50)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("¡Posible incendio! Verificar área");
            }
            else if (temp > 50 || sensores > 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Condiciones anormales - Monitorear");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Todo normal");
            }
            Console.ResetColor();
        }

    }
}
