using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace MaiorEPosicao_1080
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();


            for(int i = 0; i < 100; i++)
            {
                valores.Add(int.Parse(Console.ReadLine()));
            }

            int maiorNumero = 0;
            int maiorNumeroLido = 0;
            int numeroLido = 0;

            foreach (var numero in valores)
            {
                numeroLido++;

                if(numero > maiorNumero)
                {
                    maiorNumero = numero;
                    maiorNumeroLido = numeroLido;
                }
            }
            Console.WriteLine(maiorNumero);
            Console.WriteLine(maiorNumeroLido);
        }
    }
}