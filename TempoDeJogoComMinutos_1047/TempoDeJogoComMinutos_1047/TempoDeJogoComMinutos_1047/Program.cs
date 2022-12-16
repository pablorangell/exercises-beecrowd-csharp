using System;

namespace TempoDeJogoComMinutos_1047
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] horas = Console.ReadLine().Split();

            string horaInicial, horaFinal;

            horaInicial = String.Join(":", horas[0], horas[1]);
            horaFinal = String.Join(":", horas[2], horas[3]);

            var inicioJogo = TimeSpan.Parse(horaInicial);
            var finalJogo = TimeSpan.Parse(horaFinal);

            int diferença = TimeSpan.Compare(inicioJogo, finalJogo);

            if (diferença == 0)
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");

            if (diferença == -1)
            {
                TimeSpan intervalo1 = finalJogo - inicioJogo;
                double totalMinutes = intervalo1.TotalMinutes;

                double i = Math.Floor(totalMinutes / 60);
                double ii = (totalMinutes % 60);
                Console.WriteLine("O JOGO DUROU " + i.ToString("F0") + " HORA(S) E " + ii + " MINUTO(S)");
            }

            if (diferença == 1)
            {
                TimeSpan intervalo1 = finalJogo - inicioJogo;
                double totalMinutes = intervalo1.TotalMinutes + 1440;

                double i = Math.Floor(totalMinutes / 60);
                double ii = (totalMinutes % 60);
                Console.WriteLine("O JOGO DUROU " + i.ToString("F0") + " HORA(S) E " + ii + " MINUTO(S)");

            }
        }
    }
}