using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LongFactorial.DSAMosh.LinkedList<int>;

namespace LongFactorial.LeetCode
{
    public class RemoveNodeFromNth
    {
        public RemoveNodeFromNth()
        {
            addReqNodes();
        }
        private void addReqNodes()
        {
            LinkedList<int> lList = new LinkedList<int>();
            lList.AddFirst(1);
            lList.AddFirst(2);
            lList.AddFirst(3);
            lList.AddFirst(4);
            lList.AddFirst(5);
        }
        public Node<int> removeNth(Node<int> head, int n)
        {
            var current = head;
            var pointer = head;
            if(null == head || head.next.Equals(null)) 
                return null;
            for(int i = 0; i < n; i++){
                current = current.next;
            }
            var trailer = head;
            while(current.next != null){
                current = current.next;
                if(current.next.next.Equals(null))
                    trailer = pointer;
                pointer = pointer.next;
            }
            trailer.next = pointer.next;
            return head;
        }
        
    }
}
               
                