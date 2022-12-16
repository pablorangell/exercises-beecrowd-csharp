using System;
using System.Security;

namespace ParOuImpar_1074
{
    public class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());

            for(int i =0; i < quantidade; i++)
            {
                int valores = int.Parse(Console.ReadLine());

                if (valores == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (valores > 0 && valores % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (valores > 0 && valores % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (valores < 0 && valores % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (valores < 0 && valores % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }

        }
    }
}