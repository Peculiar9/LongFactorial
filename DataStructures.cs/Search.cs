using System;
using System.Collections.Generic;

public class Search
{

    public static int LinearSearch(List<int> list, int item)
    {
        foreach (var num in list)
        {
            if(item == num) return 1;
        }
        return -1;
    }
    
    public static string BinarySearch(List<int> list, int item)
    {
        int low = 0, high = list.Count - 1, mid = (int)(Math.Round((decimal)((low + high) / 2)));
        while(low <= high)
        {
        int guess = list[mid];
           if (guess == item)
               return $"[{item}] - {mid}";
           else if (guess < item)
               low = mid;
           else high = mid;
        }


        return $"[{1}] - {-1} Not found";
    }
}
        
