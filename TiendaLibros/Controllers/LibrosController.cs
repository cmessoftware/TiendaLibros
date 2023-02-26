using Microsoft.AspNetCore.Mvc;

namespace TiendaLibroWebApi.Controllers
{
    public class LibrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
