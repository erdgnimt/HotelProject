using HotelProject.UI.DTO.BookingDTO;
using HotelProject.UI.DTO.ContactDTO;
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
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult SendMessagePartial()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessagePartial(ContactAddDTO contactAddDTO)
        {
            contactAddDTO.Date=DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(contactAddDTO);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:22739/api/Contact", stringContent);
            return RedirectToAction("Index", "Default");
        }
    }
}
