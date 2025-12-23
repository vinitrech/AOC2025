using System.Text.Json;

namespace DayThreeSecondHalf;

public class DayThreeSecondHalfSolver
{
    public static long SolveLobby(string[] banks) => banks.Sum(GetBankMaximumJoltage);

    private static long GetBankMaximumJoltage(string bank)
    {
        var elements = new List<long>();
        var trimLimit = bank.Length - 12;
        var longBank = bank.Select(digit => long.Parse(digit.ToString())).ToList();

        Console.WriteLine($"################################ ANALYZING BANK {bank} ################################");

        foreach (var digit in longBank)
        {
            Console.WriteLine($"##SCOPE LEVEL 1: ANALYZING DIGIT {digit}");

            while (elements.Count > 0 && trimLimit > 0 && elements[^1] < digit)
            {
                Console.WriteLine($"###SCOPE LEVEL 3: REMOVING DIGIT {elements[^1]}");
                Console.WriteLine($"###SCOPE LEVEL 3: DECREMENTING TRIMLIMIT {trimLimit} TO {trimLimit - 1}");

                elements.RemoveAt(elements.Count - 1);
                trimLimit--;
            }

            Console.WriteLine($"##SCOPE LEVEL 1: ADDING DIGIT {digit}");

            elements.Add(digit);
        }

        Console.WriteLine($"#SCOPE LEVEL 0: STATE OF STACK: {JsonSerializer.Serialize(elements)}");

        if (trimLimit > 0)
        {
            Console.WriteLine($"#SCOPE LEVEL 0: TRIMMING REMAINING {trimLimit} DIGITS");

            foreach (var digit in longBank[^trimLimit..])
                elements.Add(digit);
        }

        Console.WriteLine($"#SCOPE LEVEL 0: FINAL STATE OF STACK: {JsonSerializer.Serialize(elements)}");
        Console.WriteLine($"#SCOPE LEVEL 0: FINAL CONCAT: {string.Join("", elements.Take(12))}");

        return long.Parse(string.Join("", elements.Take(12)));
    }
}
