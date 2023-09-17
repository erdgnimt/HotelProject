using System.ComponentModel.DataAnnotations;

namespace HotelProject.UI.DTO.RegisterDTO
{
    public class AddNewUserDTO
    {
        [Required(ErrorMessage ="İsim alanı boş bırakılamaz!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyisim alanı boş bırakılamaz!")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mail adresi boş bırakılamaz!")]
        public string Mail { get; set; }
        [Required(ErrorMessage ="Şifrenizi giriniz!")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Şifreler uyuşmuyor!")]
        public string ConfirmPassword { get; set; }
        public int WorkLocationId { get; set; }
    }
}
