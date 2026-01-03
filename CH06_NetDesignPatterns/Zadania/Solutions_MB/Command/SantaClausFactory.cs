using System;


namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Command
{
    public class SantaClausFactory
    {
        private int _toyCount = 0;
        private int _rodCount = 0;

        public void ProduceToy(string toyName)
        {
            _toyCount++;
            Console.WriteLine($"Fabryka produkuje zabawkę: {toyName}. To już {_toyCount} zabawka.");
        }

        public void ProduceRod()
        {
            _rodCount++;
            Console.WriteLine($"Fabryka produkuje rózgę. To już {_rodCount} rózga.");
        }

        public void GetProductionSummary()
        {
            Console.WriteLine($"\nPodsumowanie produkcji fabryki. Wyprodukowane zabawki: {_toyCount}  i rózgi: {_rodCount}.");
        }
    }
}
