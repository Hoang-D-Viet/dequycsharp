using System;

namespace BT
{
    class Program
    {
        static int wish(int a, int b)
        {
            if ( b == 0)
            {
                return a;
            } 
            else
            {
            
                return wish(b, a % b);
            }
        }
        static void Main()
        {
            
            Console.WriteLine(wish(99,27));
        }
    }
}