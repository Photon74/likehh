using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorFront.Data
{
    public class UserDto
    {
        [Required(ErrorMessage = "Введите E-mail")]
        [EmailAddress(ErrorMessage = "Это не похоже на E-mail")]
        public string Email { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Введите пароль")]
        [PasswordPropertyText(true)]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Пароль не короче 8-ми символов!")]
        public string Password { get; set; } = null!;
    }
}