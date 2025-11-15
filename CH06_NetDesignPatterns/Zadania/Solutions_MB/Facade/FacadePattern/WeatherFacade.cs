using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Facade
{
    public class WeatherFacade
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;
        private const string ApiBaseUrl = "https://api.openweathermap.org/data/2.5/weather";

        // Konstruktor fasady. Wymaga klucza API do OpenWeatherMap.
        public WeatherFacade(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("WeatherApp/1.0");
        }

        public async Task<WeatherResponse> GetCurrentWeather(string cityName)
        {
            if (string.IsNullOrWhiteSpace(cityName))
            {
                Console.WriteLine("Nazwa miasta nie może być pusta.");
                return null;
            }

            string requestUrl = $"{ApiBaseUrl}?q={cityName}&appid={_apiKey}&units=metric";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    WeatherResponse weatherData = JsonConvert.DeserializeObject<WeatherResponse>(jsonResponse);

                    if (weatherData != null && weatherData.Cod == 200)
                    {
                        return weatherData;
                    }
                    else if (weatherData != null)
                    {
                        Console.WriteLine($"Błąd API dla miasta '{cityName}': {weatherData.ErrorMessage} (Kod: {weatherData.Cod})");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine($"Błąd HTTP podczas pobierania pogody dla miasta '{cityName}': {response.StatusCode} - {response.ReasonPhrase}");
                    string errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Szczegóły: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Błąd połączenia podczas pobierania pogody dla miasta '{cityName}': {ex.Message}");
            }
            catch (JsonSerializationException ex)
            {
                Console.WriteLine($"Błąd deserializacji odpowiedzi dla miasta '{cityName}': {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}");
            }

            return null;
        }
    }
}
