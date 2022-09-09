using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongFactorial.DSAMosh
{
    public class QueueSolution
    {
        public string QueueOps()
        {
            Queue<int> queue = new Queue<int>();
            var stringBuilder = new StringBuilder();
            
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            var peek = queue.Reverse();
            return peek.ToString();
        }
        
        
      
    }
}   
                