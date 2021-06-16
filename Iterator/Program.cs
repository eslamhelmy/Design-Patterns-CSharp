using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ProductCollection col = new ProductCollection();
            col.Add(new Product
            {
                Id = 1
            });
            col.Add(new Product
            {
                Id = 2
            });

            while (col.MoveNext())
            {
               var x =  col.Current;
            }
            
            foreach (var item in col)
            {
                var x = item;
            }
            var iterator = col.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current().Id);
                iterator.Next();
            }

            var list = new List<int> { 1, 2, 3 };
            var enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
               var current =  enumerator.Current;
                Console.WriteLine(current);
            }

            
        }
    }
}
