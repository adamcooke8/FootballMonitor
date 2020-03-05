using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace FootballMonitor.Infrastructure
{
    public class ApiRequest : IApiRequest
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;
        private const string PersonalAccessTokenConfigKey = "PersonalAccessToken";

        public ApiRequest(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _configuration = configuration;
        }

        public async Task<string> GetServiceResponse(Uri uri)
        {
            var response = await GetHttpResponse(uri);
            return Convert.ToString(await response.Content.ReadAsStringAsync());
        }

        private async Task<HttpResponseMessage> GetHttpResponse(Uri uri)
        {
            if (string.IsNullOrWhiteSpace(uri.AbsoluteUri))
            {
                throw new ArgumentNullException(nameof(uri));
            }

            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",
                _configuration[PersonalAccessTokenConfigKey]);


            HttpResponseMessage response = await _client.GetAsync(uri);
            response.EnsureSuccessStatusCode();

            return response;
        }
    }
}



