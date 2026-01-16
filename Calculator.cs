using System;

namespace HelloWorldApp
{
    public static class Calculator
    {
        public static void SumAndAverage(string userNumber1, string userNumber2)
        {
            Random random = new Random();


            double num1 = double.TryParse(userNumber1, out var n1)
                ? n1
                : Math.Round(random.NextDouble() * 100);

            double num2 = double.TryParse(userNumber2, out var n2)
                ? n2
                : Math.Round(random.NextDouble() * 100);

            if (num2 == 0)
            {
                Console.WriteLine("Denominador não pode ser zero.");
            }
            else
            {
                double divisao = num1 / num2;
                Console.WriteLine($"A divisão entre {num1} e {num2} é igual a: {divisao}");
            }

            double media = (num1 + num2) / 2;
            Console.WriteLine($"A média entre {num1} e {num2} é igual a: {media}");
        }
    }
}
