using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory
{
    public class Footman : Warrior
    {
        public Footman(string name, int age, string weapon) : base(name, age, weapon)
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with sword {Weapon}");
        }
    }
}
