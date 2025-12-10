namespace DayOneFirstHalf;

public static class DayOneFirstHalfSolver
{
    public static async Task<int> SolveSecretEntrance(string[] lines)
    {
        var dialPosition = 50;
        var zeroHits = 0;

        foreach (var line in lines)
        {
            var direction = line[0];
            var count = Convert.ToInt32(line[1..]);

            dialPosition = ((direction == 'R') ? dialPosition + count : dialPosition - count) % 100;

            if (dialPosition < 0)
                dialPosition += 100;
            if (dialPosition == 0)
                zeroHits++;
        }

        return zeroHits;
    }
}
