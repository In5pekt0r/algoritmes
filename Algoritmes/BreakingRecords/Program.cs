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
/// Maria plays college basketball and wants to go pro. Each season she maintains a record of her play. 
/// She tabulates the number of times she breaks her season record for most points and least points in a game. 
/// Points scored in the first game establish her record for the season, and she begins counting from there.
/// Input
/// 9
/// 10 5 20 20 4 5 2 25 1
/// Output
/// 2 4
/// </summary>
class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        int min = scores[0];
        int max = scores[0];
        List<int> arr = new List<int>();
        arr.Add(0);
        arr.Add(0);
        foreach (int i in scores)
        {
            if (i < min)
            {
                min = i;
                arr[1]++;
            }
            if (i > max)
            {
                max = i;
                arr[0]++;
            }
        }
        return arr;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        Console.WriteLine(String.Join(" ", result));

    }
}
