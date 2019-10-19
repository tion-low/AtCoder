using System;
using System.Linq;

namespace AtCoder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            var C = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());

            var q = from a in Enumerable.Range(0, A +1)
                from b in Enumerable.Range(0, B + 1)
                from c in Enumerable.Range(0, C + 1)
                select new {a, b, c};
            var result = q.Where(v => v.a * 500 + v.b * 100 + v.c * 50 == x).Count();
            Console.WriteLine(result);
        }
    }
}