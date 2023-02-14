using AppMov.DTO;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AppMov.Controllers
{

    [ApiController]
    [Route("auth")]
    public class Cuentas: ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ApplicationDbContext context;
        private readonly IConfiguration configuration;

        public Cuentas(UserManager<IdentityUser> userManager,
            ApplicationDbContext context,
            IConfiguration configuration) {
            this.userManager = userManager;
            this.context = context;
            this.configuration = configuration;
        }

        [HttpPost("validar")]
        public async Task<ActionResult> Validar(CredencialGoogle credencial)
        {
            var googleUser = await GoogleJsonWebSignature.ValidateAsync(credencial.idToken, new GoogleJsonWebSignature.ValidationSettings()
            {
                Audience = new[] { "402562450789-0aau8bfeu40ef95tg4c1c8trnrjoblo5.apps.googleusercontent.com" }
            });

            Console.WriteLine(googleUser);

            
            return Ok();
        }



    }
}
