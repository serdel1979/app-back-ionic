using AppMov.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AppMov.Controllers
{

    [ApiController]
    [Route("prueba")]
    public class Prueba : ControllerBase
    {


        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult> Recibir([FromBody] string imageBase64)
        {

            if (string.IsNullOrEmpty(imageBase64))
            {
                return BadRequest("No image supplied");
            }

            byte[] imageBytes = Convert.FromBase64String(imageBase64);

            Console.WriteLine(imageBytes.Length);

            // Guardar imagen en bd

            return Ok("Image saved successfully");
        }



    }
}
