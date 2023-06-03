using Microsoft.AspNetCore.Mvc.Filters;

namespace TiendaLibro.Web.Filters
{
    public class PeliculasActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var request = filterContext.HttpContext.Request;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }
    }
}
