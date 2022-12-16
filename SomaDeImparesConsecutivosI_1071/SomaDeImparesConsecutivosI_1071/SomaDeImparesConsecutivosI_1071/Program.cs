using System;
using System.Collections.Generic;

namespace SomaDeImparesConsecutivosI_1071
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();
            int soma = 0;

            for (int i = 0;i < 2; i++)
            {
                valores.Add(int.Parse(Console.ReadLine()));
            }

            valores.Sort();

            for (int i = (valores[0] + 1); i < valores[1]; i++)
            {
                if ((i % 2) != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
