using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Bridge
{
    internal class GraphicInterface : IUserInterface
    {
        public void Display(string message)
        {
            Console.WriteLine($"[Interfejs graficzny] Wyświetlam: {message}.");
        }
    }
}
