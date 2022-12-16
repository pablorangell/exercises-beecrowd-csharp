using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace ValidacaoDeNota_1117
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            do
            {
                double valor = double.Parse(Console.ReadLine());

                if (valor >= 0 && valor <= 10)
                {
                    notas.Add(valor);
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            } while (notas.Count < 2);

            Console.WriteLine($"media = {(notas.Sum() / 2).ToString("0.##", CultureInfo.InvariantCulture)}");
        }
    }
}