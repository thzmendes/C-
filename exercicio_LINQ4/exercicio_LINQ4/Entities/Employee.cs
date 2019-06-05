using System;

namespace exercicio_LINQ4.Entities
{
    internal class Employee
    {
        public string Name {get;set;}
        public string Email {get;set;}
        public double Salary {get;set;}

        public Employee(string name, string email, double salary)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Salary = salary;
        }

        public override string ToString()
        {
            return Name +", "+ Email +", "+Salary.ToString("F2");
        }
    }
}