using Microsoft.AspNetCore.Mvc;

namespace EstudosGerais.Controllers
{
    public class AlertasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
