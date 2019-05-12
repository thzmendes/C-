using System.Text;

namespace exercicio_heranca_polimorfismo1.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            StringBuilder s1 = new StringBuilder();
            s1.AppendLine("Name:" + Name+" - "+ "$"+Payment().ToString("F2"));
            
            return s1.ToString();
        }

    }
}
