using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -- Symulacja sklepu (wzorzec Dekorator).");
            Console.WriteLine("Dla płatności kartą zostaną uruchomione dekoratory.");

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");

            IPaymentProcessor shop = new Shop();

            while (true)
            {
                Console.WriteLine("-----");
                Console.WriteLine("Podaj kwotę zamówienia (np. 100) lub 'exit' aby zakończyć.");
                string amountInput = Console.ReadLine();

                if (amountInput.ToLower() == "exit")
                {
                    break;
                }

                if (!double.TryParse(amountInput, NumberStyles.Any, CultureInfo.CurrentCulture, out double amount))
                {
                    Console.WriteLine("Nieprawidłowa kwota. Spróbuj ponownie.");
                    continue;
                }

                Console.WriteLine("\nWybierz metodę płatności:");
                Console.WriteLine("1. Karta kredytowa");
                Console.WriteLine("2. PayPal");
                Console.WriteLine("3. BLIK");
                Console.Write("Twój wybór (1-3): ");
                string paymentChoice = Console.ReadLine();

                PaymentType selectedPaymentType;
                string paymentDetails = "";

                switch (paymentChoice)
                {
                    case "1":
                        selectedPaymentType = PaymentType.CreditCard;
                        Console.Write("Podaj numer karty: ");
                        paymentDetails = Console.ReadLine();
                        break;

                    case "2":
                        selectedPaymentType = PaymentType.PayPal;
                        Console.Write("Podaj adres e-mail PayPal: ");
                        paymentDetails = Console.ReadLine();
                        break;
                    case "3":
                        selectedPaymentType = PaymentType.Blik;
                        paymentDetails = "(kod BLIK jest podawany w aplikacji bankowej)";
                        break;

                    default:
                        Console.WriteLine("Nieprawidłowy wybór metody płatności. Spróbuj ponownie.");
                        continue;

                }

                IPaymentProcessor currentProcessor = shop;

                    if (selectedPaymentType == PaymentType.CreditCard)
                    {
                        Console.WriteLine("Wykryto płatność kartą. Uruchamiam dodatkowe opcje (dekoratory).");

                        currentProcessor = new SMSNotificationDecorator(currentProcessor);
                        currentProcessor = new LoyaltyPointsDecorator(currentProcessor);
                        currentProcessor = new RedirectToHomePageDecorator(currentProcessor);
                    }
                    else
                    {
                        Console.WriteLine("\n -- Płatność inna niż kartą. Używam standardowego procesu. --");
                    }

                Thread.Sleep(500);

                currentProcessor.ProcessPayment(selectedPaymentType, amount, paymentDetails);

                Console.WriteLine("\n-----");
                Console.WriteLine("Płatność zakończona. Wykonano wszystkie kroki.");
                Console.WriteLine("-----");
            }

            Console.WriteLine("\nProgram zakończył działanie.");
            Console.ReadKey();
        }
    }
}
