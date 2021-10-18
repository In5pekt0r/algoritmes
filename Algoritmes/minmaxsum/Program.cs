using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

/// <summary>
/// Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
/// Then print the respective minimum and maximum values as a single line of two space-separated long integers.
/// Input:
/// 1 2 3 4 5
/// Output:
/// 10 14
/// </summary>
class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long min = 1000000000;
        long max = 1;
        long sum = 0;
        foreach (long i in arr)
        {
            sum += i;
            if (max < i) max = i;
            if (min > i) min = i;
        }
        Console.Write(sum - max);
        Console.Write(" ");
        Console.Write(sum - min);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}