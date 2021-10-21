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
/// Вам задана строка , состоящая из пробелов и латинских букв. Строка называется панграммой, если она содержит каждую из 26 латинских букв хотя бы раз.
/// Определите является ли строка  панграммой.
///Формат входных данных
///
///В единственной строке входных данных записана строка s. Строка может содержать только пробелы, заглавные и строчные буквы латинского алфавита.
///Заглавные и строчные буквы считаются одинаковыми.
///Формат выходных данных
///
///Выведите pangram если строка s является панграммой, иначе выведите not pangram.
/// </summary>
class Result
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        s = new string(s.ToLower().Replace(" ", "").Distinct().ToArray());
        if (s.Length == 26)
        {
            return "pangram";
        }
        else return "not pangram";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}