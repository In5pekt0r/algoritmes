using System;
/// <summary>
/// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
/// An input string is valid if:
/// Open brackets must be closed by the same type of brackets.
/// Open brackets must be closed in the correct order.
/// </summary>
namespace ValidBrackets
{
    class Program
    {
        static public bool IsValid(string s)
        {
            string tmp = "";
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == '[' || s[i] == '{' || s[i] == '(')
                {
                    tmp += s[i];
                    continue;
                }
                else
                {
                    if(tmp == "") return false;
                    switch (s[i])
                    {
                        case ']':
                            if(tmp[tmp.Length - 1] != '[')
                            {
                                return false;
                            }
                            else
                            {
                                tmp = tmp.Substring(0, tmp.Length - 1);
                            }
                            break;
                        case '}':
                            if (tmp[tmp.Length - 1] != '{')
                            {
                                return false;
                            }
                            else
                            {
                                tmp = tmp.Substring(0, tmp.Length - 1);
                            }
                            break;
                        case ')':
                            if (tmp[tmp.Length - 1] != '(')
                            {
                                return false;
                            }
                            else
                            {
                                tmp = tmp.Substring(0, tmp.Length - 1);
                            }
                            break;
                        default:
                            break;
                    }
                        

                }
            }
            return tmp == "";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid(Console.ReadLine()));
        }
    }
}
