using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Concrete
{
    public class About
    {
        public int AboutId { get; set; }
        public string TitleBlack { get; set; }
        public string TitleOrange { get; set; }
        public string Content { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
