using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public interface IPaymentFeeStrategy
    {
        decimal DeterminePaymentFee(decimal amount);
    }

    public class CreditCardFeeStrategy : IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount)
        {
            return amount * 0.02m;
        }
    }

    public class PayPallFeeStrategy : IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount)
        {
            return amount * 0.03m;
        }
    }

    public class BankTransferFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount)
        {
            return amount * 0.01m;
        }
    }
    public class Payment
    {
        private readonly IPaymentFeeStrategy _paymentFeeStrategy;

        public Payment(IPaymentFeeStrategy paymentFeeStrategy)
        {
            _paymentFeeStrategy = paymentFeeStrategy;
        }

        public decimal DeterminePaymentFee(decimal amount)
        {
            return _paymentFeeStrategy.DeterminePaymentFee(amount);
        }
    }
}
//1. Utwórz interfejs IPaymentFeeStrategy z metodą DeterminePaymentFee.
// 1. Utwórz osobne klasy implementujące IPaymentFeeStrategy dla każdej metody płatności (CreditCardFeeStrategy, PayPalFeeStrategy, BankTransferFeeStrategy).
// 1. Zamień instrukcje switch na wybór odpowiedniej strategii, wstrzykując strategię do klasy Payment.