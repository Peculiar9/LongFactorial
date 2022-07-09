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

       public void AddHeadNode(int data){
           Node headNode = new Node(data);
           headNode.data = data;
           head = headNode;
       }
           
    }
  
}