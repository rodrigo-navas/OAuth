using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OAuth.Api._1.Model;

namespace OAuth.Api._1.Controllers
{
    [ApiController]
    [Route("minhaConta")]
    public class MinhaContaController : ControllerBase
    {
        [Authorize]
        [HttpGet("meusDados")]
        public IActionResult MeusDados()
        {
            return Ok(new MinhaConta
            {
                Codigo = 1,
                Nome = "Rodrigo Navas",
                CPF = "40721126820"
            });
        }
    }
}
