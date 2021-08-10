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
            short Cont = 1;
            char type = 's';
            Double time = 0;
            try
            {
                Double timeT;
                char typeT;
                do {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("'S' para segundos\n'M' para minutos\n'0' para sair");
                Console.Write("Opção: ");
                typeT = char.Parse(Console.ReadLine());
                if (typeT == '0')
                {
                    System.Environment.Exit(0);
                }
                type = typeT;
                if(!(type=='s'||type=='m'))
                {
                    Console.Clear();
                    Console.WriteLine("Insira uma opção válida");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                }
                } while(!(typeT=='s'||typeT=='m'));
                Console.Write("Quanto tempo deseja cronômetrar? ");
                timeT = Double.Parse(Console.ReadLine());

                
                time = timeT;
                Console.Clear();
                Console.WriteLine("Como gostaria da sua contagem?\n 1- Progressiva\n 2- Regressiva\n 3- Voltar ao menu");
                short ContT = short.Parse(Console.ReadLine());
                while(ContT>3||Cont<1){
                    Console.WriteLine("Insira uma opção válida");
                    ContT = short.Parse(Console.ReadLine());
                }
                Cont = ContT;
                if(Cont==3)
                {
                    Menu();
                }
            } catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Insira os valores corretamente");
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Menu();
            } catch(Exception)
            {
                Console.Clear();
                Console.WriteLine("Insira os valores corretamente");
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Menu();
            }

            Double multiplier = 1;
            if (type == 'm')
            {
                multiplier = 60;
            }
            bool esCont = false;
            if(Cont==2)
            {
                esCont = true;
            }
            start(time * multiplier, esCont);
        }

        static void start(Double time, bool cont)
        {
            Double currentTime = 0;
            if (cont == false){
                while (currentTime != time && time > currentTime)
                {
                    Console.Clear();
                    currentTime += 0.1;
                    Console.WriteLine(currentTime.ToString("F2"));
                    Thread.Sleep(0100);
                }
            } else if (cont == true){
                 while (time != currentTime && currentTime < time)
                {
                    Console.Clear();
                    Console.WriteLine(time.ToString("F2"));
                    Thread.Sleep(0100);
                    time-= 0.1;
                }
            }
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado\nPressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
        }
    }
}
