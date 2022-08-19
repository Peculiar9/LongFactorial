using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongFactorial.LeetCode
{
    public class validAnagram
    {
        public bool IsAnagram(string s, string t) 
        {
        int[] store = new int[26];

        for (int i = 0; i < s.Length; i++) {
            store[s.ElementAt(i) - 'a']++;
            store[t.ElementAt(i) - 'a']--;
        }
           foreach(int n in store) if( n!= 0) return false;
           return true;
        }
    }
}