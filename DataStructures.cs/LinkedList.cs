namespace LinkedList
{

    public class LinkedListNode {
        public LinkedListNode next;
        public int data;
        public LinkedListNode(int data)
        {
            this.data = data;
            next = null;
        }
    }
    // [InitNode] -> null;
    //   Head
    public class LinkedList{
        LinkedListNode head;
        public int count;
        public LinkedList()
        {
            head = null;
            count = 0;
        }
        public void AddNodeToFront(int data){
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node; // the new node is now the head. So the head references to it. 
            
            count++;
        }
        public void removeNodeFromFront(){
            
        }
        public void PrintList(){
            LinkedListNode runner = head;
            while (runner != null)
            {
                System.Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }
    }


    public class Node<T>
    {
        public Node<T> Next {get; set;}
        public T Value {get; set;}
    }
    public class LinkedList<T>
    {
        public Node<T> Root { get; private set; }
        public (Node<T> previous, Node<T> found) FindFirst(T Value)
        {
            Node<T> previous = null;
            Node<T> current = Root;
            if(null == current) return (null, null);
            if(current.Value.Equals(Value)) return (null, Root);
            do
            {
                previous = current;
                current = current.Next;
                if(current.Value.Equals(Value))
                return (previous, current);
            } while(null != current.Next);
            return (null, null);
        }
    }
}