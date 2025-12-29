namespace DaySixFirstHalf;

public static class DaySixFirstHalfSolver
{
    public static long SolveTrashCompactor(string[] input)
    {
        var grandTotal = 0L;
        var numbersList = ParseInputNumbersList(input);
        var operators = ParseInputOperators(input);
        var index = 0;

        while (index < operators.Length)
        {
            var innerNumbers = new List<long>();
            var operation = operators[index];

            foreach (var numberList in numbersList)
            {
                if (index >= numberList.Count)
                    continue;

                innerNumbers.Add(numberList[index]);
            }

            if (operation == "*")
                grandTotal += innerNumbers.Aggregate((prev, next) => prev * next);
            else
                grandTotal += innerNumbers.Aggregate((prev, next) => prev + next);

            index++;
        }

        return grandTotal;
    }

    private static List<List<long>> ParseInputNumbersList(string[] input) => [.. input[..^1].Select(entry => entry.Split(" ", options: StringSplitOptions.RemoveEmptyEntries).Select(entry => long.Parse(entry)).ToList())];
    private static string[] ParseInputOperators(string[] input) => input[^1].Split(" ", options: StringSplitOptions.RemoveEmptyEntries);
}
