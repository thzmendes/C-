namespace exercicio_polimorfismo.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double valuePerHour { get; set; }

        public double Payment()
        {
            return Hours * valuePerHour;
        }
    }
}
