using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongFactorial.DSAMosh
{
    public class LinkedList<T>
    {
         public class Node<T>
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
             public T[] toArray()
             {
                var current = first;
                var arrList = new List<T>();
                while(null != current.next){
                    current = current.next;
                    arrList.Add(current.value);
                    arrSize++;
                }
                
                 return arrList.ToArray();
             }

            public int indexOf(T value){
                var current = first;
                int index = 0;
                while(current != null){
                    if(current.value.Equals(value)) return index;
                    else{
                        current = current.next;
                        index++;
                    }
                }
                throw new Exception("No such value exists in this LinkedList");
            }
                
                   
            public void removeFirst(){
                var second = first.next;
                first.next = null;
                first = second;
            }
            public void removeLast(){
                var previous = findPrevious(last);
                previous.next = null;
                last = previous;
            }
                
          
             
            public int kthFromLast(T item){
                var flag = 0;
                var counter = 0;
                var pointer = first;
                while(pointer.next != null){
                    if(pointer.value.Equals(item))
                        flag = 1;
                    pointer = pointer.next;    
                    if(flag == 1)
                       counter++;    
                }
               return counter;
            }
                          
            public Node<T> findPrevious(Node<T> node){
                var current = first;
                while(null != current)
                {
                    if(current.next == node) return current;
                    current = current.next;
                }
                return null;
            }

            public void reverse()
            {
                var previous = first;
                var current = first.next;
                previous.next = null;   
                while(current != null){
                    var next = current.next;
                    current.next = previous;
                    previous = current;
                    current = next;
                }
                last = first;
                last.next = null;
                first = previous;
            }
            public string print(){
                StringBuilder stringBuilder = new StringBuilder();
                var current = first;
                stringBuilder.Append(first.value);
                current = current.next;
                while(current != null){
                    stringBuilder.Append($", {current.value}");
                    current = current.next;
                }
                return $"[{stringBuilder.ToString()}]";
            }
    }
}
