using System.IO;
using System;
using System.Text.RegularExpressions;

namespace LAB_9._2
{

    class Program
    {
        static void Main()
        {
            string text = File.ReadAllText("text.txt");
            string pattern = @"([a-z]+\s+)?[a-z]+\s+([A-Z]*[a-z]*[0-9]*)\s*{\s*(get|set)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(text);
            while (match.Success)
            {
                if (!Regex.IsMatch(match.Groups[1].Value,"static"))
                    Console.WriteLine(match.Groups[2].Value);
                match = match.NextMatch();
            }
        }
    }
}
