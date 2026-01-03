using System;


namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Command
{
    public class MakeRodCommand : ICommand
    {
        private SantaClausFactory _receiver;

        public MakeRodCommand(SantaClausFactory receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine($"[Polecenie] Wyprodukuj rózgę.");
            _receiver.ProduceRod();
        }
    }
}
