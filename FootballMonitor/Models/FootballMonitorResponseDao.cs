using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballMonitor.Models
{
    public class FootballMonitorResponseDao
    {
        [JsonProperty("value")]
        public List<FootballMonitorDao> Table { get; set; }
    }
}