using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SF1766
{
    internal class GeneralAccountCalculateInterest : ICalculateInterest
    {
        public double CalculateInterest(double balance)
        {
            double interest = balance * 0.4;
            if (balance < 1000)
                interest -= balance * 0.2;
            else
                interest -= balance * 0.3;
            return interest;
        }
    }
}
