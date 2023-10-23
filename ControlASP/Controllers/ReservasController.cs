using ControlASP.Permisos;
using Microsoft.AspNetCore.Mvc;

namespace ControlASP.Controllers
{
    [ValidarSesion]
    public class ReservasController : Controller
    {
        public IActionResult Listado()
        {
            return View();
        }
    }
}
