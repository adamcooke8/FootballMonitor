
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FootballMonitor.Models
{
    public class Standings
    {
        [JsonProperty("value")]
        public List<table> Table { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}