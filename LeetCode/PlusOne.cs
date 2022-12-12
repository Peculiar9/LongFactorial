using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongFactorial.LeetCode
{
    public class PlusOne
    {
        public int[] plusOne(int[] digits)
        {
            if(digits.Length == 1){
            var nums = digits[0] + 1;
            var llist = new List<int>();
           if(digits[0] ==  9)
              return new int[]{1,0};
            else
                llist.Add(nums);
            return llist.ToArray();
        }
        digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
        return digits;
        }
    }
}
