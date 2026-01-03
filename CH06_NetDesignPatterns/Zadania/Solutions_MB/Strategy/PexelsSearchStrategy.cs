using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Strategy
{
    public class PexelsSearchStrategy : IPhotoSearchStrategy
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;
        private const string ApiBaseUrl = "https://api.pexels.com/v1/search";

        public PexelsSearchStrategy(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Authorizaton", _apiKey);
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("PhotoSearchApp/1.0");
        }

        public async Task<List<PhotoResult>> SearchPhotos(string category)
        {
            Console.WriteLine("$\n[Pexels Strategy] Wyszukuję zdjęcia kategorii '{category}'...");
            string requestUrl = $"{ApiBaseUrl}?query={category}%per_page=5";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                PexelsApiResponse apiResponse = JsonConvert.DeserializeObject<PexelsApiResponse>(jsonResponse);

                List<PhotoResult> results = new List<PhotoResult>();
                if (apiResponse?.Photos != null)
                {
                    foreach (var photo in apiResponse.Photos)
                    {
                        results.Add(new PhotoResult
                        {
                            Url = photo.Src?.Medium,
                            PageUrl = photo.Url,
                            Photographer = photo.Photographer,
                            Source = "Pexels"
                        });
                    }
                }

                return results;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"[Pexels Strategy] Błąd HTTP: {ex.Message}");
            }
            catch (JsonSerializationException ex)
            {
                Console.WriteLine($"[Pexels Strategy] Błąd deserializacji JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Pexels Strategy] Nieoczekiwany błąd: {ex.Message}");
            }

            return new List<PhotoResult>();

        }
    }
}
