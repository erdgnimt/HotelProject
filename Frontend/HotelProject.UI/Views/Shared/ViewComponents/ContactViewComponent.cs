using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.Views.Shared.ViewComponents
{
    public class ContactViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
