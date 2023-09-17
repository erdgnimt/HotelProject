using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public int GetStaffCount()
        {
            return _staffDal.GetStaffCount();
        }

        public void TDelete(Staff entity)
        {
            _staffDal.Delete(entity);   
        }

        public Staff TGetById(int id)
        {
            return _staffDal.GetById(id);
        }

        public List<Staff> TGetLastFourStaff()
        {
            return _staffDal.GetLastFourStaff();
        }

        public List<Staff> TGetList()
        {
            return _staffDal.GetList(); 
        }

        public void TInsert(Staff entity)
        {
            _staffDal.Insert(entity);
        }

        public void TUpdate(Staff entity)
        {
            _staffDal.Update(entity);
        }
    }
}
