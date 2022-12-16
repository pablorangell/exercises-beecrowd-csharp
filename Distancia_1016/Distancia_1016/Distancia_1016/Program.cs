using System;
using System.Globalization;

namespace Distancia_1016
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int distancia;
            int tempo;

            distancia = int.Parse(Console.ReadLine());
            tempo = distancia * 2;

            Console.WriteLine(tempo + " minutos");
            Console.Read();
        }
    }
}