using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}