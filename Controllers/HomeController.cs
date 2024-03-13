using System.Diagnostics;
using EstudioAnime.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstudioAnime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Animes()
        {
            AnimesModel animes = new AnimesModel();
            
            animes.Titulo = "Naruto";
            animes.QuantidadeEp = 500;
            animes.DataLancamento = "2001";

            return View(animes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
