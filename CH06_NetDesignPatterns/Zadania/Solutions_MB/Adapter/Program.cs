using System;
using System.Collections.Generic;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Klub nocny Underground. Testowanie adaptera FakeAdult ---");


            Console.WriteLine("\n === Scenariusz 1: Prawdziwy nastolatek Krzyś. ===\n");
            
            Teenager krzys = new Teenager("Krzyś", 17);
            NightClub club = new NightClub();

            Console.WriteLine($"""
                               Prawdziwy Krzyś, który jest nastolatkiem nie może bezpośrednio wejść do klubu, 
                               ponieważ do klubu mogą wejść tylko dorośli (klasa Adult).
                               """);


            Console.WriteLine("\n === Scenariusz 2: Nastolatek Krzyś podaje się za dorosłego");

            Adult krzysztof = new Adult("Krzysztof", 17);
            club.VerifyPerson(krzysztof);
            

            Console.WriteLine("\n=== Scenariusz 3: Prawdziwy dorosły. ===\n");

            Adult jan = new Adult("Jan", 25);
            club.VerifyPerson(jan);


            Console.WriteLine("\n=== Scenariusz 4: Krzyś używa adapter FakeAdult. ===");

            Adult krzysAsFakeAdult = new FakeAdult(krzys);
            club.VerifyPerson(krzysAsFakeAdult);
        }
    }
}