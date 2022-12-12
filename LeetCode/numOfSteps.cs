using System;
using System.Collections.Generic;
// using LinkedList;
// using static LongFactorial.DSAMosh.LinkedList<T>;

namespace LongFactorial.LeetCode
{
    public class numOfSteps
    {
        public int NumberOfSteps(int num) {
            int NumberOfSteps = 0;
            while(num > 0){
                if(num % 2 == 0){
                    num = num / 2;
                }
                else num = num - 1;
                NumberOfSteps++;
            }
            return NumberOfSteps;
        }
    }
    public class middleNodeOfLlist
    {
        public LinkedListNode<int> middleNode(LinkedListNode<int> head)
        {
            int count = 0, count2 = 0;

            var currentNode = head;
            while(currentNode != null){
                currentNode = currentNode.Next;
                count++;
            }
            var nowNode = head;
            var upperBound = Math.Ceiling((double)count / 2);
            while(count2 < upperBound)
            {
                nowNode = nowNode.Next;
                count2++;
            }

            return nowNode;
        }
    }
}
          