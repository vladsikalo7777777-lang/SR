using System;

public static class ResistorColorTrio
{
    private static readonly string[] Colors = {
        "black", "brown", "red", "orange", "yellow", 
        "green", "blue", "violet", "grey", "white"
    };

    public static string Label(string[] colors)
    {
        int digit1 = Array.IndexOf(Colors, colors[0]);
        int digit2 = Array.IndexOf(Colors, colors[1]);
        int zeros = Array.IndexOf(Colors, colors[2]);

        long ohms = (digit1 * 10 + digit2);
        for (int i = 0; i < zeros; i++)
        {
            ohms *= 10;
        }

        if (ohms >= 1_000_000_000)
        {
            return $"{ohms / 1_000_000_000} gigaohms";
        }
        if (ohms >= 1_000_000)
        {
            return $"{ohms / 1_000_000} megaohms";
        }
        if (ohms >= 1_000)
        {
            return $"{ohms / 1_000} kiloohms";
        }

        return $"{ohms} ohms";
    }
}