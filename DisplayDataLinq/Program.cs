using System;
using System.Collections.Generic;
using System.Linq;

public class Prefix
{
    public static IEnumerable<string> Prefixes(IEnumerable<string> words, int length)
    {
        IEnumerable<string> result = words.Where(x => x.Length >= length).Select(x => x.Substring(0, length)).Distinct();
        return result;
    }

    public static void Main(string[] args)
    {
        foreach (var p in Prefixes(new string[] { "many", "manly", "men", "maybe", "my" }, 3))
            Console.WriteLine(p);
    }
}