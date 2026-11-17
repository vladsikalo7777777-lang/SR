public static class LineUp
{
    public static string Format(string name, int number)
    {
        int lastTwo = number % 100;
        int lastDigit = number % 10;

        string suffix;

        if (lastTwo >= 11 && lastTwo <= 13)
            suffix = "th";
        else if (lastDigit == 1)
            suffix = "st";
        else if (lastDigit == 2)
            suffix = "nd";
        else if (lastDigit == 3)
            suffix = "rd";
        else
            suffix = "th";

        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
    }
}