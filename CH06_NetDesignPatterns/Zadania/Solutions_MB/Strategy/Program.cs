using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Strategy
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("--- Wyszukiwarka zdjęć z wykorzystaniem wzorca Strategy. ---");

            const string pexelsApiKey = "GITdW7MzArJW4LUP2rmbXpK1c2BEwjWcnKuPOqBcycBum7U4hzS7aVZh";
            const string pixabayApiKey = "54030712-781c93ab93cb4fe16d6959839";

            IPhotoSearchStrategy pexelsStrategy = new PexelsSearchStrategy(pexelsApiKey);
            IPhotoSearchStrategy pixabayStrategy = new PixabaySearchStrategy(pixabayApiKey);

            PhotoSearcher searcher = new PhotoSearcher();

            while (true)
            {
                Console.WriteLine("----------");
                Console.WriteLine("Wybierz bazę zdjęć do przeszukania");
                Console.WriteLine("1. Pexels");
                Console.WriteLine("2. Pixabay");
                Console.WriteLine("3. Zakończ program");
                Console.Write("Twój wybór: ");
                string choice = Console.ReadLine();

                if (choice == "3")
                {
                    break;
                }

                IPhotoSearchStrategy selectedStrategy = null;

                switch (choice)
                {
                    case "1":
                        selectedStrategy = pexelsStrategy;
                        break;
                    case "2":
                        selectedStrategy = pixabayStrategy;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                        continue;
                }

                searcher.SetStrategy(selectedStrategy);

                Console.Write("Wprowadź kategorię zdjęć do wyszukania (np. 'nature' lub 'cars':");
                string category = Console.ReadLine();

                if (string.IsNullOrEmpty(category))
                {
                    Console.WriteLine("Kategoria nie może być pusta.");
                    continue;
                }

                List<PhotoResult> results = await searcher.PerformSearch(category);

                if (results != null && results.Count > 0)
                {
                    Console.WriteLine($"\nZnaleziono {results.Count} zdjęć dla kategorii '{category}':");
                    
                    foreach (var photo in results)
                    {
                        Console.WriteLine($" Źródło: {photo.Source}, Autor: {photo.Photographer}");
                        Console.WriteLine($"URL zdjęcia: {photo.Url}");
                        Console.WriteLine($" Strona źródłowa: {photo.PageUrl}");
                        Console.WriteLine("------");
                    }
                }
                else
                {
                    Console.WriteLine($"Brak zdjęć lub wystąpił błąd dla kategorii {category}.");
                }
            }
            Console.WriteLine("Program zakończył działanie. Do zobaczenia");
            Console.ReadKey();


        }
    }
}
