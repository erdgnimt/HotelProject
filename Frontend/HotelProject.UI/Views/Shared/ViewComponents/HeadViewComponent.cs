using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.Views.Shared.ViewComponents
{
    public class HeadViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
