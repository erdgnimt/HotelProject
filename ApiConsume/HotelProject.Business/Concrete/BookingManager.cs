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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TBookingStatusChangeApproved(int id)
        {
            _bookingDal.BookingStatusChangeApproved(id);
        }

        public void TBookingStatusChangeCancel(int id)
        {
            _bookingDal.BookingStatusChangeCancel(id);
        }

        public void TBookingStatusChangeWait(int id)
        {
            _bookingDal.BookingStatusChangeWait(id);
        }

        public void TDelete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }

        public int TGetBookingCount()
        {
            return _bookingDal.GetBookingCount();
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);
        }

        public List<Booking> TGetLastSixBookings()
        {
            return _bookingDal.GetLastSixBookings();
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public void TInsert(Booking entity)
        {
            _bookingDal.Insert(entity);
        }

        public void TUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }
    }
}
