using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;

namespace AppMov.Filter
{
    public class AuthorizationHeaderFiltro : IAuthorizationFilter
    {


        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // Obtener el token de Google del encabezado
            string token = context.HttpContext.Request.Headers["x-google-token"];

            // Verifique el token aquí usando Google.Apis.Auth
            ValidateTokenAsync(token, context);
        }

        public async Task ValidateTokenAsync(string token, AuthorizationFilterContext context)
        {

            try
            {
                var googleUser = await GoogleJsonWebSignature.ValidateAsync(token, new GoogleJsonWebSignature.ValidationSettings()
                {
                    Audience = new[] { "402562450789-0aau8bfeu40ef95tg4c1c8trnrjoblo5.apps.googleusercontent.com" }
                });

            }
            catch
            {
                context.Result = new UnauthorizedResult();
            }

        }



    }




}
