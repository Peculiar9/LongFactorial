using System;

public class SalarySort
{
    public static double Average(int[] salary){
        Array.Sort(salary);
        int sum = 0;
        int start = 1, i,j, end = salary.Length;
        var middle = 0;
        
        
        if (salary.Length % 2 != 0)
        {
           middle = ((salary.Length - 1) / 2) + 1;
           i = middle - 1; j = middle + 1;
           while (i != start && j != end)   
            {
                sum = sum + (salary[i-1] + salary[j-1]);
                i--; j++;    
            }
            sum = sum + salary[middle - 1];
        } 
        else if (salary.Length % 2 == 0)
        {
            middle = (salary.Length) / 2;         
            i = middle; j = middle + 1;
            while (i != start && j != end)
            {
                sum = sum + (salary[i-1] + salary[j-1]);
                i--; j++;    
            }
        }
            

        
        
        var divisor = salary.Length - 2;
        var average = Math.Round((Double)sum / divisor, 5);
        return average;
    }
    public static int HammingWeight(uint n){
        int count = 0;
        string stringn = n.ToString();
        for (int i = 0; i < stringn.Length; i++)
        {
            if (stringn[i] == '1')
            {
                count++;
            }
        }
        return count;
    }
     public static int SubtractProductAndSum(int n) {
        int sum = 0, prod = 1;
        if(n.ToString().Length > 1){
        foreach(var num in n.ToString()){
            sum = sum + Int32.Parse(num.ToString());
            prod = prod *  Int32.Parse(num.ToString());
        }
        }
        return prod - sum;
    }
  
     public static int SubtractProductAndSum2(int n) {
         int sum = 0, prod = 1;
      
         string nstring = n.ToString().Trim();
         int start = 0, end = nstring.Length - 1, i, j, middle = 0;
         if(nstring.Length % 2 != 0)
         {
            middle = ((n.ToString().Length - 1) / 2) + 1;
            
            i = middle - 1;
            j =  middle + 1;
            while(i > start && j < end){
                sum = sum + ((int)nstring[i - 1] + (int)nstring[j - 1]);
                prod = prod * ((int)nstring[i - 1] + (int)nstring[j - 1]);
            }
           sum = sum + nstring[middle - 1];
           prod = prod * nstring[middle - 1];
            
         }
         if (nstring.Length % 2 == 0)
         {
             
         }
      
        return prod - sum;
    }

}