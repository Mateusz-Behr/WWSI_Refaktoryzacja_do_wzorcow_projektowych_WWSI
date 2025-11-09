using RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Builder
{
    public abstract class WarriorBuilder
    {
        protected Warrior warrior;

        public abstract void Register(string name, int age);
        public abstract void ChooseWeapon(string weapon);


        public virtual void Train()
        {
            Console.WriteLine($"Training {warrior.Name} with a {warrior.Weapon} ");
        }
        public Warrior GetResult()
        {
            return warrior;
        }
    }
}
