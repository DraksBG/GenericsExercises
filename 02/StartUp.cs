using System;
namespace Genereics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLine; i++)
            {
                var input = int.Parse(Console.ReadLine());
                var box = new Box<int>(input);
                Console.WriteLine(box);
            }
        }
    }
}
