using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TInsert(staff);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.TGetById(id);
            _staffService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
           _staffService.TUpdate(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values =_staffService.TGetById(id);
            return Ok(values);
        }
        [HttpGet("StaffCount")]
        public IActionResult GetStaffCount()
        {
            var value = _staffService.GetStaffCount();
            return Ok(value);
        }

        [HttpGet("GetLastFourStaff")]
        public IActionResult GetLastFourStaff()
        {
            var values = _staffService.TGetLastFourStaff();
            return Ok(values);
        }
    }
}
