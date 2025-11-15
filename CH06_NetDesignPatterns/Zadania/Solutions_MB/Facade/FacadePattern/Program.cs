using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Facade
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("--- Aplikacja pogodowa ---");

            const string openWeatherMapApiKey = "1520bdd8572148454a6f319d43e60872";

            WeatherFacade weatherFacade = new WeatherFacade(openWeatherMapApiKey);

            while (true)
            {
                Console.WriteLine("\nWprowadź nazwę miasta (lub 'exit' aby zakończyć):");
                string cityName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(cityName) || cityName.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine($"Pobieranie pogody dla {cityName}...");

                WeatherResponse weatherData = await weatherFacade.GetCurrentWeather(cityName);

                if (weatherData != null)
                {
                    Console.WriteLine($"\n--- Aktualna pogoda w {weatherData.CityName} ---");
                    Console.WriteLine($"Temperatura: {weatherData.Main.Temperature}°C");
                    Console.WriteLine($"Odczuwalna temperatura: {weatherData.Main.FeelsLike}°C");
                    Console.WriteLine($"Wilgotność: {weatherData.Main.Humidity}%");
                    Console.WriteLine($"Ciśnienie: {weatherData.Main.Pressure} hPa");
                }
                else
                {
                    Console.WriteLine($"Nie udało się pobrać pogody dla miasta '{cityName}'. Spróbuj ponownie lub sprawdź nazwę.");
                }
            }

            Console.WriteLine("\nProgram zakończył działanie. Do widzenia!");
            // Opcjonalnie, jeśli okno konsoli zamyka się zbyt szybko:
            // Console.ReadKey();
        }
    }
}
