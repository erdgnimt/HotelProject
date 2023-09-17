using HotelProject.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult GetAppUser()
        {
            var values = _appUserService.TGetList();
            return Ok(values);
        }


        [HttpGet("GetAppUserWithWorkLocationList")]
        public IActionResult GetAppUserWithWorkLocationList()
        {           
            var values = _appUserService.TUsersListWithWorkLocations();
            return Ok(values);
        }
        [HttpGet("AppUserCount")]
        public IActionResult AppUserCount()
        {
            var value = _appUserService.TGetAppUserCount();
            return Ok(value);
        }
    }
}
