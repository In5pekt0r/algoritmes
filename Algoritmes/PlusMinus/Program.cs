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
/// Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with 6 places after the decimal.
/// Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to 10^4 are acceptable.
/// Input (stdin)
/// 5
/// 0 0 - 1 1 1
/// Expected Output
/// 0.400000
/// 0.200000
/// 0.400000
/// </summary>
class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int countplus = 0;
        int countminus = 0;
        int countzero = 0;
        foreach (int i in arr)
        {
            if (i == 0)
            {
                countzero++;
            }
            else
            {
                if (i > 0)
                {
                    countplus++;
                }
                else countminus++;
            }
        }
        double length = arr.Count;
        Console.WriteLine((countplus / length).ToString("N6"));
        Console.WriteLine((countminus / length).ToString("N6"));
        Console.WriteLine((countzero / length).ToString("N6"));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}