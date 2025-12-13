using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Composite
{
    public abstract class MenuComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public MenuComponent(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public abstract void Display(int indentLevel = 0);

        public virtual void Add(MenuComponent component)
        {
            throw new NotSupportedException("Nie można dodać elementu do pojedynczego dania.");
        }

        public virtual void Remove(MenuComponent component)
        {
            throw new NotSupportedException("Nie można usunąć elementu z pojedynczego dania.");
        }
    }
}
