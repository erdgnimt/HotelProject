using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.Views.Shared.ViewComponents
{
    public class DashboardScrpitsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
