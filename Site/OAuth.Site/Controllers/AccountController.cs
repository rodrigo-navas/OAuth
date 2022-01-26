using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OAuth.Domain.Extensions;

namespace OAuth.Site.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        [Authorize]
        [Route("entrar")]
        public IActionResult Login(string returnUrl = null)
        {
            if (returnUrl.IsPresent())
                return Redirect(returnUrl);

            return RedirectToAction("Index", "Home");
        }

        [Authorize, Route("minha-conta")]
        public IActionResult MinhaConta()
        {
            return View();
        }

        [Route("sair")]
        public IActionResult Sair()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}
