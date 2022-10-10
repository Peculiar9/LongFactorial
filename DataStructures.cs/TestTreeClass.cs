namespace LongFactorial.DataStructures.cs
{

    public class TestTreeClass
    {
        public class Node
        {
            public Node left, right;
            public int data;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }
        public Node root;
        public TestTreeClass()
        {

        }
        public void addItem(int item)
        {
            var node = new Node(item);
            if (root == null){
                root = node;
                return;
            } 
            var current = root;
                
            
                while (true)
                {
                    if (item < current.data)
                    {
                        if (null == current.left)
                        {
                            current.left = node;
                            break;
                        }
                        current = current.left;
                    }
                    else
                    {
                        if (null == current.right)
                        {
                            current.right = node;
                            break;
                        }
                        current = current.right;
                    }
                }
        }
    }
}
