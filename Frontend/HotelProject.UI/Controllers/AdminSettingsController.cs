using HotelProject.Entity.Concrete;
using HotelProject.UI.Models.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.UI.Controllers
{
    public class AdminSettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public AdminSettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = user.Name;
            userEditViewModel.Surname = user.Surname;
            userEditViewModel.Username = user.UserName;
            userEditViewModel.Email = user.Email;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            if (ModelState.IsValid)
            {
                if (userEditViewModel.Password == userEditViewModel.ConfirmPassword)
                {
                    var user = await _userManager.FindByNameAsync(User.Identity.Name);
                    user.Name = userEditViewModel.Name;
                    user.Surname = userEditViewModel.Surname;
                    user.Email = userEditViewModel.Email;
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
                    await _userManager.UpdateAsync(user);
                    return RedirectToAction("Index", "Login");
                }
            }           
            return View();
        }
    }
}
