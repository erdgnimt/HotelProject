using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.Views.Shared.ViewComponents
{
    public class BookingViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
