using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Bridge
{
    public class CommandLineInterface : IUserInterface
    {
        public void Display(string message)
        {
            Console.WriteLine($"[Interfejs konsolowy]: {message}");
        }
    }
}
