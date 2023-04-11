using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="İsim alanı boş geçilemez")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Soyisim alanı boş geçilemez")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Şifre boş geçilemez")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        [Compare("Password",ErrorMessage ="Parola eşleşmiyor")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Mail boş geçilemez")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Bir resim ekleyin")]
        public string ImageURL { get; set; }
    }
}
