using System;

namespace TempoDeJogo_1046
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] horas = Console.ReadLine().Split();
            int horaInicial, horaFinal, i = 0;

            horaInicial= int.Parse(horas[0]);
            horaFinal= int.Parse(horas[1]);

            if (horaInicial == horaFinal)
            {
                i = 24;
                Console.WriteLine("O JOGO DUROU " + i + " HORA(S)");
                return;
            }

            if (horaInicial < horaFinal)
            {
                while (horaInicial < horaFinal)
                {
                    horaInicial++;
                    i++;
                }
            }

            if (horaInicial > horaFinal)
            {
                while (horaInicial > horaFinal)
                {
                    horaInicial++;
                    i++;
                    if (horaInicial == 24)
                    {
                        horaInicial = 0;

                        if (horaInicial < horaFinal)
                        {
                            while (horaInicial < horaFinal)
                            {
                                horaInicial++;
                                i++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("O JOGO DUROU " + i + " HORA(S)");
        }
    }
}
