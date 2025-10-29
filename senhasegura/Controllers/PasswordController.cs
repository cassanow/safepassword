using Microsoft.AspNetCore.Mvc;
using senhasegura.Interface;

namespace senhasegura.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class PasswordController : Controller
    {
        private readonly ISenhaService _senhaService;

        public PasswordController(ISenhaService senhaService)
        {
            _senhaService = senhaService;
        }

        [HttpGet("verificar")]
        public IActionResult Verificar(string password)
        {
           if(string.IsNullOrEmpty(password))
               return BadRequest("Password is required.");

            var response = _senhaService.VerifyPassword(password);

            return Ok(response);
        }
    }
}
