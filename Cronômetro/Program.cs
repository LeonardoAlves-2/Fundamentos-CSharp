using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            char Cont = 'P';
            char type = 's';
            int time = 0;
            try
            {
                Console.Clear();
                Console.WriteLine("S = Segundo => 10s = 10 segundos\nM = Minuto => 1m = 1 minuto\n0 = sair");
                Console.WriteLine("Quanto tempo deseja contar?");
                String data = Console.ReadLine().ToLower();
                if (data == "0")
                {
                    System.Environment.Exit(0);
                }
                char typeT = char.Parse(data.Substring(data.Length - 1, 1));
                int timeT = int.Parse(data.Substring(0, data.Length - 1));
                time = timeT;
                type = typeT;
                Console.WriteLine("Como gostaria da sua contagem?\n P- Progressiva\n R- Regressiva");
                char ContT = char.Parse(Console.ReadLine().ToLower());
                Cont = ContT;
            } catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Por favor insira os valores corretamente \n Exemplo: =30s");
                Thread.Sleep(1250);
                Menu();
            }

            int multiplier = 1;
            if (type == 'm')
            {
                multiplier = 60;
            }
            bool esCont = false;
            if(Cont=='r')
            {
                esCont = true;
            }
            preStart(time * multiplier, esCont);
        }

        static void preStart(int time, bool cont)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(2500);

            start(time, cont);
        }

        static void start(int time, bool cont)
        {
            int currentTime = 0;
            if (cont == false){
                while (currentTime != time)
                {
                    Console.Clear();
                    currentTime++;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);
                }
            } else if (cont == true){
                 while (time != currentTime)
                {
                    Console.Clear();
                    Console.WriteLine(time);
                    Thread.Sleep(1000);
                    time--;
                }
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
