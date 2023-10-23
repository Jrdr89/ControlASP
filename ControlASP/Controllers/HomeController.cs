using ControlASP.Models;
using ControlASP.Permisos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControlASP.Controllers
{
    [ValidarSesion]   //Para este controlador, primero debemos validar la sessión
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
		public IActionResult CerrarSesion()
		{
			HttpContext.Session.Clear(); // Borra todos los datos de la sesión
			return RedirectToAction("Login","Acceso");
		}
	}
}