using System;

namespace Palendrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            bool flag = true;
            if (x < 0) flag = false;
            long div = 1;
            while (x > div * 10 && div * 10 < int.MaxValue)
            {
                div = div * 10;
            }
            while (x >= 10)
            {
                if (x % 10 != x / div)
                {
                    flag = false;
                }
                x = x % (int)div;
                x = x / 10;
                div = div / 100;
                while (div > x)
                {
                    if (x % 10 != 0)
                    {
                        flag = false;
                    }
                    else
                    {
                        div = div / 100;
                        x = x / 10;
                    }
                }
            }
            Console.WriteLine(flag); 
        }
    }
}
