namespace DayThreeSecondHalf;

public class DayThreeSecondHalfSolver
{
    public static long SolveLobby(string[] banks) => banks.Sum(GetBankMaximumJoltage);

    private static long GetBankMaximumJoltage(string bank)
    {
        var elements = new List<long>();
        var trimLimit = bank.Length - 12;
        var longBank = bank.Select(digit => long.Parse(digit.ToString())).ToList();

        foreach (var digit in longBank)
        {
            while (elements.Count > 0 && trimLimit > 0 && elements[^1] < digit)
            {
                elements.RemoveAt(elements.Count - 1);
                trimLimit--;
            }

            elements.Add(digit);
        }

        if (trimLimit > 0)
        {
            foreach (var digit in longBank[^trimLimit..])
                elements.Add(digit);
        }

        return long.Parse(string.Join("", elements.Take(12)));
    }
}
