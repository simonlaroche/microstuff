using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;
using MicroStuff.Data;
using MicroStuff.ViewModels;

namespace MicroStuff.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISessions _sessions;
        private readonly ILogger _logger;

        public HomeController(ISessions sessions, ILoggerFactory loggerFactory)
        {
            _sessions = sessions;
            _logger = loggerFactory.CreateLogger<HomeController>();
        }
        
        public async Task<IActionResult> Index()
        {
            var sessions = await _sessions.Get();
            var viewModel = new GridViewModel(sessions);
            return View(viewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
