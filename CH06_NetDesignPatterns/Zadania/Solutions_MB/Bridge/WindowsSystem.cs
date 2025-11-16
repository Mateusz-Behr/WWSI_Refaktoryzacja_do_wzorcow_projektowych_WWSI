using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Bridge
{
    public class WindowsSystem : OperatingSystem
    {
        public WindowsSystem(IUserInterface userInterface) : base(userInterface)
        {
            Console.WriteLine("[WindowsSystem] Zainicjowano System Windows.");
        }

        public override List<string> GetInstalledPrograms()
        {
            return new List<string> { "Microsoft Word", "Excel", "Edge", "Paint", "Outlook" };
        }
    }
}
