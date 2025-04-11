
using System.ComponentModel.DataAnnotations;

namespace taskUser.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo no válido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; } = string.Empty;
    }
}








/*using System.ComponentModel.DataAnnotations;

namespace taskUser.Models
{
    public class RegistrationModel
    {
        //public required string Name { get; set; }
        //public required string Email { get; set; }
        //public required string Password { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo no válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; }

        //[Required(ErrorMessage = "El nombre es obligatorio")]
        //public string Name { get; set; }

        //[Required(ErrorMessage = "El correo es obligatorio")]
        //[EmailAddress(ErrorMessage = "Correo no válido")]
        //public string Email { get; set; }

        //[Required(ErrorMessage = "La contraseña es obligatoria")]
        //public string Password { get; set; }
    }
}
*/