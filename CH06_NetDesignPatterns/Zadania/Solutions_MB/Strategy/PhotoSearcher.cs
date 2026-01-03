using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Strategy
{
    public class PhotoSearcher
    {
        private IPhotoSearchStrategy _strategy;

        public PhotoSearcher()
        {

        }

        public void SetStrategy(IPhotoSearchStrategy strategy)
        {
            _strategy = strategy;
            Console.Write($"[PhotoSearcher] Strategia wyszukiwania ustawiona na {strategy.GetType().Name}");
        }

        public async Task<List<PhotoResult>> PerformSearch(string category)
        {
            if (_strategy == null)
            {
                Console.WriteLine("[PhotoSearcher] Błąd: brak ustawionej strategii wyszukiwania.");
                
                return new List<PhotoResult>();
            }

            Console.WriteLine($"[PhotoSearcher] Wykonuję wyszukiwanie kategorii '{category}'...");
            return await _strategy.SearchPhotos(category);
        }
    }
}
