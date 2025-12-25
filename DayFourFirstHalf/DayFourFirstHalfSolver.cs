namespace DayFourFirstHalf;

public class DayFourFirstHalfSolver
{
    public static long SolvePrintingDepartment(string[] rolls)
    {
        var count = 0;

        for (var row = 0; row < rolls.Length; row++)
            for (var column = 0; column < rolls[row].Length; column++)
                if (rolls[row][column] == '@' && HasUpToThreeNeighbours(rolls, row, column))
                    count++;

        return count;
    }

    private static bool HasUpToThreeNeighbours(string[] rolls, int row, int column)
    {
        var neighbours = 0;

        for (var directionRow = -1; directionRow <= 1; directionRow++)
            for (var directionColumn = -1; directionColumn <= 1; directionColumn++)
            {
                if (directionRow == 0 && directionColumn == 0)
                    continue;

                var rowToAnalyze = row + directionRow;
                var columnToAnalyze = column + directionColumn;

                if (rowToAnalyze >= 0 && rowToAnalyze < rolls.Length && columnToAnalyze >= 0 && columnToAnalyze < rolls[rowToAnalyze].Length && rolls[rowToAnalyze][columnToAnalyze] == '@')
                    if (++neighbours > 3)
                        return false;
            }

        return true;
    }
}
