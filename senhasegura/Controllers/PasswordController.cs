using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using senhasegura.Interface;
using senhasegura.Models;

namespace senhasegura.Controllers
{
    [EnableRateLimiting("fixed")]   
    [ApiController]
    [Route("v1/[controller]")]
    public class PasswordController : Controller
    {
        private readonly ISenhaService _senhaService;

        public PasswordController(ISenhaService senhaService)
        {
            _senhaService = senhaService;
        }

        [HttpPost("verificar")]
        public IActionResult Verificar(VerificarSenhaRequest request)
        {
           if(string.IsNullOrEmpty(request.Password))
               return BadRequest("Password is required.");

            var response = _senhaService.VerifyPassword(request.Password);

            return Ok(response);
        }
    }
}
