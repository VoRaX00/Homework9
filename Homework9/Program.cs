namespace Homework9
{
    internal class Program
    {
        static void Task64(int n)
        {
            if(n<=0)
            {
                return;
            }
            Console.Write(n + " ");
            Task64(n-1);
        }

        static int Task66(int m, int n)
        {
            if (m == n && m > 0)
            {
                return m;
            }
            else if (m < n && m > 0)
            {
                return m + Task66(m + 1, n);
            }
            else
            {
                return 0;
            }
        }

        static int Task68(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 &&  n == 0)
            {
                return Task68(m - 1, 1);
            }
            else
            {
                return Task68(m - 1, Task68(m, n - 1));
            }
        }

        static void Main(string[] args)
        {
            Task64(8);
            Console.WriteLine(Task66(1, 9));
            Console.WriteLine(Task68(3, 2));
        }
    }
}