using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace VariasNotasComValidacao_1118
{
    public class Program
    {
        public static void CalcularNotas()
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

            Console.WriteLine($"media = {(notas.Sum() / 2).ToString("0.00", CultureInfo.InvariantCulture)}");
        }

        private static void Main(string[] args)
        {
            bool prosseguirProgram = true;
            do
            {
                CalcularNotas();
                bool opcaoValida = true;
                while (opcaoValida)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    double valor = double.Parse(Console.ReadLine());
                    if (valor == 2)
                    {
                        prosseguirProgram = false;
                        break;
                    }
                    else if (valor == 1)
                    {
                        CalcularNotas();
                    }
                }
            } while (prosseguirProgram);
        }
    }
}