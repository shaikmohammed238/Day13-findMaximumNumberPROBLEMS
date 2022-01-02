using System;
using System.Collections.Generic;
using System.Text;

namespace FIND_MAXIMUM_THREE_NUMBERS
{
    public class Uc3maximum_3_strings
    {
        public  static string MaximumString(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0)
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0)
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0)
            {
                return thirdString;
            }
            throw new Exception("firstString, SecondString, thirdString are same");
        }

    }
}
