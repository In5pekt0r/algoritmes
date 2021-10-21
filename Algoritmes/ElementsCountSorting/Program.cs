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
/// Comparison Sorting
/// Quicksort usually has a running time of n * log(n), but is there an algorithm that can sort even faster?
/// In general, this is not possible. Most sorting algorithms are comparison sorts, i.e. they sort a list just by comparing the elements to one another.
/// A comparison sort algorithm cannot beat n * log(n) (worst-case) running time, since n * log(n) represents the minimum number 
/// of comparisons needed to know where to place each element. For more details, you can see these notes (PDF).
/// 
/// Alternative Sorting
/// Another sorting method, the counting sort, does not require comparison. 
/// Instead, you create an integer array whose index range covers the entire range of values in your array to sort. 
/// Each time a value occurs in the original array, you increment the counter at that index. 
/// At the end, run through your counting array, printing the value of each non-zero valued index that number of times.
/// </summary>
class Result
{

    /*
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> countingSort(List<int> arr)
    {
        int[] Ar = new int[100];
        List<int> result = new List<int>(Ar);
        foreach (int i in arr)
        {
            result[i]++;
        }
        return result;


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.countingSort(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
