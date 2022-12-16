using System;

namespace ParesImparesPositivosENegativos_1066
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            double[] valores = { num1, num2, num3, num4, num5, };
            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;

            foreach (var numeros in valores)
            {
                if ((numeros % 2) == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                if (numeros > 0)
                {
                    positivos++;
                }
                else if (numeros < 0)
                {
                    negativos++;
                }
            }
            Console.WriteLine($"{pares} valor(es) par(es)");
            Console.WriteLine($"{impares} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");
        }
    }
}