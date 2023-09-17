﻿using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Abstract
{
    public interface IStaffService:IGenericService<Staff>
    {
        int GetStaffCount();
        List<Staff> TGetLastFourStaff();
    }
}
