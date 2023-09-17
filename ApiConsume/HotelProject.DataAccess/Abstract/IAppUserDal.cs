using HotelProject.DTO.DTO.AppUserDTO;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.Abstract
{
    public interface IAppUserDal:IGenericDal<AppUser>
    {      
        List<AppUserWorkLocationDTO> UserListWithWorkLocations();
        int GetAppUserCount();
    }
}
