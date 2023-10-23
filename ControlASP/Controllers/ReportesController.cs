using Microsoft.AspNetCore.Mvc;

namespace ControlASP.Controllers
{
    public class ReportesController : Controller
    {
        public IActionResult Finanzas()
        {
            return View();
        }
        public IActionResult Contabilidad()
        {
            return View();
        }
    }
}
