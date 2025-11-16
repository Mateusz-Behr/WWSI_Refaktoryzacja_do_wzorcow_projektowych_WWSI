using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Adapter
{
    public class FakeAdult : Adult
    {
        private Teenager _teenager;
        public FakeAdult(Teenager teenager): base(teenager.Name, teenager.Age)
        {
            _teenager = teenager;
            Console.WriteLine($"Utworzono adapter dla {_teenager.Name}. Wiek: {_teenager.Age}");
        }

        public override bool IsAdult()
        {
            Console.WriteLine($"[Adapter] Oszukuje  bramkarza. {_teenager.Name} wygląda na dorosłego.");
            return true;
        }
    }
}
