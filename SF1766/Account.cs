﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF1766
{
    public class Account
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }
        public void GetInterest(ICalculateInterest calculateInterest)
        {
            Interest = calculateInterest.CalculateInterest(Balance);
        }
    }
}
