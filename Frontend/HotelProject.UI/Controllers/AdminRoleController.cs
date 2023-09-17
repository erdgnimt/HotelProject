using HotelProject.Entity.Concrete;
using HotelProject.UI.Models.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.UI.Controllers
{
    public class AdminRoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public AdminRoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }
        [HttpGet]
        public IActionResult AddRole() 
        { 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(AddRoleViewModel addRoleViewModel) 
        {
            AppRole appRole = new AppRole()
            {
                Name = addRoleViewModel.RoleName
            };
            var result = await _roleManager.CreateAsync(appRole);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "AdminRole");
            }
            return View();
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var role = _roleManager.Roles.FirstOrDefault(r => r.Id == id);
            await _roleManager.DeleteAsync(role);
            return RedirectToAction("Index", "AdminRole");
        }
        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var role = _roleManager.Roles.FirstOrDefault(r => r.Id == id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel()
            {
                RoleId = role.Id,
                RoleName = role.Name,
            };
            return View(updateRoleViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
        {
            var role = _roleManager.Roles.FirstOrDefault(r=>r.Id== updateRoleViewModel.RoleId);
            role.Name= updateRoleViewModel.RoleName;
            await _roleManager.UpdateAsync(role);
            return RedirectToAction("Index", "AdminRole");
        }

    }
}
