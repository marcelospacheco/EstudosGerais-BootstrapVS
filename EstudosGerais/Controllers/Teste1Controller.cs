using Microsoft.AspNetCore.Mvc;

namespace EstudosGerais.Controllers
{
    public class Teste1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
