using System;
using System.Collections.Generic;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> arr = new Dictionary<int, int>();
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int tmp = target - nums[i];
                int index;
                try
                {
                    index = arr[tmp];
                }
                catch (KeyNotFoundException)
                {
                    try
                    {
                        arr.Add(nums[i], i);
                        continue;
                    }
                    catch (ArgumentException)
                    {
                        continue;
                    }
                }

                result[0] = index;
                result[1] = i;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
