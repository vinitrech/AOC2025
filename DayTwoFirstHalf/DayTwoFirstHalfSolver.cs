namespace DayTwoFirstHalf;

public class DayTwoFirstHalfSolver
{
    public static long SolveGiftShop(string ids) => ids.Split(',').SelectMany(GetInvalidIds).Sum();

    private static List<long> GetInvalidIds(string range)
    {
        var boundaries = range.Split('-');
        var leftBoundary = Convert.ToInt64(boundaries[0]);
        var rightBoundary = Convert.ToInt64(boundaries[1]);
        var ids = Enumerable.Sequence(leftBoundary, rightBoundary, step: 1);

        return [.. ids.Where(IsInvalidId)];
    }

    private static bool IsInvalidId(long id)
    {
        var uniqueString = string.Empty;
        var stringId = id.ToString();

        foreach (var digit in stringId)
        {
            if (!uniqueString.Contains(digit))
                uniqueString += digit;
            else
                break;
        }

        var result = uniqueString != stringId && stringId.Replace(uniqueString, "").Length == 0;

        Console.WriteLine($"Unique string: {uniqueString}");
        Console.WriteLine($"Got result {result} for id {id}");

        return result;
    }
}
