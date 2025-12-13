using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Decorator
{
    public abstract class PaymentDecorator : IPaymentProcessor
    {
        protected IPaymentProcessor _paymentProcessor;

        public PaymentDecorator(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public virtual void ProcessPayment(PaymentType type, double amount, string paymentDetails)
        {
            _paymentProcessor.ProcessPayment(type, amount, paymentDetails);
        }
    }
}
