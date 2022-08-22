using System.Globalization;
using System.Runtime.ExceptionServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongFactorial.LeetCode
{
    public class LinkedList<T>
    {
       private class Node<T>
       {
               public T value;
               public Node<T> next;
               public Node(T value){
                 this.value = value;
               }
            }
            private int arrSize;
            private Node<T> first;
            private Node<T> last;

            public void addFirst(T item)
            {
             var node = new Node<T>(item);
             if(null == first)
                 first = last = node;

             else{
                 node.next = first;
                 this.first = node;
             }
            }

             public void addLast(T item){
                 var node = new Node<T>(item);
                 //if node is empty
                 if(null == last)
                     first = last = node; // the first and last is the node since it it the only node in the linked list
                 else {
                     //point the present last to the new and assign the last to the new node(i.e the new last)
                     this.last.next = node;
                     last = node; //assigning last status to the new last (i.e the new node)
                 }    
             }

             public int size(){
                return arrSize;
             }
             public T[] toArray(){
                var array = new T[arrSize];
                var current = first;
                for (int i = 0; i < 100; i++)
                {
                    array[i] = current.value;
                    current = current.next;
                    if(current.next == null)
                        break;
                }
                 return array;
             }
            public void removeFirst(){
                var second = first.next;
                first.next = null;
                first = second;
            }
            public void reverse(){
                var current = first.next;
                var previous = first;
                previous.next = null;
                current.next = first;
                first = current;
                

            }
    }
}
