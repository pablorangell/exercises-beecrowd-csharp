using System;

namespace SortSimples_1042
{
    class URI
    {
        static void Main(string[] args)
        {
            int maiorAB, maiorABC, menorABC;
            string[] valores = Console.ReadLine().Split();

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);

            if (a > b && a > c)
            {
                maiorABC = a;
            }
            else if (b > c && b > a)
            {
                maiorABC = b;
            }
            else
                maiorABC = c;



            if (a < b && a > c)
            {
                maiorAB = a;
            }
            else if (b < c && b > a)
            {
                maiorAB = b;
            }
            else if (a > b && a < c)
            {
                maiorAB = a;
            }

            else if (b > c && b < a)
            {
                maiorAB = b;
            }
            else
                maiorAB = c;



            if (a < c && a < b)
            {
                menorABC = a;
            }
            else if (b < a && b < c)
            {
                menorABC = b;
            }
            else
            {
                menorABC = c;
            }
                
            Console.WriteLine(menorABC + "\n" + maiorAB + "\n" + maiorABC + "\n");
            Console.WriteLine(a + "\n" + b + "\n" + c);
            Console.Read();
        }
    }
}