using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Facade
{
    public class WeatherMain
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; } //

        [JsonProperty("pressure")]
        public int Pressure { get; set; } //

        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }
}
