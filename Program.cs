using ConsoleApp1;
using System;

namespace HelloWorldApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            // // Calculator:
            //Console.WriteLine("Digite o primeiro numero: (deixe em branco para aleatório) ");
            //string userNumber1 = Console.ReadLine();

            //Console.WriteLine("Digite o segundo numero: (deixe em branco para aleatório)");
            //string userNumber2 = Console.ReadLine();

            //Calculator.SumAndAverage(userNumber1, userNumber2);

            // // StringOperations:
            Console.WriteLine("Digite sua palavra ou frase:");
            string userText = Console.ReadLine();

            int charactersCount = StringOperations.StringCharCounter(userText);

            Console.WriteLine($"Total caracteres: {charactersCount}");

            

        }
    }
}
