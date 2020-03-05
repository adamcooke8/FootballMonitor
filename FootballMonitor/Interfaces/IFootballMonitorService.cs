using FootballMonitor.Models;
using System.Threading.Tasks;

namespace FootballMonitor.Interfaces
{
    public interface IFootballMonitorService
    {
        Task<FootballMonitorResponseDao> GetFootballMonitor();
    }
}