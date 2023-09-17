using HotelProject.UI.DTO.BookingDTO;
using HotelProject.UI.DTO.SubscribeDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.UI.Controllers
{
    [AllowAnonymous]
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddBookingPartial()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddBookingPartial(BookingAddDTO bookingAddDTO)
        {
            bookingAddDTO.Status = "Onay bekliyor";
            bookingAddDTO.CheckIn = DateTime.Now;
            bookingAddDTO.CheckOut = DateTime.Now;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(bookingAddDTO);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:22739/api/Booking", stringContent);
            return RedirectToAction("Index", "Default");
        }
    }
}
