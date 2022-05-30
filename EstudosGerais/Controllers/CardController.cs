using Microsoft.AspNetCore.Mvc;

namespace EstudosGerais.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
