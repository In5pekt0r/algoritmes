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
/// Given a time in 12-hour AM/PM format, convert it to military (24-hour) time
/// Note:  12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
///        12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
/// </summary>
class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        int hours = Convert.ToInt32(s.Substring(0, 2)) % 12;
        if (s.ElementAt(s.Length - 2) == 'P')
        {
            hours += 12;
        }
        return hours.ToString("D2") + s.Substring(2, 6);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
