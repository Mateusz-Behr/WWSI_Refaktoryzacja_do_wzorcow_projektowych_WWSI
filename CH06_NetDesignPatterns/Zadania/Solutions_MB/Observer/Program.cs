using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();

            Student s1 = new Student("Nowak");
            Student s2 = new Student("Brzęczyszczykiewicz");
            Student s3 = new Student("Mazurek");
            Student s4 = new Student("Stanowski");

            professor.Subscribe(s1);
            professor.Subscribe(s2);
            professor.Subscribe(s3);
            professor.Subscribe(s4);

            professor.AnnounceResults("Wzorce projektowe i architektoniczne aplikacji");

            professor.Unsubscribe(s2); //jeden student rezygnuje z powiadomień


            professor.AnnounceResults("Analiza matematyczna");

            Console.ReadLine();
        }
    }
}
