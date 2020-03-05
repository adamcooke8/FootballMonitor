using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using FootballMonitor.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FootballMonitor.Controllers
{
    public class FootballMonitorController : Controller
    {
        private readonly IFootballMonitorService _service;

        /// <summary>
        /// Pass in logger and service layers
        /// </summary>
        public FootballMonitorController(IFootballMonitorService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        /// <summary>
        /// Get football monitor info.
        /// </summary>
        // 
        // GET: /FootballMonitor/
        public async Task<IActionResult> Index()
        {
            var footballMonitorResponseDao = await _service.GetFootballMonitor();
            var apiResponse = _service.GetFootballMonitor(footballMonitorResponseDao);
            return View(apiResponse);
        }
    }
}



