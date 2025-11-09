using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory
{
    public class Infantry : Warrior
    {
        public Infantry(string name, int age, string weapon) : base(name, age, weapon)
        {

        }

        public void Storm()
        {
            Console.WriteLine($"{Name} storms the enemy.");
        }
    }
}
