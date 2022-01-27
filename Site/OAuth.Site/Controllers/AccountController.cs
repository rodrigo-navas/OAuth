using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OAuth.Domain.Extensions;
using OAuth.Domain.Interfaces;
using OAuth.Site.Models;
using System.Linq;
using System.Threading.Tasks;

namespace OAuth.Site.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMinhaContaService _minhaContaService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AccountController(IMinhaContaService minhaContaService, IHttpContextAccessor httpContextAccessor)
        {
            _minhaContaService = minhaContaService;
            _httpContextAccessor = httpContextAccessor;
        }

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
        public async Task<IActionResult> MinhaConta()
        {
            var cargoClaim = User.Claims.FirstOrDefault(f => f.Type.Equals("cargo"));
            var at = await _httpContextAccessor.HttpContext.GetTokenAsync("access_token");
            var meusDados = await _minhaContaService.MeusDados(at);

            return View(new MeusDadosModel
            {
                Codigo = meusDados.Codigo,
                CPF = meusDados.CPF,
                Nome = meusDados.Nome
            });
        }

        [Route("sair")]
        public IActionResult Sair()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}
