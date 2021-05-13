using System;
using Exercicio.Entities;
using System.Collections.Generic;

namespace Exercicio.Services
{
    class InstallmentPayService : PaymentService
    {
        public List<Installment> ProcessInstallments(int Installments, double contractValue, DateTime date)
        {
            double installmentValue = contractValue / Installments;
            DateTime newDate = date;
            List<Installment> installmentsList = new List<Installment>();
            for (int c = 1; c <= Installments; c++)
            {
                double quota1 = installmentValue + (installmentValue * 0.01 * c);
                double quota2 = quota1 + (quota1 * 0.02);
                newDate = newDate.AddMonths(1);
                Installment installment = new Installment(newDate, quota2);
                installmentsList.Add(installment);
            }
            return installmentsList;

        }
    }
}
