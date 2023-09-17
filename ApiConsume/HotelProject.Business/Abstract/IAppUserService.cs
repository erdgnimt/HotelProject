using HotelProject.DTO.DTO.AppUserDTO;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Abstract
{
    public interface IAppUserService:IGenericService<AppUser>
    {
        List<AppUserWorkLocationDTO> TUsersListWithWorkLocations();
        int TGetAppUserCount();
    }
}
