using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Grenais_1131
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                int vitorasInter = 0;
                int vitoriasGremio = 0;
                int empates = 0;
                int jogos = 0;

                do
                {
                    int[] valores = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));

                    if (valores[0] > valores[1])
                    {
                        vitorasInter++;
                        jogos++;
                    }
                    else if (valores[0] < valores[1])
                    {
                        vitoriasGremio++;
                        jogos++;
                    }
                    else
                    {
                        empates++;
                        jogos++;
                    }

                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    int prosseguirProgram = int.Parse(Console.ReadLine());

                    if (prosseguirProgram == 2)
                    {
                        break;
                    }
                } while (true);

                Console.WriteLine($"{jogos} grenais");
                Console.WriteLine($"Inter:{vitorasInter}");
                Console.WriteLine($"Gremio:{vitoriasGremio}");
                Console.WriteLine($"Empates:{empates}");

                if (vitorasInter > vitoriasGremio)
                {
                    Console.WriteLine("Inter venceu mais");
                }
                else if (vitoriasGremio > vitorasInter)
                {
                    Console.WriteLine("Gremio venceu mais");
                }
            }
        }
    }
}