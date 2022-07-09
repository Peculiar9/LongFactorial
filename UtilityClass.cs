using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using AutoMapper;

public class UtilityClass
{
    
    CultureInfo enUS = new CultureInfo("en-US");
    string dateString;
        public static ulong Factorial(ulong number)
        {
            if (number < 1)
                return 1;
            return number * Factorial(number - 1);
        }

        public static void SomeList()
        {

            List<User> chList = new List<User>();
            
            chList = new List<User> {
               new User{
                   Id = 1,
                   name = "Someone Great",
                   address = "Another Address"
               },
               new User{
                   Id = 2,
                   name = "Someone Great 2",
                   address = "Another Address 2"
               },
               new User{
                   Id = 3,
                   name = "Someone Great 3",
                   address = "Another Address 3"
               },
               new User{
                   Id = 4,
                   name = "Someone Great 3",
                   address = "Another Address 3"
               },
            };

            var chList2 = new List<User2>();
            //Source 2
            var chListDestination = new List<User3>{
                new User3{
                    people = "Andrea"
                },
                new User3{
                    people = "Bruno"
                },
                 new User3{
                    people = "Ramirez"
                },
            }

            ;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, User2>().ForMember(dest => dest.address, opt => opt.MapFrom(src => src.name));
                cfg.CreateMap<User3, User2>().ForMember(dest => dest.people, opt => opt.MapFrom(src => src.people.ToString()));
            });

            var mapper = new Mapper(config);

            var figMap = mapper.Map<List<User>, List<User2>>(chList);
            // mapper.Map(chListDestination, chList2);
            mapper.Map(chListDestination, chList2); 
        
            foreach (var item in chList2)
            {
                Console.WriteLine(item.address + "\n" + $"name: {item.name}");
            } 
        }
        private static string ImageFormatter(StringBuilder newString)
        {

            StringBuilder builder = new StringBuilder();
            builder.Append(newString);

            if(builder.ToString().StartsWith("data:image/jpeg;base64,"))
            {
                builder.Replace("data:image/jpeg;base64,","");
            }
            else
            {
               return builder.ToString();   
            }
            return builder.ToString();
          
        }
 public enum Something{
     EVER = 1,
     FOREVER = 2
 }

  public class User 
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }
     internal class User3
    {
        public int Id { get; set; }
        public string people { get; set; }
    }
    
    internal class User2
    {
         public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string people { get; set; }
    }
   
        // public static string DateFormatter(string dateString)
        // {
        //    Console.WriteLine($"Number {}");
        
        // }
}