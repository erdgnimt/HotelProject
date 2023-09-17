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
    public class EfBookingDal:GenericRepository<Booking>,IBookingDal
    {
        public EfBookingDal(Context context) : base(context){}
        public void BookingStatusChangeApproved(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";
            values.CheckIn=DateTime.Now;
            values.CheckOut = DateTime.Now;
            context.SaveChanges();
        }

        public void BookingStatusChangeCancel(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "İptal Edildi";
            values.CheckIn = DateTime.Now;
            values.CheckOut = DateTime.Now;
            context.SaveChanges();
        }

        public void BookingStatusChangeWait(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Donduruldu";
            values.CheckIn = DateTime.Now;
            values.CheckOut = DateTime.Now;
            context.SaveChanges();
        }

        public int GetBookingCount()
        {
            using(var context = new Context())
            {
                var value = context.Bookings.Count();
                return value;
            }
        }

        public List<Booking> GetLastSixBookings()
        {
            using (var context = new Context())
            {
                var values = context.Bookings.OrderByDescending(b=>b.BookingId).Take(6).ToList();
                return values;
            }
        }
    }
}
