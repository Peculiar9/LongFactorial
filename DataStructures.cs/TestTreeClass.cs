using System;

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
        public bool findItem(int item)
        {
            var current = root;
            while(current != null)
            {
                if(item < current.data) current = current.left;
                else if(item > current.data) current = current.right;
                else{return true;}
            }
           return false;
        } 
        public void preorderTraversal(){
            preorderTraversal(root);
        }
        private void preorderTraversal(Node root)
        {
            if(root == null) return;
            Console.WriteLine(root.data);
            preorderTraversal(root.left);
            preorderTraversal(root.right);
        }
   }
}
                        


