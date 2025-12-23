namespace DayThreeFirstHalf;

public class DayThreeFirstHalfSolver
{
    public static int SolveLobby(string[] banks) => banks.Sum(GetMaximumJoltage);

    private static int GetMaximumJoltage(string bank)
    {
        var digits = bank.Select(digit => digit).ToList();
        var max = digits.Max();
        var maxIndex = digits.IndexOf(max);
        var secondMaxIndex = 0;

        if (maxIndex + 1 == digits.Count)
            digits = digits[..maxIndex];
        else
        {
            digits = digits[(maxIndex + 1)..];
            secondMaxIndex += maxIndex;
        }

        var secondMax = digits.Max();
        secondMaxIndex += digits.IndexOf(secondMax);

        return maxIndex > secondMaxIndex ? Convert.ToInt32($"{secondMax}{max}") : Convert.ToInt32($"{max}{secondMax}");
    }
}
