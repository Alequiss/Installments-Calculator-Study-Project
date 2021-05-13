using Exercicio.Entities;
using System.Collections.Generic;
using System;

namespace Exercicio.Services
{
    interface PaymentService
    {
        public List<Installment> ProcessInstallments(int Installments, double contractValue, DateTime date);
    }
}
