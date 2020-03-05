using System;
using System.Threading.Tasks;

namespace FootballMonitor.Infrastructure
{
    public interface IApiRequest
    {
        Task<string> GetServiceResponse(Uri uri);
    }
}



