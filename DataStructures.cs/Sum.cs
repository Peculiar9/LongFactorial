using System.Collections.Generic;
using System.Linq;

public class Sum
{
  public static int SumFnx(List<int> list){
      list[0] = 1;
     var firstElement = list[0];
      if (list.Count == 1)
          return firstElement;
    //  list.Skip().Take();
     var restOfTheList = list.GetRange(1, list.Count - 1);
     return firstElement + (firstElement + SumFnx(restOfTheList));
  } 
}
 

        
// [1,2,3,4,5,6,7,8]