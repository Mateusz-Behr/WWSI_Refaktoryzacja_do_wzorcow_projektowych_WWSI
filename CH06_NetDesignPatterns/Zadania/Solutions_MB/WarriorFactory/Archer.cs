using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory
{
    public class Archer : Warrior
    {
        public Archer(string name, int age, string weapon) : base(name, age, weapon)
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} shoots with {Weapon}");
        }
    }
}
