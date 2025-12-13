using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Composite
{
    public class MenuItem : MenuComponent
    {
        public double Price { get; set; }

        public MenuItem(string name, string description, double price) : base(name, description)
        {
            Price = price;
        }

        public override void Display(int indentLevel = 0)
        {
            Console.WriteLine(new string(' ', indentLevel * 2) + $"- {Name} ({Description}) --- {Price:C}");
        }
    }
}
