using System;
using System.Collections.Generic;
using System.Linq;

namespace Braces
{
    public class Program
    {
        static void Main(string[] args)
        {
            int _values_size = 0;
            _values_size = Convert.ToInt32(Console.ReadLine());
            string[] _values = new string[_values_size];
            string _values_item;
            for (int _values_i = 0; _values_i < _values_size; _values_i++)
            {
                _values_item = Console.ReadLine();
                _values[_values_i] = _values_item;
            }

            var res = Braces(_values);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
        }

        static string[] Braces(string[] values)
        {
            string[] _values = new string[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                _values[i] = IsMatch(values[i]);
            }
            return _values;
        }

        public static string IsMatch(string line)
        {
            var openingBraces = new char[3] { '[', '{', '(' };
            var closingBraces = new char[3] { ']', '}', ')' };
            var stackMatches = new Stack<char>();
            var elements = line.ToArray();

            for (int i = 0; i < elements.Length; i++)
            {
                var element = elements[i];
                if (openingBraces.Contains(element))
                {
                    stackMatches.Push(element);
                    continue;
                }

                if (closingBraces.Contains(element))
                {
                    if (stackMatches.Any() && IsMatch(stackMatches.Peek(), element))
                    {
                        stackMatches.Pop();
                        continue;
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }
            return stackMatches.Any() ? "NO" : "YES";
        }

        static bool IsMatch(char openingBrace, char closingBrace)
        {
            switch (closingBrace)
            {
                case '}':
                    return openingBrace.Equals('{') ? true : false;
                case ']':
                    return openingBrace.Equals('[') ? true : false;
                case ')':
                    return openingBrace.Equals('(') ? true : false;
                default:
                    return false;
            }
        }

    }
}