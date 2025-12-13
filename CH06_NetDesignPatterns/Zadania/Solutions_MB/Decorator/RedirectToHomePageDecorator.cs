using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Decorator
{
    public class RedirectToHomePageDecorator : PaymentDecorator
    {
        public RedirectToHomePageDecorator(IPaymentProcessor paymentProcessor) : base(paymentProcessor)
        {
        }

        public override void ProcessPayment(PaymentType type, double amount, string paymentDetails)
        {
            base.ProcessPayment(type, amount, paymentDetails);

            Console.WriteLine($"[Przekierowanie] Przekierowuję użytkownika na stronę główną sklepu po dokonaniu płatności {amount:C}.");
        }
    }
}
