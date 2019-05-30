using System;
using System.Globalization;

namespace exercicio_IComparable.Entities
{
    class Funcionario : IComparable
    {
        public string Nome {get;set;}
        public double Salario {get;set;}

        public Funcionario(string csvemployee)
        {
            string[] vect = csvemployee.Split(",");
            Nome = vect[0];
            Salario = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Nome+", "+Salario.ToString("F2",CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("Objeto não é um Funcionário");
            }

            Funcionario other = obj as Funcionario;
            return Salario.CompareTo(other.Salario);
        }
    }
}
