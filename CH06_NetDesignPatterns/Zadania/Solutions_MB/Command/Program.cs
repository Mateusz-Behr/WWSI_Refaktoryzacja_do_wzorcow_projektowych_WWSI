using System;
using RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Command;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"--- Symulacja Fabryki Świętego Mikołaja ---\n");

        SantaClausFactory factory = new SantaClausFactory();
        SantaAssistant assistant = new SantaAssistant();

        ICommand makeDollCommand = new MakeToyCommand(factory, "Lalka");
        ICommand makeCarCommand = new MakeToyCommand(factory, "Samochodzik");
        ICommand makeTrainCommand = new MakeToyCommand(factory, "Pociąg");

        ICommand makeRodCommand = new MakeRodCommand(factory);

        Console.WriteLine("--- Asystent wykonuje zadania ---");

        assistant.SetCommand(makeDollCommand);
        assistant.ExecuteComannd();

        assistant.SetCommand(makeCarCommand);
        assistant.ExecuteComannd();

        assistant.SetCommand(makeTrainCommand);
        assistant.ExecuteComannd();

        assistant.SetCommand(makeRodCommand);
        assistant.ExecuteComannd();

        Console.WriteLine($"--- Koniec produkcji ---");
        factory.GetProductionSummary();

        Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }

 
}
