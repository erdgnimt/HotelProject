using HotelProject.UI.DTO.ContactDTO;
using HotelProject.UI.DTO.SendMessageDTO;
using HotelProject.UI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.UI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:22739/api/Contact");

            var clientForInboxMessagesCount = _httpClientFactory.CreateClient();
            var responseMessageForInboxMessagesCount = await clientForInboxMessagesCount.GetAsync("http://localhost:22739/api/Contact/GetInboxMessagesCount");

            var clientForSenboxMessagesCount = _httpClientFactory.CreateClient();
            var responseMessageForSendboxMessagesCount = await clientForSenboxMessagesCount.GetAsync("http://localhost:22739/api/SendMessage/GetSendboxMessagesCount");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ContactInboxDTO>>(jsonData);

                var jsonDataForInboxMessagesCount = await responseMessageForInboxMessagesCount.Content.ReadAsStringAsync();
                TempData["InboxMessagesCount"] = jsonDataForInboxMessagesCount;

                var jsonDataForSendboxMessagesCount = await responseMessageForSendboxMessagesCount.Content.ReadAsStringAsync();
                TempData["SendboxMessagesCount"] = jsonDataForSendboxMessagesCount;

                return View(values);
            }     
            return View();
        }
        public async Task<IActionResult> Sendbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:22739/api/SendMessage");

            var clientForInboxMessagesCount = _httpClientFactory.CreateClient();
            var responseMessageForInboxMessagesCount = await clientForInboxMessagesCount.GetAsync("http://localhost:22739/api/Contact/GetInboxMessagesCount");

            var clientForSenboxMessagesCount = _httpClientFactory.CreateClient();
            var responseMessageForSendboxMessagesCount = await clientForSenboxMessagesCount.GetAsync("http://localhost:22739/api/SendMessage/GetSendboxMessagesCount");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SendboxResultDTO>>(jsonData);

                var jsonDataForInboxMessagesCount = await responseMessageForInboxMessagesCount.Content.ReadAsStringAsync();
                TempData["InboxMessagesCount"] = jsonDataForInboxMessagesCount;

                var jsonDataForSendboxMessagesCount = await responseMessageForSendboxMessagesCount.Content.ReadAsStringAsync();
                TempData["SendboxMessagesCount"] = jsonDataForSendboxMessagesCount;

                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSendMessage(SendMessageAddDTO sendMessageAddDTO)
        {
            sendMessageAddDTO.SenderMail = "admin@gmail.com";
            sendMessageAddDTO.SenderName = "admin";
            sendMessageAddDTO.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(sendMessageAddDTO);

            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:22739/api/SendMessage", stringContent);
           

            if (responseMessage.IsSuccessStatusCode)
            {             

                return RedirectToAction("Inbox", "AdminContact");
            }
            return View();
        }

        public async Task<IActionResult> MessageDetailsSenboxRead(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:22739/api/SendMessage/{id}");

            var clientForInboxMessagesCount = _httpClientFactory.CreateClient();
            var responseMessageForInboxMessagesCount = await clientForInboxMessagesCount.GetAsync("http://localhost:22739/api/Contact/GetInboxMessagesCount");

            var clientForSenboxMessagesCount = _httpClientFactory.CreateClient();
            var responseMessageForSendboxMessagesCount = await clientForSenboxMessagesCount.GetAsync("http://localhost:22739/api/SendMessage/GetSendboxMessagesCount");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ReadInboxMessageDetailsDTO>(jsonData);

                var jsonDataForInboxMessagesCount = await responseMessageForInboxMessagesCount.Content.ReadAsStringAsync();
                TempData["InboxMessagesCount"] = jsonDataForInboxMessagesCount;

                var jsonDataForSendboxMessagesCount = await responseMessageForSendboxMessagesCount.Content.ReadAsStringAsync();
                TempData["SendboxMessagesCount"] = jsonDataForSendboxMessagesCount;

                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> MessageDetailsInboxRead(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:22739/api/Contact/{id}");

            var clientForInboxMessagesCount = _httpClientFactory.CreateClient();
            var responseMessageForInboxMessagesCount = await clientForInboxMessagesCount.GetAsync("http://localhost:22739/api/Contact/GetInboxMessagesCount");

            var clientForSenboxMessagesCount = _httpClientFactory.CreateClient();
            var responseMessageForSendboxMessagesCount = await clientForSenboxMessagesCount.GetAsync("http://localhost:22739/api/SendMessage/GetSendboxMessagesCount");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ContactInboxDTO>(jsonData);

                var jsonDataForInboxMessagesCount = await responseMessageForInboxMessagesCount.Content.ReadAsStringAsync();
                TempData["InboxMessagesCount"] = jsonDataForInboxMessagesCount;

                var jsonDataForSendboxMessagesCount = await responseMessageForSendboxMessagesCount.Content.ReadAsStringAsync();
                TempData["SendboxMessagesCount"] = jsonDataForSendboxMessagesCount;

                return View(values);
            }
            return View();
        }
        public PartialViewResult SideBarAdminContactPartial()
        {
          
            return PartialView();
        }
    }
    
}
