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

            // Console.WriteLine($"\n\nGot direction {direction} and count {count}");
            // Console.WriteLine($"The dialPosition was {dialPosition}");
            // Console.WriteLine($"The zeroHits was {zeroHits}");

            if (direction == 'R')
            {
                while (count > 0)
                {
                    dialPosition += 1;

                    if (dialPosition == 100)
                    {
                        dialPosition = 0;
                        zeroHits += 1;
                    }

                    count--;
                }
            }
            else
            {
                while (count > 0)
                {
                    dialPosition -= 1;

                    if (dialPosition == 0)
                        zeroHits++;

                    if (dialPosition < 0)
                        dialPosition = 99;

                    count--;
                }
            }

            // Console.WriteLine($"The dialPosition became {dialPosition}");
            // Console.WriteLine($"The zeroHits became {zeroHits}");
        }

        // Console.WriteLine($"The password to open the lock is: {zeroHits}");

        return zeroHits;
    }
}
