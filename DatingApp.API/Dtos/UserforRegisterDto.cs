using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserforRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="Il faut saisir un mot de passe avec 8 caractéres ou 4 caractéres au minimum")]
        public string Password { get; set; }
    }
}