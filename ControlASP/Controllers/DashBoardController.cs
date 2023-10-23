using ControlASP.Permisos;
using Microsoft.AspNetCore.Mvc;

namespace ControlASP.Controllers
{
	[ValidarSesion]   //Para este controlador, primero debemos validar la sessión
	public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
