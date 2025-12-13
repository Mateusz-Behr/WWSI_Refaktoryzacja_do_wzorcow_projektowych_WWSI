using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Composite
{
    public class MenuCategory : MenuComponent
    {
        private List<MenuComponent> _components = new List<MenuComponent>();

        public MenuCategory(string name, string description) : base(name, description)
        {
        }

        public override void Add(MenuComponent component)
        {
            _components.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            _components.Remove(component);
        }

        public override void Display(int indentLevel = 0)
        {
            Console.WriteLine(new string(' ', indentLevel * 2) + $"-- {Name} ({Description}) --");

            foreach (var component in _components)
            {
                component.Display(indentLevel + 1);
            }
        }
    }
}
