using System.Collections.Generic;
using System.Linq;

public class ForLoopTestClass
{
    public ForLoopTestClass()
    {
        
    }

    public void SaySomething(){
        
    }
    public bool CheckIfLoopBreaks(){
        List<int> figures = new List<int>{ 1,2,4,3,4,5,6,6,7,8};
        
        for (int i = 0; i< 12; i++)
        {
            if(figures[i] == 3){
                // return true;
                break;
            }
        }
        return true;
    }
    public static List<int> ListTest(){
        List<int> arrayList = new List<int>();
        for (int i = 0; i < 10000; i++)
        {
            arrayList.Add(i);
        }   
        var sinetoga = arrayList.AsParallel();
        return arrayList;
    }
} 
            