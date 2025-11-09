using RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Builder
{
    public class HorsemanBuilder : WarriorBuilder
    {
        public override void Register(string name, int age)
        {
            warrior = new Horseman(name, age, "", "");
        }

        public void SetHorse(string horseName)
        {
            ((Horseman)warrior).Horse = horseName;
        }

        public override void ChooseWeapon(string weapon)
        {
            warrior.Weapon = weapon;
        }

        public override void Train()
        {
            Console.WriteLine($"Training horseman {warrior.Name} with a {warrior.Weapon} riding a {((Horseman)warrior).Horse}");
        }
    }
}

