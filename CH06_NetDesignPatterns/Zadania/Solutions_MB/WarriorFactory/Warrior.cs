using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory
{
    public abstract class Warrior
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Weapon { get; set; }
        public Warrior(string name, int age, string weapon)
        {
            Name = name;
            Age = age;
            Weapon = weapon;
        }

        public abstract void Attack();
    }
}
