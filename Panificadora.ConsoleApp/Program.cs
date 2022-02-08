using System;

namespace Panificadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de pães franceses no dia: ");
            double pao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantidade de broas no dia: ");
            double broa = Convert.ToDouble(Console.ReadLine());

            double total_pao = pao * 0.12;
            double total_broa = broa * 1.50;

            double total_padaria = (total_pao + total_broa);
            double poupanca = total_padaria * 0.1;
            double carteira = total_padaria - poupanca;

            Console.WriteLine("Total Arrecado: R$" + total_padaria.ToString());
            Console.WriteLine("Total a ser Armazenado: R$ {0}", poupanca.ToString("N2"));
            Console.WriteLine("Carteira: R$ {0}", carteira.ToString("N2"));
            Console.ReadLine();
        }
    }
}
