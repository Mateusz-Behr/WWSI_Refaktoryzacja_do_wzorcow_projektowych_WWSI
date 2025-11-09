using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Builder
{
    public class InfantryBuilder : WarriorBuilder
    {
        public override void Register(string name, int age)
        {
            warrior = new Infantry(name, age, "");
        }

        public override void ChooseWeapon(string weapon)
        {
            warrior.Weapon = weapon;
        }
    }
}
