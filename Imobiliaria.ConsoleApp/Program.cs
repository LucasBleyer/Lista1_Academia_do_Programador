using System;

namespace Imobiliaria.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a largura do terreno: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do terreno: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double resultado = largura * altura;

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
