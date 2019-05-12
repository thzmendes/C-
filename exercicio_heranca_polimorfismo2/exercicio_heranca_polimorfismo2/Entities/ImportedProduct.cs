namespace exercicio_heranca_polimorfismo2.Entities
{
    sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            double value = Price+CustomsFee;
            string s1= Name+" $"+value + " (Taxa de Importação: $"+ CustomsFee+")";
            
            return s1;
        }
    }
}
