using System;
using System.Globalization;
using Exercicio.Entities;
using Exercicio.Services;
using System.Collections.Generic;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data ");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int contractInstallments = int.Parse(Console.ReadLine());

            Console.WriteLine("Installments: ");
            InstallmentPayService PayService = new InstallmentPayService();
            var installmentsList = PayService.ProcessInstallments(contractInstallments, contractValue, contractDate);

            foreach (Installment i in installmentsList)
            {
                Console.WriteLine($"{i.DueDate.ToString("dd/MM/yyyy")} - {i.Amount}");
            }
        }
    }
}
