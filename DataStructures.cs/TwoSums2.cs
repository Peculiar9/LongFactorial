using System.Collections.Generic;

public class TwoSums2{
    public int[] TwoSums(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if(map.ContainsKey(complement)){
                return new int[] {map.GetValueOrDefault(complement), i};
            }
            map.Add(nums[i], i);
        }
        return new int []{};
    }
}