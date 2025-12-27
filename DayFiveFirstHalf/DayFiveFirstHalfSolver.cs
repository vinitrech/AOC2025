using System.Text.Json;

namespace DayFiveFirstHalf;

public static class DayFiveFirstHalfSolver
{
    public static int SolveCafeteria(string[] input)
    {
        var validIngredients = 0;
        var separator = input.IndexOf(string.Empty);
        var ranges = input[..separator].Select(SetupRangeBoundaries);
        var availableIngredients = input[(separator + 1)..].Select(ingredient => Convert.ToInt64(ingredient));

        Console.WriteLine($"Got separator at index {separator}");
        Console.WriteLine($"Got ranges: {JsonSerializer.Serialize(ranges.Select(range => string.Join("-", range.LeftBoundary, range.RightBoundary)))}");
        Console.WriteLine($"Got available ingredients: {string.Join(",", availableIngredients.Select(i => i))}");

        foreach (var availableIngredient in availableIngredients)
        {
            Console.WriteLine($"Evaluating ingredient: {availableIngredient}");

            if (ranges.Any(range => range.LeftBoundary <= availableIngredient && range.RightBoundary >= availableIngredient))
                validIngredients++;
        }

        return validIngredients;
    }

    private static (long LeftBoundary, long RightBoundary) SetupRangeBoundaries(this string range)
    {
        var boundaries = range.Split('-');

        return (LeftBoundary: Convert.ToInt64(boundaries[0]), RightBoundary: Convert.ToInt64(boundaries[1]));
    }
}
