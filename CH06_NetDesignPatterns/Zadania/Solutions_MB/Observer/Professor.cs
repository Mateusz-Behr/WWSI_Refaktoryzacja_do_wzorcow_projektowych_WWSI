using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Observer
{
    public class Professor
    {
        private List<IStudent> _students = new List<IStudent>();

        public void Subscribe(IStudent student)
        {
            _students.Add(student);
            Console.WriteLine($"[System]: {student.LastName} poprosił o powiadomienie.");
        }

        public void Unsubscribe(IStudent student)
        {
            _students.Remove(student);
            Console.WriteLine($"\n[System]: {student.LastName} zrezygnował z powiadomień.");
        }

        public void AnnounceResults(string subject)
        {
            Console.WriteLine($"\n--- Profesor ogłasza wyniki z przedmiotu {subject}. ---\n");

            Random random = new Random(); //dla symulacji

            foreach (var student in _students)
            {
                double randomGrade = random.Next(2,5);

                student.ReceiveResult(subject, randomGrade);
            }
        }
    }
}
