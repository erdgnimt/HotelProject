using Microsoft.AspNetCore.Mvc;
namespace HotelProject.UI.Views.Shared.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
