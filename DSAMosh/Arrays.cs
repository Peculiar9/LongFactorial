using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongFactorial.DSAMosh
{
    public class Arrays
    {
        private readonly int length;
        private int[] array;
        public int i;
        public Arrays(int length){
            this.length = length;
            this.array = new int[length];
            this.i = 0;
        }
        
        public void insert(int value){
            if(i > length - 1)
                throw new Exception("Index is greater than length of array");
            array[i] = value;
            i++;
        }
        public void printArray(){
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        public void removeAt(int index){

        }
        public int indexOf(int item){
            for(int i = 0; i < array.Length; i++)
            {
               if(array[i] == item){
                   return i;
               }
            else {throw new Exception("Item not found");}
            }
            return -1;
        }
    }
                
            

}
            
            
