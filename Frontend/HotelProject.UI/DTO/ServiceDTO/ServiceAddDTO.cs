using System.ComponentModel.DataAnnotations;

namespace HotelProject.UI.DTO.ServiceDTO
{
    public class ServiceAddDTO
    {
        [Required(ErrorMessage ="Ikon linki girin!")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage ="Başlık girin!")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
