using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongFactorial.DataStructures.cs
{
    public class Recursion
    {
        public void Test(int n)
        {
            if(n > 0)
            {
                Console.WriteLine(n);
                Test(n - 1);
            }

        }
    }
}