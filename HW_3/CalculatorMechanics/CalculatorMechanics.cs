using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3.CalculatorMechanics
{
    internal class CalculatorMechanics
    {
        private bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
            {
                return true;
            }
            return false;
        }
    }
}
