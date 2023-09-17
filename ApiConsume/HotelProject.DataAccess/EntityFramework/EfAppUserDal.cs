using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.Repositories;
using HotelProject.DTO.DTO.AppUserDTO;
using HotelProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HotelProject.DataAccess.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {

        }

        public int GetAppUserCount()
        {
            using(var context = new Context())
            {
                var value = context.Users.Count();
                return value;
            }
        }

        public List<AppUserWorkLocationDTO> UserListWithWorkLocations()
        {
            Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWorkLocationDTO
            {
                Name = y.Name,
                Surname = y.Surname,
                WorkLocationId = y.WorkLocationId,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                WorkLocationCity = y.WorkLocation.WorkLocationCity,
                City = y.City,
                Country = y.Country,
                Gender = y.Gender,
                ImageUrl = y.ImageUrl
            }).ToList();
            return values.ToList(); 
        }
    }

}
