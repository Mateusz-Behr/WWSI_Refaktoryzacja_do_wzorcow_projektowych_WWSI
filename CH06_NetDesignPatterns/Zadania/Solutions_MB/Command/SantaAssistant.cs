using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Command
{
    public class SantaAssistant
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
            Console.WriteLine($"[Asystent] Otrzymałem polecenie.");
        }

        public void ExecuteComannd()
        {
            if (_command != null)
            {
                Console.WriteLine($"[Asystent] Wykonuję polecenie...");
                _command.Execute();
            }
            else
            {
                Console.WriteLine($"[Asystent] Nie mam żadnego polecenia do wykonania.");
            }
        }
    }
}
