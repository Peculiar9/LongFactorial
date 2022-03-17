using System;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using System.IO;

public static class ChunkTestClass
{
    public static IEnumerable<List<T>> Partition<T>(this IList<T> source, Int32 size)
    {
    for (int i = 0; i < (source.Count / size) + (source.Count % size > 0 ? 1 : 0); i++)
        yield return new List<T>(source.Skip(size * i).Take(size));
    }
    public static void ChunkTest(){
       
            
        List<int> list = new List<int>();
        int size = (int)(Math.Ceiling((decimal)(10000/5)));
        var listOfList = list.Partition<int>(size);
           for (int i = 0; i < listOfList.ToList().Count; i++)
           {
                Console.WriteLine();
                listOfList.ToList()[i].ForEach(s => Console.Write($" {s},"));
                File.WriteAllLines($"text{i+1}.txt", listOfList.ToList()[i].Select(x => string.Join(",", x)));
           }                 
    }   
    public static void LinqTest(){
        var list = new List<int>();
        var customerList = new List<Customer>();
        var random = new Random(12);
        for (int i = 0; i < 10000; i++)
        {
            customerList.Add(
                new Customer{
                    id = ((byte)i),
                    identification = $"obj{random.Next()}i!{i*2}",
                    name = $"someone{i} {random.NextDouble()}//Love"
                }
            );
        }
        var somethingElse = customerList.Select(x => x).Where(x => x.id % 2 == 0);
        somethingElse.ToList().ForEach(x => Console.WriteLine(x.name));
    }

    internal class Customer {
        public int id { get; set; }
        public string identification { get; set; }
        public string name { get; set; }
    }
}
              
                
        