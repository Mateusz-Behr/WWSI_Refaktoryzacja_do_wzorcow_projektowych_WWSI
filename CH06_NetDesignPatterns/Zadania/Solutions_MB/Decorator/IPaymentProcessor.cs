using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Decorator
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(PaymentType type, double amount, string paymentDetails);
    }
}
