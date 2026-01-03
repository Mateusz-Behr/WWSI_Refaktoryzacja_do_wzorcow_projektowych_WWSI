using System;


namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Command
{
    public class MakeToyCommand : ICommand
    {
        private SantaClausFactory _receiver;
        private string _toyName;

        public MakeToyCommand(SantaClausFactory receiver, string toyName)
        {
            _receiver = receiver;
            _toyName = toyName;
        }

        public void Execute()
        {
            Console.WriteLine($"[Polecenie] Wyprodukuj zabawkę {_toyName}.");
            _receiver.ProduceToy(_toyName);
        }
    }
}
