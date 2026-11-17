using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var seen = new HashSet<char>();

        foreach (char c in word)
        {
            if (char.IsLetter(c))
            {
                char lower = char.ToLower(c);
                if (!seen.Add(lower))
                {
                    return false;
                }
            }
        }

        return true;
    }
}