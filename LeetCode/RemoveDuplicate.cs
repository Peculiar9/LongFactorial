using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongFactorial.LeetCode
{
    public class RemoveDuplicate
    {
        public bool removeDup(int[] nums){
            var hashSet = new HashSet<int>();
            foreach (var item in nums)
            {
                if(hashSet.Contains(item))
                    return true;
                hashSet.Add(item);   
            }
            return false;
        }
    } //improve solution in the future
}