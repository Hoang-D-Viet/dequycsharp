using System;

namespace Program
{
    class BT
    { 
        public static int Giaithua(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else 
            {
                return n * Giaithua(n - 1);
            }
        }
        static void Main()
        {
            Console.WriteLine(Giaithua(10));
        }
    }

}