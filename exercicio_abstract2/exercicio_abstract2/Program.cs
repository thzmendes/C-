using exercicio_abstract2.Entities;
using System;
using System.Collections.Generic;

namespace exercicio_abstract2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.WriteLine("Número de contribuintes: ");
            int num_taxpayers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num_taxpayers; i++)
            {
                Console.WriteLine("Insira os dados do contribuinte #{0}: ", i);
                Console.WriteLine("Pessoa Física ou Jurídica? (f/j)");
                char type = char.Parse(Console.ReadLine());
                switch (type)
                {
                    case 'f':
                        Console.WriteLine("Nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Renda anual: ");
                        double annualIncome = double.Parse(Console.ReadLine());
                        Console.WriteLine("Gastos com saúde: ");
                        double health = double.Parse(Console.ReadLine());
                        list.Add(new Individual(nome, annualIncome, health));
                        break;
                    case 'j':
                        Console.WriteLine("Nome: ");
                        string nome1 = Console.ReadLine();
                        Console.WriteLine("Renda anual: ");
                        double annualIncome1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Número de Funcionários: ");
                        int num_func = int.Parse(Console.ReadLine());
                        list.Add(new Company(nome1, annualIncome1, num_func));
                        break;
                    default: Console.WriteLine("Dados Inválidos, tente novamente."); break;
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
            Console.WriteLine("Impostos arrecadados: "+total);

        }
    }
}
