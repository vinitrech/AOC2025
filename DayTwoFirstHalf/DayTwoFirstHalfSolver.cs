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

        if (stringId.Length < 2)
            return false;

        return string.Concat(stringId, stringId).Substring(1, stringId.Length * 2 - 2).Contains(stringId);
    }
}
