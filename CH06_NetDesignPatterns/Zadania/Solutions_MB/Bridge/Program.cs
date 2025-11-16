using System;
using System.Collections.Generic;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Demonstracja wzorca Bridge ---");

            Console.WriteLine("Scenariusz 1: System Windows z interfejsem graficznym.");
            IUserInterface windowsGraphicUI = new GraphicInterface();
            OperatingSystem windowsOS = new WindowsSystem(windowsGraphicUI);

            windowsOS.StartUserInterface();
            windowsOS.PressMenuButton();

            Console.WriteLine("--------------");


            Console.WriteLine("Scenariusz 2: System Linux z interfejsem graficznym");
            IUserInterface linuxGraphicUI = new GraphicInterface();
            OperatingSystem linuxOS = new LinuxSystem(linuxGraphicUI);

            linuxOS.StartUserInterface();
            linuxOS.PressMenuButton();

            Console.WriteLine("--------------");


            Console.WriteLine("Scenariusz 3: System Linux z interfejsem konsolowym");
            IUserInterface linuxCommandLineUI = new CommandLineInterface();
            OperatingSystem linuxOSCommand = new LinuxSystem(linuxCommandLineUI);

            linuxOSCommand.StartUserInterface();
            linuxOSCommand.PressMenuButton();

            Console.WriteLine("--------------");

            Console.WriteLine("Naciśnij dowolny przycisk aby zakończyć");
            Console.ReadKey();
        }
    }
}
