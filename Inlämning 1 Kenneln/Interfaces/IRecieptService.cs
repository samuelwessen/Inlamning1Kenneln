﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_Kenneln.Interfaces
{
    public interface IRecieptService
    {
        public void GetAllReciepts(List<ICustomer> customerList);
    }
}
