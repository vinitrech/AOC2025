namespace DayTwoFirstHalf;

public class DayTwoFirstHalfSolver
{
    public static long SolveGiftShop(string ids)
    {
        // Console.WriteLine($"ids: {ids}");

        return ids.Split(',').Sum(SumInvalidIds);
    }

    private static long SumInvalidIds(string range)
    {
        var boundaries = range.Split('-');
        var leftBoundary = Convert.ToInt64(boundaries[0]);
        var rightBoundary = Convert.ToInt64(boundaries[1]);
        var ids = Enumerable.Sequence(leftBoundary, rightBoundary, step: 1);

        return ids.Where(IsInvalidId).Sum();
    }

    private static bool IsInvalidId(long id)
    {
        var stringId = id.ToString();
        var halfLength = stringId.Length / 2;

        // Console.WriteLine();
        // Console.WriteLine($"\n\n\nGot halfLength: {halfLength} for id {id}");
        // Console.WriteLine($"Length of id {id}: {stringId.Length}");

        if (stringId.Length % 2 != 0)
        {
            // Console.WriteLine($"Got valid by length for id {id}");

            return false;
        }

        var result = stringId[0..halfLength] == stringId[halfLength..];

        // Console.WriteLine($"Got {stringId[0..halfLength]} as first half for id {id}");
        // Console.WriteLine($"Got {stringId[halfLength..]} as second half for id {id}");
        // Console.WriteLine($"Got {(result ? "Invalid" : "Valid")} for id {id}");

        return result;
    }
}
