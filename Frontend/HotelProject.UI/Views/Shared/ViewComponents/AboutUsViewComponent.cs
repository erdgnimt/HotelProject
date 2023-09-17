using HotelProject.UI.DTO.AboutDTO;
using HotelProject.UI.DTO.ServiceDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.UI.Views.Shared.ViewComponents
{
    public class AboutUsViewComponent:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AboutUsViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:22739/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AboutResultDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
