using Microsoft.AspNetCore.Mvc;
namespace HotelProject.UI.Views.Shared.ViewComponents
{
    public class TrailerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
