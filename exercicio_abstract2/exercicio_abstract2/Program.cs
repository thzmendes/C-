using System;
using System.Collections.Generic;
using exercicio_abstract2.Entities;

namespace exercicio_abstract2
{
    internal class Program
    {
        private static void Main()
        {
            var list = new List<TaxPayer>();
            Console.WriteLine("Número de contribuintes: ");
            var numTaxpayers = int.Parse(Console.ReadLine());
            for (var i = 1; i <= numTaxpayers; i++)
            {
                Console.WriteLine("Insira os dados do contribuinte #{0}: ", i);
                Console.WriteLine("Pessoa Física ou Jurídica? (f/j)");
                var type = char.Parse(Console.ReadLine());
                switch (type)
                {
                    case 'f':
                        Console.WriteLine("Nome: ");
                        var nome = Console.ReadLine();
                        Console.WriteLine("Renda anual: ");
                        var annualIncome = double.Parse(Console.ReadLine());
                        Console.WriteLine("Gastos com saúde: ");
                        var health = double.Parse(Console.ReadLine());
                        list.Add(new Individual(nome, annualIncome, health));
                        break;
                    case 'j':
                        Console.WriteLine("Nome: ");
                        var nome1 = Console.ReadLine();
                        Console.WriteLine("Renda anual: ");
                        var annualIncome1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Número de Funcionários: ");
                        var numFunc = int.Parse(Console.ReadLine());
                        list.Add(new Company(nome1, annualIncome1, numFunc));
                        break;
                    default:
                        Console.WriteLine("Dados Inválidos, tente novamente.");
                        break;
                }
            }

            Console.WriteLine();

            double total = 0;
            Console.WriteLine("Impostos pagos");
            foreach (var l in list)
            {
                Console.WriteLine(l.Name + ": $ " + l.Tax().ToString("F2"));
                total += l.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("Impostos arrecadados: " + total);
        }
    }
}