using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.Repositories;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.EntityFramework
{
    public class EfStaffDal:GenericRepository<Staff>,IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {

        }

        public int GetStaffCount()
        {
            using(var context=new Context())
            {
                var value = context.Staffs.Count();
                return value;
            }
        }

        public List<Staff> GetLastFourStaff()
        {
            using (var context = new Context())
            {
                var values = context.Staffs.OrderByDescending(s=>s.StaffId).Take(4).ToList();
                return values;
            }
        }
    }
}
