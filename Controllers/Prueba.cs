using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AppMov.Controllers
{

    [ApiController]
    [Route("prueba")]
    public class Prueba : ControllerBase
    {





        [HttpGet("ver")]
        public async Task<ActionResult> Get()
        {

            return Ok("Todo ok...");
        }
    }
}
