using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.Views.Shared.ViewComponents
{
    public class SpinnerViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
