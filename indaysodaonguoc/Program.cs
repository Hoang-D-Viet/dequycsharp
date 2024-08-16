using System;

namespace BT
{
    class Program
    {
        static void nguoc(int n)
        {
            if ( n == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(n % 10);
                nguoc(n / 10);
            }
        }
        static void Main (string[] args)
        {
            nguoc(1234);
        }
    }
}