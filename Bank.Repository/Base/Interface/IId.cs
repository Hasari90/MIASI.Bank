﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository.Base.Interface
{
    public interface IId<T> where T: struct
    {
        T ID { get; set; }
    }
}
