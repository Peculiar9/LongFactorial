using System;
using static LongFactorial.DSAMosh.LinkedList<T>;

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
        public Node<int> middleNode(Node<int> head)
        {
            int count = 0, count2 = 0;

            var currentNode = head;
            while(currentNode.next != null){
                currentNode = currentNode.next;
                count++;
            }
            var nowNode = head;
            while(count2 < Math.Ceiling((double)count / 2))
            {
                nowNode = nowNode.next;
            }

            return nowNode;
        }
    }
}
          