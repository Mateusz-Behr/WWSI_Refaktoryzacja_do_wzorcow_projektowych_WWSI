using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Singleton
{
    class Program
    {
        static void Main()
        {
            var vault = Vault.Instance;
            
            //Getting key for the first  time
            Console.WriteLine($"Key: {vault.GetDigitalKey()}");

            //Trying to get key again
            try
            {
                Console.WriteLine($"Key: {vault.GetDigitalKey()}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"$Error: {ex.Message}");
            }
        }
    }
}
