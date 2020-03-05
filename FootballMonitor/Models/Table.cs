using Newtonsoft.Json;

namespace FootballMonitor.Models
{
    public class Table
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }
    }
}