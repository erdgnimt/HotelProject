﻿using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.Abstract
{
    public interface IRoomDal : IGenericDal<Room>
    {
        int GetRoomCount();
    }
}