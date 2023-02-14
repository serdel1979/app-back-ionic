using System.ComponentModel.DataAnnotations;

namespace AppMov.DTO
{
    public class CredencialGoogle
    {
        [Required]
        public string idToken { get; set; }

    }
}
