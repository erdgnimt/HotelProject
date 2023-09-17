using HotelProject.Entity.Concrete;
using HotelProject.UI.DTO.RegisterDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.UI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AddNewUserDTO addNewUserDTO)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = addNewUserDTO.Name,
                Email = addNewUserDTO.Mail,
                Surname = addNewUserDTO.Surname,
                UserName = addNewUserDTO.Username,
                WorkLocationId = 1
            };
            var result = await _userManager.CreateAsync(appUser, addNewUserDTO.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
