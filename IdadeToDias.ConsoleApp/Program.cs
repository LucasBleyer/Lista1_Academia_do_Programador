using System;

namespace IdadeToDias.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int dias_vividos = idade * 365;

            Console.Write(nome + " você já viveu " + dias_vividos + " dias!");

            Console.ReadLine();
        }
    }
}
