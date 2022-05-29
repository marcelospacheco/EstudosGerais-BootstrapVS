using Microsoft.AspNetCore.Mvc;

namespace EstudosGerais.Controllers
{
    public class BadgesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
