using System.Text.Json;

namespace DaySixSecondHalf;

public class DaySixSecondHalfSolver
{
    public static long SolveTrashCompactor(string[] input)
    {
        var grandTotal = 0L;
        var numbersList = ParseInputNumbersList(input);
        var operators = ParseInputOperators(input);
        var index = 0;

        while (index < operators.Length)
        {
            var assembledNumbers = new List<string>();
            var operation = operators[index];
            var parsedNumbers = new List<long>();

            AssembleNumbersToParse(numbersList, index, assembledNumbers);
            ParseAssembledNumbers(assembledNumbers, parsedNumbers);

            if (operation == "*")
                grandTotal += parsedNumbers.Aggregate((prev, next) => prev * next);
            else
                grandTotal += parsedNumbers.Aggregate((prev, next) => prev + next);

            index++;
        }

        return grandTotal;
    }

    private static void AssembleNumbersToParse(List<List<string>> numbersList, int index, List<string> numbersToAssemble)
    {
        foreach (var numberList in numbersList)
        {
            if (index >= numberList.Count)
                continue;

            numbersToAssemble.Add(numberList[index]);
        }

        Console.WriteLine($"AssembledNumbers: {JsonSerializer.Serialize(numbersToAssemble)}");
    }

    private static void ParseAssembledNumbers(List<string> numbersToAssemble, List<long> innerNumbers)
    {
        var biggestNumberLength = numbersToAssemble.Max(number => number.Length);

        Console.WriteLine($"biggestNumberLength: {biggestNumberLength}");

        for (var maxLengthIndex = biggestNumberLength; maxLengthIndex > 0; maxLengthIndex--)
        {
            var parsedNumber = "";

            for (var assembledNumberIndex = 0; assembledNumberIndex < numbersToAssemble.Count; assembledNumberIndex++)
                if (!string.IsNullOrWhiteSpace(numbersToAssemble[assembledNumberIndex]))
                    (parsedNumber, numbersToAssemble[assembledNumberIndex]) = ($"{parsedNumber}{numbersToAssemble[assembledNumberIndex][^1]}", numbersToAssemble[assembledNumberIndex][..^1]);

            innerNumbers.Add(long.Parse(parsedNumber));
        }

        Console.WriteLine($"InnerNumbers: {JsonSerializer.Serialize(innerNumbers)}");
    }

    private static List<List<string>> ParseInputNumbersList(string[] input) => [.. input[..^1].Select(entry => entry.Split(" ", options: StringSplitOptions.RemoveEmptyEntries).ToList())];
    private static string[] ParseInputOperators(string[] input) => input[^1].Split(" ", options: StringSplitOptions.RemoveEmptyEntries);
}
