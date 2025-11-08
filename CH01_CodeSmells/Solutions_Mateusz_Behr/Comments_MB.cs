using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class Transaction
    {
        public bool VerifyDetails()
        {

            return true;
        }
    }

    public class PaymentProcessor
    {
        public void PerformTransaction(Transaction transaction)
        {
            if (VerifyTransactionDetails(transaction))
            {
                ProcessPayment(transaction);
                UpdateAccount(transaction);
                CreateReceipt(transaction);
            }
        }

        private bool VerifyTransactionDetails(Transaction transaction)
        {
            return true;
        }

        private void ProcessPayment(Transaction transaction)
        {
            //Logika realizacji płatności
        }

        private void UpdateAccount(Transaction transaction)
        {
            //Logika aktualizacji stanu konta
        }

        private void CreateReceipt(Transaction transaction)
        {
            //Logika tworzenia potwierdzenia
        }

    }
}

//1. Zastąp komentarze bardziej opisowymi nazwami metod.
// 1. Wyodrębnij bloki kodu do osobnych metod.
