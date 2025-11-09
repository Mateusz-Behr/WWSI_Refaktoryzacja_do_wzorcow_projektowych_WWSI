using RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Builder
{
    public class ArcherBuilder : WarriorBuilder
    {
        public override void Register(string name, int age)
        {
            warrior = new Archer(name, age,"");
        }

        public override void ChooseWeapon(string weapon)
        {
            warrior.Weapon = weapon;
        }
    }
}
