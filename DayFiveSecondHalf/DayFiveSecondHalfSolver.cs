namespace DayFiveSecondHalf;

public static class DayFiveSecondHalfSolver
{
    public static long SolveCafeteria(string[] input)
    {
        var separator = input.IndexOf(string.Empty);
        var ranges = input[..separator].Select(SetupRangeBoundaries).OrderBy(range => range.LeftBoundary).ToList();
        var total = 0L;
        var currentStart = ranges[0].LeftBoundary;
        var currentEnd = ranges[0].RightBoundary;

        foreach (var (left, right) in ranges.Skip(1))
        {
            if (left <= currentEnd)
                currentEnd = Math.Max(currentEnd, right);
            else
            {
                total += currentEnd - currentStart + 1;
                currentStart = left;
                currentEnd = right;
            }
        }

        return total + currentEnd - currentStart + 1;
    }

    private static (long LeftBoundary, long RightBoundary) SetupRangeBoundaries(this string range)
    {
        var boundaries = range.Split('-');

        return (LeftBoundary: long.Parse(boundaries[0]), RightBoundary: long.Parse(boundaries[1]));
    }
}
