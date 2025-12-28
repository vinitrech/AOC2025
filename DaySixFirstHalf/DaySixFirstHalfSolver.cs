namespace DaySixFirstHalf;

public static class DaySixFirstHalfSolver
{
    public static long SolveTrashCompactor(string[] input)
    {
        var grandTotal = 0L;
        var entries = input.SelectMany(i => i.Split(string.Empty, options: StringSplitOptions.RemoveEmptyEntries)).ToList();
        var (numbers, operators) = (entries[..^1].OrderByDescending(entry => entry.Length).ToList(), entries[^1]);
        var index = 0;

        Console.WriteLine($"Numbers:");

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"Operators: {operators}");

        // while(index < entries[0].Length)
        // {
        //     //TODO
        // }

        return grandTotal;
    }
}
