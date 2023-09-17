using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.DTO.DTO.AppUserDTO;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TDelete(AppUser entity)
        {
            _appUserDal.Delete(entity);
        }

        public int TGetAppUserCount()
        {
            return _appUserDal.GetAppUserCount();
        }

        public AppUser TGetById(int id)
        {
           return _appUserDal.GetById(id);
        }

        public List<AppUser> TGetList()
        {
            return _appUserDal.GetList();
        }

        public void TInsert(AppUser entity)
        {
            _appUserDal.Insert(entity);
        }

        public void TUpdate(AppUser entity)
        {
            _appUserDal.Update(entity);
        }
       
        public List<AppUserWorkLocationDTO> TUsersListWithWorkLocations()
        {
            return _appUserDal.UserListWithWorkLocations();
        }
    }
}
