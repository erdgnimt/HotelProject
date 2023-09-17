using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.UI.Views.Shared.ViewComponents
{
    public class DashboardWidgetViewComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httppClientFactory;

        public DashboardWidgetViewComponent(IHttpClientFactory httppClientFactory)
        {
            _httppClientFactory = httppClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var clientStaffCount = _httppClientFactory.CreateClient();
            var responseMessageWithStaffCount = await clientStaffCount.GetAsync("http://localhost:22739/api/Staff/StaffCount");
            var jsonDataWithStaffCount = await responseMessageWithStaffCount.Content.ReadAsStringAsync();
            ViewBag.staffCount = jsonDataWithStaffCount;

            var clientBookingCount = _httppClientFactory.CreateClient();
            var responseMessageWithBookingCount = await clientBookingCount.GetAsync("http://localhost:22739/api/Booking/BookingCount");
            var jsonDataWithBookingCount = await responseMessageWithBookingCount.Content.ReadAsStringAsync();
            ViewBag.bookingCount = jsonDataWithBookingCount;

            var clientAppUserCount = _httppClientFactory.CreateClient();
            var responseMessageWithAppUserCount = await clientAppUserCount.GetAsync("http://localhost:22739/api/AppUser/AppUserCount");
            var jsonDataWithAppUserCount = await responseMessageWithAppUserCount.Content.ReadAsStringAsync();
            ViewBag.appUserCount = jsonDataWithAppUserCount;

            var clientRoomCount = _httppClientFactory.CreateClient();
            var responseMessageWithRoomCount = await clientRoomCount.GetAsync("http://localhost:22739/api/Room/GetRoomCount");
            var jsonDataWithRoomCount = await responseMessageWithRoomCount.Content.ReadAsStringAsync();
            ViewBag.roomCount = jsonDataWithRoomCount;

            return View();
        }
    }
}
