using ControlASP.Permisos;
using Microsoft.AspNetCore.Mvc;

namespace ControlASP.Controllers
{
	[ValidarSesion]
	public class EmpleadoController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
