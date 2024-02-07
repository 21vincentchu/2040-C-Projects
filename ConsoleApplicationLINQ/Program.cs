using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplicationLINQ;

class Program
{
    static void Main(string[] args)
    {
        var people = new List<Person>
        {
            new Person {FirstName = "john", LastName = "twitch", Age = 25},
            new Person {FirstName = "jane", LastName = "v2ce", Age = 23},
            new Person {FirstName = "vinny", LastName = "chy", Age = 21},
            new Person {FirstName = "issac", LastName = "isapot", Age = 24},
            new Person {FirstName = "doie", LastName = "girl", Age = 20},
            new Person {FirstName = "bob", LastName = "mcbobberson", Age = 25}
        };

        //get all the vowels in the sentence. can be used for objects, etc.
        
        var result = from p in people
                     orderby p.LastName descending
                     group p by p.LastName;
                     
                
        foreach (var item in result)
        {
            Console.WriteLine(item.Key + " - " + item.Count());
            foreach(var p in item)
            {
                Console.WriteLine("{0}, {1}", p.LastName, p.FirstName);
            }
        }

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
