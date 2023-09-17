using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.TInsert(contact);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var values = _contactService.TGetById(id);
            _contactService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateContact(Contact contact)
        {
            _contactService.TUpdate(contact);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetInboxMessage(int id)
        {
            var values = _contactService.TGetById(id);
            return Ok(values);
        }
        [HttpGet("GetInboxMessagesCount")]
        public IActionResult GetInboxMessagesCount()
        {
            var values = _contactService.TGetInboxMessagesCount();
            return Ok(values);
        }
    }
}

