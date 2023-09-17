using System.ComponentModel.DataAnnotations;

namespace HotelProject.UI.DTO.ServiceDTO
{
    public class ServiceUpdateDTO
    {

        public int ServiceId { get; set; }
        [Required(ErrorMessage = "Ikon linki girin!")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Başlık girin!")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Açıklama girin!")]
        public string Description { get; set; }
    }
}
