using System;

namespace CelsiusToFahrenheit.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatura em Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double f = (c * 1.8) + 32;

            Console.Write("Temperatura em Fahrenheit: " + f);
            Console.ReadLine();
        }
    }
}
