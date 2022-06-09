using System;
using System.Collections.Generic;
using System.Linq;

namespace Genereics
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            // Task 3 and 4
            var numberOfLine = int.Parse(Console.ReadLine());
            //var list = new List<int>();
            //for (int i = 0; i < numberOfLine; i++)
            //{
            //    var input = int.Parse(Console.ReadLine());
            //    list.Add(input);
            //}
            //var box = new Box<int>(list);
            //var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //box.Swap(list, indexes[0], indexes[1]);
            //Console.WriteLine(box);

            // Task 5 and 6
            var list = new List<double>();
            for (int i = 0; i < numberOfLine; i++)
            {
                var input = double.Parse(Console.ReadLine());
                list.Add(input);
            }

            var box = new Box<double>(list);
            var elementToCompare = double.Parse(Console.ReadLine());
            var count = box.CountOFGreaterElements(list, elementToCompare);
            Console.WriteLine(count);
        }
    }
}
