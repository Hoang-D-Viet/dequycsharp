using System;

namespace BT
{
    class Program
    {
        static void Nhiphan(int a)
        {
            if ( a == 0 )
            {
                return;


            }
            else
            {
                Nhiphan(a / 2);
                Console.WriteLine(a % 2);
            }
            
        }
        static void Main(string[] args)
        {
            Nhiphan(9);
        }
    }
}