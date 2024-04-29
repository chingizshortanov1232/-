using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговая_контрольная
{
    internal class Program
    {
        string[] inputArray = { "apple", "banana", "cat", "a", "or", "dog", "elephant", "to", "fish" };

        string[] resultArray = FilterStrings(inputArray);

        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] input)
    {
        int count = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
    }
        string[] result = new string[count];

        int index = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }