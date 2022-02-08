using System;

namespace SalarioImposto.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário atual: ");
            double salario_atual = Convert.ToDouble(Console.ReadLine());

            double salario_aumento = salario_atual + (salario_atual * 0.15);

            double salario_impostos = salario_aumento - (salario_aumento * 0.08);

            Console.WriteLine("Salário atual: " + salario_atual);
            Console.WriteLine("Salário com aumento de 10%: " + salario_aumento);
            Console.WriteLine("Salário com desconto de 8% dos impostos: " + salario_impostos);
            Console.ReadLine();
        }
    }
}
