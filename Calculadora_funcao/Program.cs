using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcFunction_app
{
    public static class Program
    {
        static void Main(string[] args)
        {
            float result;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetWindowSize(50, 30);
            Console.Title = "CALCULADORA POR FUNÇÕES";

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Defina a operação Matemática");
            Console.WriteLine(" + --> SOMA \n - --> SUBTRAÇÃO \n * --> MULTIPLICAÇÃO \n / --> DIVISÃO");
            Console.WriteLine("----------------------------------------");
            char oper = char.Parse(Console.ReadLine());           

            
            switch (oper)
            {
                 case '+': 
                    result = Sum(); 
                    Console.WriteLine($"Resultado da Soma: {result}");
                    Console.ReadKey();
                 break;
                 case '-':
                     result = Sub();
                     Console.WriteLine($"Resultado da Subtração: {result}");
                     Console.ReadKey();
                    break;
                 case '*':
                     result = Mult();
                     Console.WriteLine($"Resultado da Multiplicação: {result}");
                     Console.ReadKey();
                    break;
                 case '/':
                     result = Div();
                     Console.WriteLine($"Resultado da Divisão: {result}");
                     Console.ReadKey();
                    break;
            }
        }                    
        static float Sum()
        {
            Console.Clear();
            Console.WriteLine("Digite o Valor 1:");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor 2:");
            float value2 = float.Parse(Console.ReadLine());

            return value1 + value2;
        }
        static float Sub()
        {
            Console.Clear();
            Console.WriteLine("Digite o Valor 1:");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor 2:");
            float value2 = float.Parse(Console.ReadLine());

            return value1 - value2;
        }
        static float Mult()
        {
            Console.Clear();
            Console.WriteLine("Digite o Valor 1:");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor 2:");
            float value2 = float.Parse(Console.ReadLine());

            return value1 * value2;
        }
        static float Div()
        {
            Console.Clear();
            Console.WriteLine("Digite o Valor 1:");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor 2:");
            float value2 = float.Parse(Console.ReadLine());

            return value1 / value2;
        }

    }
       
}