namespace DayTwoFirstHalf;

public class DayTwoFirstHalfSolver
{
    public static long SolveGiftShop(string ids) => ids.Split(',').Sum(SumInvalidIds);

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

        if (stringId.Length % 2 != 0)
            return false;

        return stringId[0..halfLength] == stringId[halfLength..];
    }
}
