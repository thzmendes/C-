using exercicio_Interface.Servicos;
using System.Globalization;
using System.Text;

namespace exercicio_Interface.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
       
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment => BasicPayment + Tax;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("INVOICE:");
            sb.AppendLine("Basic Payment: "+BasicPayment);
            sb.AppendLine("Tax: "+Tax);
            sb.AppendLine("Total Payment: "+TotalPayment);
            return sb.ToString();
        }
    }
}