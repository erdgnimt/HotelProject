using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DTO.DTO.RoomDTO
{
    public class RoomUpdateDTO
    {
        [Required(ErrorMessage ="Id numarasını girin!")]
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarasını girin!")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat aralığı girin!")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen başlık girin!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Yatak sayısını belirtiniz!")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Banyo sayısını belirtiniz!")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
