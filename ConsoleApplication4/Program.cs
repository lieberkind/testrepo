using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<person>() {
                new person() { age = 12, Name = "owjdw" },
                new person() { age = 23, Name = "woqdkjowd" }
            };



            var results = persons.Where(p => p.age > 13).ToList();
            var results2 = (from p in persons where p.age > 13 select p).ToList();

            //Func<int, int> f = JS.function(n => n * 2);



        }
    }

    class person
    {
        public string Name { get; set; }
        public int age { get; set; }
    }
}
