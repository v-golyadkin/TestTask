using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };

        Console.WriteLine("Результат:");
        foreach (var number in numbers)
        {
            Console.Write(ReplaceNumber(number));
            Console.Write(", ");
        }
        Console.WriteLine();
    }

    static string ReplaceNumber(int number)
    {
        var replacements = new List<string>();

        if (number % 3 == 0)
            replacements.Add("dog");

        if (number % 5 == 0)
            replacements.Add("cat");

        if (number % 4 == 0)
            replacements.Add("muzz");

        if (number % 7 == 0)
            replacements.Add("guzz");
        

        if (replacements.Count == 0)
            return number.ToString();
        else if (replacements.Contains("dog") && replacements.Contains("cat") && replacements.Contains("muzz") && replacements.Contains("guzz"))
            return "good-boy-muzz-guzz";
        else if (replacements.Contains("dog") && replacements.Contains("cat") && replacements.Contains("muzz"))
            return "good-boy-muzz";
        else if (replacements.Contains("dog") && replacements.Contains("cat") && replacements.Contains("guzz"))
            return "good-boy-guzz";
        else if (replacements.Contains("dog") && replacements.Contains("cat"))
            return "good-boy";
        else
            return string.Join("-", replacements);
    }
}