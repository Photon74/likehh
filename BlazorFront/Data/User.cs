using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorFront.Data
{
    public class User
    {
        [Required(ErrorMessage = "Введите E-mail")]
        [EmailAddress(ErrorMessage = "Это не похоже на E-mail")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Введите пароль")]
        [PasswordPropertyText(true)]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Пароль не короче 8-ми символов!")]
        public string Password { get; set; }
    }
}