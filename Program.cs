using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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
        //    var linkedList = new LinkedList.LinkedList();
        //    linkedList.AddNodeToFront(6);
        //    linkedList.AddNodeToFront(12);
        //    linkedList.AddNodeToFront(1);
        //    linkedList.AddNodeToFront(7);
        //    linkedList.PrintList();
        }
        
    }
}
            
            