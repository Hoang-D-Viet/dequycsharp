using System; 

namespace BT
{
    class Program
    {
        public static int Luythua(int x, int y)
        {
            if (y == 0) return 1;
            else
            {
                return x * Luythua(x, y - 1);
            }
        }
        static void Main()
        {
            Console.WriteLine(Luythua(2, 3));
        }
    }
}