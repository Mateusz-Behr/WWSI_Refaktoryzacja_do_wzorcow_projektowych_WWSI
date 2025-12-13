using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Decorator
{
    public class LoyaltyPointsDecorator : PaymentDecorator
    {
        public LoyaltyPointsDecorator(IPaymentProcessor paymentProcessor) : base(paymentProcessor)
        {
        }

        public override void ProcessPayment(PaymentType type, double amount, string paymentDetails)
        {
            base.ProcessPayment(type, amount, paymentDetails);

            int pointsEarned = (int)(amount * 0.1);
            Console.WriteLine($"[Punkty lojalnościowe] Dodaję {pointsEarned} punktów lojalnościowych za płatność {amount:C}");
        }
    }
}
