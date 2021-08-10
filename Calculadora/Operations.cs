using System;

namespace Calculadora
{
    class Operations
    {
        public static void Soma()
        {
            try
            {
                Console.Clear();
                Console.Write("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());
                Console.Write("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());
            
                Console.WriteLine("");
                float resultado = v1 + v2;
                Console.WriteLine($"O resultado da soma é {resultado}");
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            } catch(System.FormatException) {
                Errors.Value();
                Soma();
            } catch(Exception) {
                Errors.Generic();
                Soma();
            }
            Program.Menu();
        }

        public static void Subtracao()
        {
            try
            {
                Console.Clear();
                Console.Write("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());
                Console.Write("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());
            
                Console.WriteLine("");
                float resultado = v1 - v2;
                Console.WriteLine($"O resultado da subtração é {resultado}");
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            } catch(System.FormatException) 
            {
                Errors.Value();
                Subtracao();
            } catch(Exception) {
                Errors.Generic();
                Subtracao();
            }
            Program.Menu();
        }

        public static void Divisao()
        {
            try
            {
                Console.Clear();
                Console.Write("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());
                Console.Write("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());
            
                Console.WriteLine(""); 
                float resultado = v1 / v2;
                Console.WriteLine($"O resultado da divisão é {resultado}");
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            } catch (System.FormatException)
            {
                Errors.Value();
                Divisao();
            }  catch(Exception) {
                Errors.Generic();
                Divisao();
            }
            Program.Menu();
        }

        public static void Multiplicacao()
        {
            try
            {
                Console.Clear();
                Console.Write("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());
                Console.Write("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());
           
                Console.WriteLine("");
                float resultado = v1 * v2;
                Console.WriteLine("O resultado da multiplicação é " + (v1 * v2));
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            } catch(System.FormatException)
            {
                Errors.Value();
                Multiplicacao();
            } catch(Exception) {
                Errors.Generic();
                Multiplicacao();
            }
            Program.Menu();     
        }
    }
}