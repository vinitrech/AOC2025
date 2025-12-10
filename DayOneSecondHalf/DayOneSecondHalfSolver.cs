namespace DayOneSecondHalf;

public static class DayOneSecondHalfSolver
{
    public static async Task<int> SolveSecretEntrance(string[] lines)
    {
        var dialPosition = 50;
        var zeroHits = 0;

        foreach (var line in lines)
        {
            var direction = line[0];
            var count = Convert.ToInt32(line[1..]);

            Console.WriteLine($"\n\nGot direction {direction} and count {count}");
            Console.WriteLine($"The dialPosition was {dialPosition}");
            Console.WriteLine($"The zeroHits was {zeroHits}");

            if (direction == 'R')
            {
                zeroHits += (dialPosition + count) / 100;
                dialPosition = (dialPosition + count) % 100;
            }
            else
            {

            }

            Console.WriteLine($"The dialPosition became {dialPosition}");
            Console.WriteLine($"The zeroHits became {zeroHits}");
        }

        Console.WriteLine($"The password to open the lock is: {zeroHits}");

        return zeroHits;
    }
}
