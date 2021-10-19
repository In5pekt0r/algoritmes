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
/// There is a collection of input strings and a collection of query strings. 
/// For each query string, determine how many times it occurs in the list of input strings. Return an array of the results.
/// </summary>
class Result
{

    /*
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> arr = new List<int>();

        for (int i = 0; i < queries.Count; i++)
        {
            int count = 0;
            for (int j = 0; j < strings.Count; j++)
            {
                if (queries[i] == strings[j]) count++;
            }
            arr.Add(count);
        }
        return arr;

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> strings = new List<string>();

        for (int i = 0; i < stringsCount; i++)
        {
            string stringsItem = Console.ReadLine();
            strings.Add(stringsItem);
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < queriesCount; i++)
        {
            string queriesItem = Console.ReadLine();
            queries.Add(queriesItem);
        }

        List<int> res = Result.matchingStrings(strings, queries);

        Console.WriteLine(String.Join("\n", res));

    }
}
