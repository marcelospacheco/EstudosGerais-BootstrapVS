using Microsoft.AspNetCore.Mvc;

namespace EstudosGerais.Controllers
{
    public class TabelasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
