using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return Enumerable.Range(0, max)
            .Where(number => multiples.Any(m => m != 0 && number % m == 0))
            .Sum();
    }
}