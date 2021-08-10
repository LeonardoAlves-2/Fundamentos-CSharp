using System;
using System.Threading;

namespace Calculadora
{
    class Errors
    {
        public static void Value() {
            Console.Clear();
            Console.WriteLine("Por favor insira apenas números! ");
            Thread.Sleep(1250);
        }
        public static void Generic() {
            Console.Clear();
            Console.WriteLine("Ops, algo deu errado !");
            Thread.Sleep(1250);
        }
    }
}