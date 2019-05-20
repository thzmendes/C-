using System;
using exercicio_exceptions2.Entities;
using exercicio_exceptions2.Entities.Exceptions;

namespace exercicio_exceptions2
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Insira os dados da conta");
                Console.WriteLine("Número da conta: ");
                int numConta = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Saldo Inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                Console.WriteLine("Limite de saque: ");
                double limiteSaque = double.Parse(Console.ReadLine());
                Account acc = new Account(numConta, nome, saldo, limiteSaque);
                Console.WriteLine(acc.SaldoAtual());
                Console.WriteLine();
                Console.WriteLine("Insira o valor para saque: ");
                double saque = double.Parse(Console.ReadLine());
                acc.Saque(saque);
                Console.WriteLine(acc.SaldoAtual());
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formatação: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: "+e.Message);
            }
        }
    }
}
