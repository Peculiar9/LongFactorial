public class QuickSortClass
{
    public static void QuickSort(int[] numbers)
    {
        int left = 0, right = 0;
        SortingFunction(numbers, left, right);
    }
   public static void SortingFunction(int[] numbers, int left, int right){
       int i = left, j = right, mid = (left+right)/2;
       var pivot = numbers[mid];
       while (i <= j)
       {
           while (numbers[i] < pivot)
               i++;
           while (numbers[j] > pivot)
               j--;
           
           if (i<=j)
           {
               int temp = numbers[i];
               numbers[j] = numbers[i];
               numbers[i] = numbers[j];
               i++;
               j--;
           }
       }
   }
}