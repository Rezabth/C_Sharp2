using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"\""""?([^\""""]*)\""? (\d{2}) (\d{5}.\d{2}) (\d{3}-\d{7})";
        string input = @"""Mattias Aspuland"" 46 35000.00 070-7829978";

        Match m = Regex.Match(input, pattern);
        Console.WriteLine("'{0}' found at index {1}", m.Value, m.Index);
    }
}