using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory
{
    public static class Garrison
    {
        public static Warrior CreateWarrior(string profession, string name, int age, string weapon, string horse = null)
        {
            switch (profession.ToLower())
            {
                case "footman":
                    return new Footman(name, age, weapon);
                case "archer":
                    return new Archer(name, age, weapon);
                case "horseman":
                    return new Horseman(name, age, weapon, horse);
                default:
                    throw new ArgumentException("Unknown profession");
            }
        }
    }
}
