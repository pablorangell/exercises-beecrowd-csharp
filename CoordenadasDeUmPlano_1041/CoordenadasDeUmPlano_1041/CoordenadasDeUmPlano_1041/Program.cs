using System;

namespace CoordenadasDeUmPonto_1041
{
    class URI
    {
        static void Main(string[] args)
        {

            double a, b;

            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');


            a = double.Parse(v1[0]);
            b = double.Parse(v1[1]);


            if (a > 0 & b > 0)
            {
                Console.WriteLine("Q1");
            }

            else if (a < 0 & b > 0)
            {
                Console.WriteLine("Q2");
            }

            else if (a < 0 & b < 0)
            {
                Console.WriteLine("Q3");
            }

            else if (a > 0 & b < 0)
            {
                Console.WriteLine("Q4");
            }

            else if (a == 0 & b == 0)
            {
                Console.WriteLine("Origem");


            }

            else if (a != 0 & b == 0)
            {
                Console.WriteLine("Eixo X");

            }

            else if (a == 0 & b != 0)
            {
                Console.WriteLine("Eixo Y");

            }

            Console.ReadLine();
        }
    }
}