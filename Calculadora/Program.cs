using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu\n 1- Soma\n 2- Subtração\n 3- Divisão\n 4- Multiplicação\n 5- Sair");
            Console.WriteLine("-----------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = 0;
            try
            {
                short resT = short.Parse(Console.ReadLine());
                res = resT;
            } catch(System.FormatException) {
                Errors.Value();
                Menu();
            }
            switch (res)
            {
                case 1: Operations.Soma(); break;
                case 2: Operations.Subtracao(); break;
                case 3: Operations.Divisao(); break;
                case 4: Operations.Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
    }
}