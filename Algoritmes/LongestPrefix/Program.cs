using System;

namespace LongestPrefix
{
    class Program
    {
        static public string LongestCommonPrefix(string[] strs)
        {
            string common = "";
            if (strs[0] == "")
            {
                return common;
            }

            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j].Length == i || strs[0][i] != strs[j][i] || strs[j] == "")
                    {
                        return common;
                    }
                }
                common += strs[0][i];
            }
            return common;
        }
        static void Main(string[] args)
        {
            string[] strs = new string[] {"ab", "a"};
            Console.WriteLine(LongestCommonPrefix(strs));
        }
    }
}
