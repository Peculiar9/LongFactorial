using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongFactorial.LeetCode
{
    public class NumUniqueEmails
    {
        public int Solution(string[] emails){
            var noOfEmails = 0;
            foreach(var mail in emails){
                if(verifyMail(mail)) noOfEmails++;
            }
            return noOfEmails;
        }
        public bool verifyMail(string mail){
            
            var mailStrings = mail.Split('@');
            if(mailStrings.Count() > 2) return false; 
            if(mailStrings.Count() == 1) return false; 
            if(mailStrings[0].Split('.').Count() > 2) return false;
            return true;
        }
    }
}