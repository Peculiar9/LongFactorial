using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LongFactorial
{

    public class Program
    {
        public static int Sqr(char e){
            var x = (int)Math.Pow((double)(int)e, 2);
            return x;
        }
        // public static double dateTimeToUnix(string dateTime)
        // {
        //     DateTime dt = new DateTime(dateTime);
        //     double unixResult = DateTime.UtcNow.Subtract().TotalMinutes;
        //     return unixResult;
        // }
        static bool mailSent = false;
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
             String token = (string) e.UserState;

            if (e.Cancelled)
            {
                 Console.WriteLine("[{0}] Send canceled.", token);
            }
            if (e.Error != null)
            {
                 Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
            } else
            {
                Console.WriteLine("Message sent.");
            }
            mailSent = true;
        }
        static void Main(string[] args)
        {

          var sums = new TwoSums2();
          var nums = new int [] {3,2,4};
          var twoSums = sums.TwoSums(nums, 6);
          StringBuilder builder = new StringBuilder();
          builder.Append('[');
          foreach (var item in twoSums)
          {
            builder.Append(item);
          }
          builder.Append(']');
          Console.Write(builder);
        }
        
    }

}
            
            
        