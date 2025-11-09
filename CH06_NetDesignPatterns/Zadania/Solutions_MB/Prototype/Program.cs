using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Oryginalny Ork (Prototyp) ---");
            Ork originalOrk = new Ork(
                "Garrosh",
                80,    // Początkowa siła
                150,   // Początkowe zdrowie
                "Topór",
                "Pomarańczowy",
                "Klan Wojennej Pieśni"
            );
            originalOrk.DisplayOrkInfo();

            List<Ork> orkClones = new List<Ork>();
            Random random = new Random(); // Obiekt do generowania liczb losowych
            int numberOfClones = 5;

            Console.WriteLine($"\n--- Tworzenie {numberOfClones} klonów Orka ---");

            for (int i = 0; i < numberOfClones; i++)
            {
                string jsonString = JsonConvert.SerializeObject(originalOrk);
                Ork clonedOrk = JsonConvert.DeserializeObject<Ork>(jsonString);

                clonedOrk.Name = $"{originalOrk.Name} Klon {i + 1}";

                // Zmiana siły o +/- 10 pkt
                clonedOrk.Strength += random.Next(-10, 11);

                // Zmiana zdrowia o +/- 20 punktów (np.)
                clonedOrk.Health += random.Next(-20, 21);

                orkClones.Add(clonedOrk);

                Console.WriteLine($"Klon Orka {i + 1} stworzony i zmodyfikowany.");
            }

            Console.WriteLine("\n--- Lista Sklonowanych Orków ---");
            foreach (var ork in orkClones)
            {
                ork.DisplayOrkInfo();
            }

            Console.WriteLine("\n--- Weryfikacja: Oryginalny Ork pozostał niezmieniony ---");
            originalOrk.DisplayOrkInfo();
        }
    }
}
