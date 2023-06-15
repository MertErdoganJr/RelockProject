using System.ComponentModel.DataAnnotations;

namespace RelockProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı Adını Giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifenizi Giriniz")]
        public string Password { get; set; }
    }
}
