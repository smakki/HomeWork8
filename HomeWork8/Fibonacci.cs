
namespace HomeWork8
{
    internal class Fibonacci
    {

        public static int Reccursion(int n)
        {
            return n <= 1 ? n : Reccursion(n - 1) + Reccursion(n - 2);
        }

        public static int Loop(int n)
        {
            var a = 0;
            var b = 1;
            for (int i = 0; i < n; i++)
            {
                (a, b) = (b, a + b);  
            }
            return a;
        }
    }
}
