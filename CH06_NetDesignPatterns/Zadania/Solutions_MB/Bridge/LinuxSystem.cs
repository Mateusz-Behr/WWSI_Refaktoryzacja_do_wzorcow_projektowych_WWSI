using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Bridge
{
    public class LinuxSystem : OperatingSystem
    {
        public LinuxSystem(IUserInterface userInterface) : base(userInterface)
        {
            Console.WriteLine("[LinuxSystem] Zainicjowano system Linux.");
        }

        public override List<string> GetInstalledPrograms()
        {
            return new List<string> { "FireFox", "LibreOffice", "GIMP", "Terminal", "VLC Player" };
        }
    }
}
