using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_MSTest_Framework
{
    public class Calculator
    {
        public static int Divide(int numerator,int denominator)
        {
            int result;
                if(!isPositive(denominator))
                {
                    throw new DivideByZeroException("Cannot divide by 0");
                }
                else
            {
                result = (numerator / denominator);
            }
               
            return result;


        }

        public int InstanceDivide(int numerator, int denominator)
        {
            int result;
            if (!this.instanceIsPositive(denominator))
            {
                throw new DivideByZeroException("Cannot divide by 0");
            }
            else
            {
                result = (numerator / denominator);
            }

            return result;


        }
        private static bool isPositive(int number)
        {
            return number > 0;
        }

        private bool instanceIsPositive(int number)
        {
            return number > 0;
        }
    }
}
