using System.Globalization;
using System.Runtime.ExceptionServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongFactorial.LeetCode
{
    public class LinkedList
    {
       private class Node
       {
          private int value;
          public Node next;
          public Node(int value){
            this.value = value;
          }
       }

       private Node first;
       private Node last;
       public void addFirst(int item){
        var node = new Node(item);
        if(null == first)
            first = last = node;
            
        else{
            this.first.next = node;
            this.first = node;
        }
       }
        public void addLast(int item){
            var node = new Node(item);
            //if node is empty
            if(null == last)
                first = last = node; // the first and last is the node since it it the only node in the linked list
            else {
                //point the present last to the new and assign the last to the new node(i.e the new last)
                this.last.next = node;
                last = node; //assigning last status to the new last (i.e the new node)
            }    
        }
        
    }
}