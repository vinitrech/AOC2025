namespace DayFiveFirstHalf;

public static class DayFiveFirstHalfSolver
{
    public static int SolveCafeteria(string[] input)
    {
        var separator = input.IndexOf(string.Empty);
        var ranges = input[..separator].Select(SetupRangeBoundaries).ToList();
        var availableIngredients = input[(separator + 1)..].Select(long.Parse);

        return availableIngredients.Count(availableIngredient => ranges.Any(range => range.LeftBoundary <= availableIngredient && range.RightBoundary >= availableIngredient));
    }

    private static (long LeftBoundary, long RightBoundary) SetupRangeBoundaries(this string range)
    {
        var boundaries = range.Split('-');

        return (LeftBoundary: long.Parse(boundaries[0]), RightBoundary: long.Parse(boundaries[1]));
    }
}
