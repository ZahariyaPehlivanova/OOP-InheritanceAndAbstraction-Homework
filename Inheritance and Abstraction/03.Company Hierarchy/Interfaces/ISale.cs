﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Interfaces
{
    public interface ISale
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
    }
}