using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ControlASP.Permisos
{

	public class ValidarSesionAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			var httpContext = context.HttpContext;
			if (httpContext.Session.GetString("UsuarioId") == null)
			{
				context.Result = new RedirectResult("~/Acceso/Login");
			}
			base.OnActionExecuting(context);
		}
	}
	
}

