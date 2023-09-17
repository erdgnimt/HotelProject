using Microsoft.AspNetCore.Mvc;
namespace HotelProject.UI.Views.Shared.ViewComponents
{
    public class SubscribeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
