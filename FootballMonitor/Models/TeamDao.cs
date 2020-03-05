using Newtonsoft.Json;

namespace FootballMonitor.Models
{
    public class TeamDao
    {
        [JsonProperty("name")]
        public string TeamName { get; set; }
    }
}