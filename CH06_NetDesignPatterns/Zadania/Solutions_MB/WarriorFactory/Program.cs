using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory
{
    class Program
    {
        static void Main()
        {
            Warrior[] warriors = new Warrior[10];

            warriors[0] = Garrison.CreateWarrior("Footman", "Jan", 25, "Sword");
            warriors[1] = Garrison.CreateWarrior("Footman", "Anna", 28, "Axe");
            warriors[2] = Garrison.CreateWarrior("Footman", "Piotr", 30, "Spear");

            warriors[3] = Garrison.CreateWarrior("Horseman", "Krzysztof", 35, "Lance", "Škoda");
            warriors[4] = Garrison.CreateWarrior("Horseman", "Marek", 40, "Sword", "Mustang");
            warriors[5] = Garrison.CreateWarrior("Horseman", "Łukasz", 32, "Lance", "Arab");

            warriors[6] = Garrison.CreateWarrior("Archer", "Tomasz", 27, "Bow");
            warriors[7] = Garrison.CreateWarrior("Archer", "Kasia", 29, "Crossbow");
            warriors[8] = Garrison.CreateWarrior("Archer", "Jacek", 26, "Longbow");
            warriors[9] = Garrison.CreateWarrior("Archer", "Ola", 24, "Crossbow");

            // Przykładowa pętla, żeby wywołać atak
            foreach (var warrior in warriors)
            {
                warrior.Attack();
            }
        }
    }
}
