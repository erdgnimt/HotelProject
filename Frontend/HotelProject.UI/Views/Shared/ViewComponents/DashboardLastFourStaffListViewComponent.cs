using HotelProject.UI.DTO.GuestDTO;
using HotelProject.UI.DTO.StaffDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.UI.Views.Shared.ViewComponents
{
    public class DashboardLastFourStaffListViewComponent:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardLastFourStaffListViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:22739/api/Staff/GetLastFourStaff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<StaffResultDTO>>(jsonData);
                return View(values);
            }
            return View();
        }      
    }
}
