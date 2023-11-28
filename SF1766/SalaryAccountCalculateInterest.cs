using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF1766
{
    internal class SalaryAccountCalculateInterest : ICalculateInterest
    {
        public double CalculateInterest(double balance) 
        {
            return balance * 0.5;
        }
    }
}
