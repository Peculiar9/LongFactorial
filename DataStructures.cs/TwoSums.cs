using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class TwoSumsClass{
    public static int Complement(int n, int target){
        var complement = target - n;
        return complement;
    }
           
    public static int[] TwoSums(int[] nums, int target)
    {
        
        var sumsHash = new Hashtable();
        var arrayOfInt = new List<int>();
            if (nums.Length <= 2)
            {
                if(nums[0].Equals(Complement(nums[0], target)) || ((nums[0] + nums[1]) == target)) return new int[2]{0,1};
                
            }
           
              for (int i = 0; i < nums.Length; i++)
              { 
                 sumsHash.Add(nums[i], i);
              }
              for (int j = 0; j < nums.Length; j++)
              {
                  var comp = Complement(nums[j], target);
                  if (sumsHash.ContainsKey(comp))
                  {
                      arrayOfInt.Add(j);
                      arrayOfInt.Add((int)sumsHash[comp]);
                      break;
                  }
              } 
           
        return arrayOfInt.ToArray();
    }
}
              

       
              
            
               
            
//  var numsList = new ArrayList(nums);
//         var sumsHash = new Hashtable();
//         int[] arrayOfInt = new int[5];
//         var middle = 0;
//         if (nums.Length % 2 == 0)
//         {
//             middle = nums.Length / 2;
//             for (int i = 0; i < ; i++)
//             {
                
//             }
//         } else 
//         if(nums.Length % 2 != 0)
//         {middle = ((nums.Length - 1) / 2) + 1;}        
                
