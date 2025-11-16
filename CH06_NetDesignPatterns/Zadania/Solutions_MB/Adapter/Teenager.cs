using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Adapter
{
    public class Teenager : Person
    {
        public Teenager(string name, int age) : base(name, age)
        {
            if (Age >= 18)
            {
                throw new ArgumentException("Nastolatek to osoba, która nie ma jeszcze 18 lat.");
            }
        }
    }
}
