using System.ComponentModel.DataAnnotations;

namespace HotelProject.UI.DTO.LoginDTO
{
    public class LoginUserDTO
    {
        [Required(ErrorMessage ="Kullanıcı adı boş bırakılmaaz!")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Şifre boş bırakılamaz!")]
        public string Password { get; set; }
    }
}
