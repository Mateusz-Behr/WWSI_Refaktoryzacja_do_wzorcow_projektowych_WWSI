using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Bridge
{
    public abstract class OperatingSystem
    {
        protected IUserInterface _userInterface;
        public OperatingSystem(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        public abstract List<string> GetInstalledPrograms();

        public void StartUserInterface()
        {
            _userInterface.Display($"Uruchamiam interfejs na systemie {this.GetType().Name}");
        }

        public void PressMenuButton()
        {
            _userInterface.Display("Naciśnięto przycisk 'Menu'.");
            List<string> programs = GetInstalledPrograms();
            _userInterface.Display("--- Lista zainstalowanych programów ---");
            foreach (var program in programs)
            {
                _userInterface.Display($"+ {program}");
            }
            _userInterface.Display("-----------------");
        }
    }
}
