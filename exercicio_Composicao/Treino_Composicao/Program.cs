using System;
using Treino_Composicao.Entities.Enums;
using System.Globalization;
using Treino_Composicao.Entities;

namespace Treino_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Insira o nome do departamento: ");
            string dept_name = Console.ReadLine();
            Console.WriteLine("Insira as informações do funcionário");
            Console.Write("Nome: ");
            string worker_name = Console.ReadLine();
            Console.Write("Level (Junior, MidLevel, Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base: ");
            double base_salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(dept_name);
            Worker worker = new Worker(worker_name,level,base_salary,department);

            Console.WriteLine("Quantos contratos para esse funcionário: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Entre os dados do contrato #{0}", i);
                Console.Write("Data do contrato: ");
                DateTime x = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valor_hora = double.Parse(Console.ReadLine());
                Console.Write("Total de horas: ");
                int horas = int.Parse(Console.ReadLine());               
                HourContract contract = new HourContract { Date = x, Hours = horas, valuePerHour = valor_hora };
                worker.AddContract(contract);
            }

            Console.WriteLine("Insira um mês e ano para ver o quanto lucrou");
            Console.Write("Mês: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: {0}  Departamento: {1}  Lucro: {2}", worker.Name,worker.Department.Name, worker.Income(ano,month));

            
        }
    }
}
