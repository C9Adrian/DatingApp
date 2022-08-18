using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    //Require users to enter a string into their login/password

    public class RegisterDto
    {
        [Required]
        public string UserName {get; set;}

        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password {get; set;}
    }
}