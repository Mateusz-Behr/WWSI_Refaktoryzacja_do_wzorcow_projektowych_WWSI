using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Strategy
{
    public class PixabaySearchStrategy : IPhotoSearchStrategy
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;
        private const string ApiBaseUrl = "https://pixabay.com/api/";

        public PixabaySearchStrategy(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("PhotoSearchApp/1.0");
        }

        public async Task<List<PhotoResult>> SearchPhotos(string category)
        {
            Console.WriteLine($"[Pixabay Strategy] Wyszukuję zdjęcia kategorii '{category}'...");
            string requestUrl = $"{ApiBaseUrl}?key={_apiKey}&q={category}&image_type=photo&per_page=5";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                PixabayApiResponse apiResponse = JsonConvert.DeserializeObject<PixabayApiResponse>(jsonResponse);

                List<PhotoResult> results = new List<PhotoResult>();

                if (apiResponse?.Hits != null)
                {
                    foreach (var hit in apiResponse.Hits)
                    {
                        results.Add(new PhotoResult
                        {
                            Url = hit.WebformatUrl,
                            PageUrl = hit.PageUrl,
                            Photographer = hit.User,
                            Source = "Pixabay"
                        });
                    }
                }

                return results;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"[Pixabay Strategy] Błąd HTTP: {ex.Message}");
            }
            catch (JsonSerializationException ex)
            {
                Console.WriteLine($"[Pixabay strategy] Błąd deserializacji JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Pixabay Strategy] Nieoczekiwany błąd: {ex.Message}");
            }

            return new List<PhotoResult>();
        }
    }
}
