using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Facade
{
    public class WeatherResponse
    {
        [JsonProperty("name")]
        public string CityName { get; set; }

        [JsonProperty("main")]
        public WeatherMain Main { get; set; }

        [JsonProperty("cod")]
        public int Cod { get; set; }

        [JsonProperty("message")]
        public string ErrorMessage { get; set; }
    }
}
