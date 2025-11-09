using RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.WarriorFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            GarrisonZad3 myGarrison = new GarrisonZad3();

            List<Warrior> trainedWarriors = new List<Warrior>();

            Console.WriteLine("Infantry training:");
            trainedWarriors.Add(myGarrison.TrainWarrior("infantry", "Jan", 25, "Sword"));
            trainedWarriors.Add(myGarrison.TrainWarrior("infantry", "Anna", 28, "Axe"));
            Console.WriteLine();

            Console.WriteLine("Horseman training:");
            trainedWarriors.Add(myGarrison.TrainWarrior("horseman", "Krzysztof", 30, "Lance", "Nightmare"));
            trainedWarriors.Add(myGarrison.TrainWarrior("horseman", "Marek", 35, "Spear", "Płotka"));
            Console.WriteLine();

            Console.WriteLine("Archer training:");
            trainedWarriors.Add(myGarrison.TrainWarrior("archer", "Tomasz", 27, "Bow"));
            trainedWarriors.Add(myGarrison.TrainWarrior("archer", "Kasia", 29, "Crossbow"));
            Console.WriteLine();


            // Wyświetlenie wyszkolonych wojowników
            Console.WriteLine("\n*** Trained warriors ***");
            foreach (var warrior in trainedWarriors)
            {
                Console.Write($"{warrior.GetType().Name}: {warrior.Name}, age: {warrior.Age} , weapon: {warrior.Weapon}");
                if (warrior is Horseman horseman)
                {
                    Console.Write($", koń: {horseman.Horse}");
                }
                Console.WriteLine();

                warrior.Attack(); // Każdy wojownik może zaatakować
                if (warrior is Infantry infantry) infantry.Storm();
                if (warrior is Horseman horseMan) horseMan.Charge();
            }


        }
    }
}