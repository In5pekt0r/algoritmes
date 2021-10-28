using System;
/// <summary>
/// Roman numerals are usually written largest to smallest from left to right. 
/// However, the numeral for four is not IIII. Instead, the number four is written as IV. 
/// Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. 
/// </summary>
namespace RomanianNumber
{
    class Program
    {
        static int RomanToInt(string str)
        {
            int sum = 0;
            int flag = 1000;
            for (int i = 0; i < str.Length; i++)
            {
                int value = 0;
                if (str[i] == 'I')
                {
                    value = 1;
                }
                else if (str[i] == 'V')
                {
                    value = 5;
                }
                else if (str[i] == 'X')
                {
                    value = 10;
                }
                else if (str[i] == 'L')
                {
                    value = 50;
                }
                else if (str[i] == 'C')
                {
                    value = 100;
                }
                else if (str[i] == 'D')
                {
                    value = 500;
                }
                else if (str[i] == 'M')
                {
                    value = 1000;
                }
                sum += value;
                if(flag < value)
                {
                    sum -= 2*flag;
                }
                flag = value;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string rom = Console.ReadLine();
            int x = RomanToInt(rom);
            Console.WriteLine(x);
        }
    }
}
