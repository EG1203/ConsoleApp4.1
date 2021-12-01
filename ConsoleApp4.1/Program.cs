using System;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[19];
            //Fill the array here as you'd like to
            if (a.Where(x => x < 0).Count() == 0)
                Console.WriteLine("No negatives");
            else
                Console.WriteLine(a.TakeWhile(x => x >= 0).Sum());
        }
    }
}
