namespace DynamicDataStructures
{
      public class Node {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        } // Constructor
    }
    public class LinkedListNew
    {
       Node head; 
       Node last;
       public void AddHeadNode(int data){
           Node headNode = new Node(data);
           if(head == null){
              head = last = headNode;
           }
           headNode.next = head;
           head = headNode;
       }
       public void AddLastNode(int data){
         Node lastNode = new Node(data);
         var current = head;
         if(lastNode == null)
            head = last = lastNode;
         while(current.next != null)
            current = current.next;
         current.next = lastNode;
         last = lastNode;
       }
           
    }
  
}