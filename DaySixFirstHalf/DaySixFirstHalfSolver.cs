namespace DaySixFirstHalf;

public static class DaySixFirstHalfSolver
{
    public static long SolveTrashCompactor(string[] input)
    {
        var grandTotal = 0L;
        var numbersList = ParseInputNumbersList(input);
        var operators = ParseInputOperators(input);
        var index = 0;

        while (index < numbersList[0].Count)
        {
            var innerNumbers = new List<long>();
            var operation = operators[index];

            foreach (var numberList in numbersList)
            {
                var number = numberList.ElementAtOrDefault(index);

                if (number == 0L)
                    continue;

                innerNumbers.Add(number);
            }

            if (operation == "*")
                grandTotal += innerNumbers.Aggregate((prev, next) => prev * next);
            else
                grandTotal += innerNumbers.Aggregate((prev, next) => prev + next);

            index++;
        }

        return grandTotal;
    }

    private static List<List<long>> ParseInputNumbersList(string[] input) => [.. input[..^1].OrderByDescending(entry => entry.Length).Select(entry => entry.Split(" ", options: StringSplitOptions.RemoveEmptyEntries).Select(entry => long.Parse(entry)).ToList())];
    private static string[] ParseInputOperators(string[] input) => input[^1].Split(" ", options: StringSplitOptions.RemoveEmptyEntries);
}
