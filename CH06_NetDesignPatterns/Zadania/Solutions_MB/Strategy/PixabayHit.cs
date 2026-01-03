using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Strategy
{
    public class PixabayHit
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("pageURL")]
        public string PageUrl { get; set; }

        [JsonProperty("webformatURL")]
        public string WebformatUrl { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class PixabayApiResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("totalHits")]
        public int TotalHits { get; set; }

        [JsonProperty("hits")]
        public List<PixabayHit> Hits { get; set; }
    }
}

//54030712-781c93ab93cb4fe16d6959839