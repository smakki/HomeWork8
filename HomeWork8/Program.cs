using System.Diagnostics;

namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            //var count = 45;
            //sw.Restart();
            //for (int i = 0; i <= count; i++)
            //{
            //    Console.WriteLine("The {0}st term of the Fibonacci sequence is {1}.", i, Fibonacci.Reccursion(i));
            //}
            //sw.Stop();
            //Console.WriteLine("the time spent on finding the Fibonacci sequence of {1} elements using the recursion method was {0} ms.", sw.ElapsedMilliseconds,count);
            //Console.WriteLine();


            //sw.Restart();
            //for (int i = 0; i <= count; i++)
            //{
            //    Console.WriteLine("The {0}st term of the Fibonacci sequence is {1}.", i, Fibonacci.Loop(i));
            //}
            //sw.Stop();
            //Console.WriteLine("the time spent searching for a Fibonacci sequence of {1} elements in a loop was {0} ms.", sw.ElapsedMilliseconds,count);
            //Console.WriteLine();


            int[] nums = { 5, 10, 20 };

            foreach (var n in nums)
            {
                sw.Restart();
                var value = Fibonacci.Reccursion(n);
                sw.Stop();
                Console.WriteLine("The {0}st term of the Fibonacci sequence is {1}.", n, value);
                Console.WriteLine("the time spent on finding {0} member of the Fibonacci sequence using the recursion method was {1} ticks.", n, sw.ElapsedTicks);
                Console.WriteLine();
            }

            foreach (var n in nums)
            {
                sw.Restart();
                var value = Fibonacci.Loop(n);
                sw.Stop();
                Console.WriteLine("The {0}st term of the Fibonacci sequence is {1}.", n, value);
                Console.WriteLine("the time spent on finding {0} member of the Fibonacci sequence using the loop was {1} ticks.", n, sw.ElapsedTicks);
                Console.WriteLine();

              
            }
        }
    }
}
