using System;
using System.Threading.Tasks;
using FootballMonitor.Infrastructure;
using FootballMonitor.Interfaces;
using FootballMonitor.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace FootballMonitor.Services
{
    public class FootballMonitorService : IFootballMonitorService
    {
        private const string ConfigKeyFootballMonitorUri = "GetPremierLeagueTable";

        private readonly IApiRequest _apiRequest;
        private readonly IConfiguration _configuration;

        public FootballMonitorService(IApiRequest apiRequest, IConfiguration configuration)
        {
            _apiRequest = apiRequest ?? throw new ArgumentNullException(nameof(apiRequest));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public FootballMonitorService(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Gets the Football League Table.
        /// </summary>
        public async Task<FootballMonitorResponseDao> GetFootballMonitor()
        {
            var footballMonitorUri = new Uri(_configuration[ConfigKeyFootballMonitorUri]);
            var serviceResponse = await _apiRequest.GetServiceResponse(footballMonitorUri);
            var footballMonitorResponse = JsonConvert.DeserializeObject<FootballMonitorResponseDao>(serviceResponse);

            return footballMonitorResponse;
        }
    }
}



