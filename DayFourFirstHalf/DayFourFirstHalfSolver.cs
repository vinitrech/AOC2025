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

        if (row > 0)
        {
            if (rolls[row - 1][column] == '@')
                neighbours++;
            if (column > 0 && rolls[row - 1][column - 1] == '@')
                neighbours++;
            if (column < rolls[row].Length - 1 && rolls[row - 1][column + 1] == '@')
                neighbours++;
        }

        if (column > 0 && rolls[row][column - 1] == '@')
            neighbours++;
        if (column < rolls[row].Length - 1 && rolls[row][column + 1] == '@')
            neighbours++;

        if (row < rolls.Length - 1)
        {
            if (rolls[row + 1][column] == '@')
                neighbours++;
            if (column > 0 && rolls[row + 1][column - 1] == '@')
                neighbours++;
            if (column < rolls[row].Length - 1 && rolls[row + 1][column + 1] == '@')
                neighbours++;
        }

        return neighbours <= 3;
    }
}
