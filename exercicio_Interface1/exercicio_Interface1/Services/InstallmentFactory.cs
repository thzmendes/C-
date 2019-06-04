using System;
using exercicio_Interface1.Entities;

namespace exercicio_Interface1.Services
{
    internal static class InstallmentFactory
    {
        public static void CreateParcels(Contract contract, int numInstallments, ITaxService service)
        {
            for (var i = 1; i <= numInstallments; i++)
            {
                var amount = contract.TotalValue / numInstallments;
                var totalAmount = service.Tax(amount);
                var timeSpan = new TimeSpan(31, 0, 0, 0);
                contract.ListIntallments.Add(new Installments(totalAmount, contract.Date + timeSpan * i));
            }
        }
    }
}