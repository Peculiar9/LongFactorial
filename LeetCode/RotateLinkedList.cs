using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongFactorial.LeetCode
{
    public class RotateLinkedList<T>
    {
        // public Node<T> rotate(DSAMosh.LinkedList<T>.Node<T> head, int k)
        // {
        //   if(k == 0) return null;
        //   Node<T> current = head;
        //   int times = 1;
        //   while(times < k && current != null)
        //   {
        //       current = current.next;
        //       times++;
        //   }
        //   if(current == null ) return null;
          
        //   Node<T> presentNode = current;
        //   while(current.next != null) current = current.next;
        //   current.next = head;
        //   head = presentNode.next;
        //   presentNode.next = null;
        //   return head;
        // }  //yOU GET THE POINT
    }
}