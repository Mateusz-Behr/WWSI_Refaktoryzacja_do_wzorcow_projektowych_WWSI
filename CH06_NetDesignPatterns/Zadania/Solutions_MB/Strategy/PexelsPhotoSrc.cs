using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Strategy
{
    public class PexelsPhotoSrc
    {
        [JsonProperty("medium")]
        public string Medium { get; set; }
    }

    public class PexelsPhoto
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("photographer")]
        public string Photographer { get; set; }

        [JsonProperty("photographer_url")]
        public string PhotographerUrl { get; set; }

        [JsonProperty("src")]
        public PexelsPhotoSrc Src { get; set; }
    }

    public class PexelsApiResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("photos")]
        public List<PexelsPhoto> Photos { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }
}
//GITdW7MzArJW4LUP2rmbXpK1c2BEwjWcnKuPOqBcycBum7U4hzS7aVZh