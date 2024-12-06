using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEXP
{
    public class Calculator
    {
        public int Add(int one, int two)
        {

            if(one==0)
            {
                return 0 + two;
            }

            return one + two;
        }
        public int Subtract(int one, int two)
        {
            return one - two;
        }
    }
}
