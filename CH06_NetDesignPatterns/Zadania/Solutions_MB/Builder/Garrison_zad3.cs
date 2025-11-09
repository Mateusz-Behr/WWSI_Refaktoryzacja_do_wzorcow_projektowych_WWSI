using RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Builder
{
    public class GarrisonZad3
    {
        public Warrior TrainWarrior(string profession, string name, int age, string weapon, string horse = null)
        {
            WarriorBuilder builder;

            switch (profession.ToLower())
            {
                case "infantry":
                    builder = new InfantryBuilder();
                    break;
                case "archer":
                    builder = new ArcherBuilder();
                    break;
                case "horseman":
                    builder = new HorsemanBuilder();
                    break;
                default:
                    throw new ArgumentException("Unknown profession");
            }

            // Budowa wojownika
            builder.Register(name, age);
            builder.ChooseWeapon(weapon);
            if (builder is HorsemanBuilder horseBuilder && !string.IsNullOrEmpty(horse))
            {
                horseBuilder.SetHorse(horse);
            }
            builder.Train();
            return builder.GetResult();
        }
    }
}
