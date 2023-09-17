using System.ComponentModel.DataAnnotations;

namespace HotelProject.UI.Models.Staff
{
    public class AddStaffViewModel
    {        
        public string Name { get; set; }
        public string Title { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
    }
}
