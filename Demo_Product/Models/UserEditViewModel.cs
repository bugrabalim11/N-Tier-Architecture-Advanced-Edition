using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen isim giriniz!")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lütfen soyisim giriniz!")]
        public string SurName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lütfen e-postanızı giriniz!")]
        public string Mail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lütfen cinsiyet seçiniz!")]
        public string Gender { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lütfen şire giriniz!")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lütfen tekrar şire giriniz!")]
        [Compare("Password", ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olun!")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
