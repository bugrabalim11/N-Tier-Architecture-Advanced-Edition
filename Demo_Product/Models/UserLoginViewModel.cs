using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string UserPassword { get; set; } = string.Empty;
    }
}
