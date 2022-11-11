using System.Collections.Generic;
// using LongFactorial.DSAMosh;
using LongFactorial.LeetCode;

namespace LongFactorial
{

    public class Program
    {
        static void Main(string[] args)
        {
           int[] nums = {1,2,3,4,5};
           var lList = new LinkedList<int>();
           foreach (var item in nums)
           {
              lList.AddLast(item);
           }
           var midNode = new middleNodeOfLlist();
           midNode.middleNode(lList.First);
          // lList.reverse();
          // TestTreeClass tree = new TestTreeClass();
          // var array = new int[]{10, 5, 15, 6, 1, 8, 12, 18, 17};
          // foreach (var it in array)
          // {
          //    tree.addItem(it);
          // }
          // var found = tree.f indItem(12);
          // Console.WriteLine(found);
          // tree.preorderTraversal();
        }
    }
}

            
            
        

          
        

        // public static int Sqr(char e){
        //     var x = (int)Math.Pow((double)(int)e, 2);
        //     return x;
        // }
        // public static double dateTimeToUnix(string dateTime)
        // {
        //     DateTime dt = new DateTime(dateTime);
        //     double unixResult = DateTime.UtcNow.Subtract().TotalMinutes;
        //     return unixResult;
        // }
        // static bool mailSent = false;
        // private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        // {
        //     // Get the unique identifier for this asynchronous operation.
        //      String token = (string) e.UserState;

        //     if (e.Cancelled)
        //     {
        //          Console.WriteLine("[{0}] Send canceled.", token);
        //     }5
        //     if (e.Error != null)
        //     {
        //          Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
        //     } else
        //     {
        //         Console.WriteLine("Message sent.");
        //     }
        //     mailSent = true;
        // }
      