using System;

class Program
{
    static void Main()
    {
        string[] inputStrings = { "Hello", "2", "world", ":-)" };
        string[] outputStrings = FilterShortStrings(inputStrings);
        Console.WriteLine("[" + string.Join(", ", outputStrings) + "]");
    }

    static string[] FilterShortStrings(string[] strings)
    {
        int count = 0;
        foreach (string s in strings)
        {
            if (s.Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;

        foreach (string s in strings)
        {
            if (s.Length <= 3)
            {
                result[index] = s;
                index++;
            }
        }

        return result;
    }
}