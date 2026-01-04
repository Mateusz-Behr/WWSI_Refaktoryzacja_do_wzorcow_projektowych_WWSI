using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Observer
{
    public class Student : IStudent
    {
        public string LastName { get; private set; }

        public Student(string lastName)
        {
            LastName = lastName;
        }

        public void ReceiveResult(string subject, double grade)
        {
            Console.WriteLine($"Student {LastName}: Otrzymał ocenę {grade} for {subject}.");

            if (grade >= 3)
            {
                Console.WriteLine($"{LastName}: Zaliczone!");
            }
            else
            {
                Console.WriteLine($"{LastName}: Niezaliczone, zapraszam na poprawkę.");
            }
        }
    }
}
