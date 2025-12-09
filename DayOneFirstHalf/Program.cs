namespace DayOneFirstHalf;

public class Program
{
    public static async Task Main()
    {
        var lines = await File.ReadAllLinesAsync("Input.txt");
        var dialPosition = 50;
        var zeroHits = 0;

        foreach (var line in lines)
        {
            var direction = line[0];
            var count = Convert.ToInt32(line[1..]);

            Console.WriteLine();
            Console.WriteLine($"Got direction {direction} and count {count}");
            Console.WriteLine($"The dialPosition was {dialPosition}");

            dialPosition = ((direction == 'R') ? dialPosition + count : dialPosition - count) % 100;

            if (dialPosition < 0)
                dialPosition += 100;
            if (dialPosition == 0)
                zeroHits++;

            Console.WriteLine($"The dialPosition became {dialPosition}");
        }

        Console.WriteLine($"The password to open the lock is: {zeroHits}");
    }
}
