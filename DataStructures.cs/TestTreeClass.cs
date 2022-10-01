using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongFactorial.DataStructures.cs
{

    public class TestTreeClass
    {
        public class Node
        {
            private int data;
            Node left, right;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }
        public TestTreeClass()
        {
            
        }
    }
}