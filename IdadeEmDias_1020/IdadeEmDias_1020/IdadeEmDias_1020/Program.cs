using System;

namespace IdadeemDias_1020
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int idade, anos, meses, dias, resto;

            idade = int.Parse(Console.ReadLine());

            anos = idade / 365;
            resto = idade % 365;

            meses = resto / 30;
            resto = resto % 30;

            dias = resto;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
            Console.Read();
        }
    }
}