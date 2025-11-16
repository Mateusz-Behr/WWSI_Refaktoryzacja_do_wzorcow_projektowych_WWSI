using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Adapter
{
    public class NightClub
    {
        public void VerifyPerson(Adult person)
        {
            Console.WriteLine($"Bramkarz sprawdza {person.Name}. Wiek {person.Age}");
            if (person.IsAdult())
            {
                Console.WriteLine($"Bramkarz mówi: Witaj {person.Name} w naszym klubie, zapraszamy.");
            }
            else
            {
                Console.WriteLine($"Bramkarz mówi: Przykro mi, {person.Name}. Masz {person.Age} lat. Wstęp do naszego klubu jest tylko dla dorosłych.");
            }
        }
    }
}
