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
        private bool IsOperator(char c)
        {
            if ("+-/*()".IndexOf(c) != -1)
            {
                return true;
            }
            return false;
        }
        private byte GetPriority(char c)
        {
            switch (c)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 5;

                default: return 6;
            }
        }
    }
}
