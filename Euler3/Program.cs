using System;
using System.Text;

namespace Euler3
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n;
            ulong.TryParse(args[0], out n);

            uint high = 2;

            while (n % 2 == 0)
                n = n / 2;

            uint f = 3;

            while (n > 1)
            {
                if( n % f == 0)
                {
                    n = n / f;
                    high = f;
                } else
                {
                    f += 2;
                }
            }

            Console.WriteLine(high);
            Console.ReadLine();
        }
    }
}
