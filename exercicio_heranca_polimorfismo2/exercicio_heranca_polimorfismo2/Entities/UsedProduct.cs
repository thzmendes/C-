using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_heranca_polimorfismo2.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate {get;set;}

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            ManufactureDate =date;
        }

        public override string PriceTag()
        {
            return Name + " (usado) $"+Price+" "+ManufactureDate.ToString("dd/MM/yyyy");
        }
    }
}
