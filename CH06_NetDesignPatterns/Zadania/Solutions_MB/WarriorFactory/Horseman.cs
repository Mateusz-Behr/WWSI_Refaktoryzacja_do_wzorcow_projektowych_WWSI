using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory
{
    public class Horseman : Warrior
    {
        public string Horse { get; set; }
        public Horseman(string name, int age, string weapon, string horse) : base(name, age, weapon)
        {
            Horse = horse;
        } 
        public void Charge()
        {
            Console.WriteLine($"{Name} performs a charge.");
        }
    }
}
