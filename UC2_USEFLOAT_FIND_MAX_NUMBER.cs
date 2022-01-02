using System;
using System.Collections.Generic;
using System.Text;

namespace FIND_MAXIMUM_THREE_NUMBERS
{
    //Given 3 Floats find the maximum//
    public class UC2_USEFLOAT_FIND_MAX_NUMBER
    {

        public static double MaximumFloatNumber(  double firstValue,  double secondValue,  double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return  firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber, SecondNumber, thirdNumber are same");
        }

    }
}
