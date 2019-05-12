
namespace exercicio_heranca_polimorfismo1.Entities
{
    class OutsorcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsorcedEmployee(string name, int hours, double valuePerHour, double addcharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge =addcharge;
        }

        public override double Payment()
        {
           double payment = base.Payment();
           double addcharge = AdditionalCharge + AdditionalCharge* 0.1 ;
           return payment+addcharge;           
        }
    }
}
