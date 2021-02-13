using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    [Route("Cadastro")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}