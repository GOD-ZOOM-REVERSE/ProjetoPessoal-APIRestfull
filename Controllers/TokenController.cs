using Microsoft.AspNetCore.Mvc;

namespace ProjetoPessoal.Controllers
{
    public class TokenController : Controller
    {
        public IActionResult GerarToken(string clientId, string clientSecret)
        {
            return View();
        }
    }
}
