using System;
using System.Globalization;

namespace GastoDeCombustivel_1017
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double rendimento = 12;
            double tempo = double.Parse(Console.ReadLine());
            double velocidade = double.Parse(Console.ReadLine());
            double consumoCombustivel = (tempo * velocidade) / rendimento;

            Console.WriteLine(consumoCombustivel.ToString("F3", CultureInfo.InvariantCulture));
            Console.Read();

             
        }
    }
}