using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Decorator
{
    public class Shop : IPaymentProcessor
    {
        public void ProcessPayment(PaymentType type, double amount, string paymentDetails)
        {
            Console.WriteLine($"\nPrzetwarzanie płatności w sklepie na kwotę {amount:C}.");

            switch (type)
            {
                case PaymentType.CreditCard:
                    Console.WriteLine($"Realizuję płatność kartą kredytową: {paymentDetails} na kwotę {amount:C}.");
                    break;

                case PaymentType.PayPal:
                    Console.WriteLine($"Realizuję płatność za pomocą PayPal: {paymentDetails} na kwotę {amount:C}.");
                    break;

                case PaymentType.Blik:
                    Console.WriteLine($"Realizuję płatność za pomocą BLIK {paymentDetails} na kwotę {amount:C}.");
                    break;

                default:
                    Console.WriteLine("Nieznany typ płatności.");
                    break;
            }

            Console.WriteLine("Płatność zakończona.");
        }
    }
}
