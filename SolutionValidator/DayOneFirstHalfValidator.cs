using DayOneFirstHalf;
using FluentAssertions;

namespace SolutionValidator;

public class DayOneFirstHalfValidator
{
    [Fact]
    public static async Task On_Sucess_Should_Validate_DayOnefirstHalfSolver()
    {
        //arrange
        var lines = await File.ReadAllLinesAsync("Inputs/Input.txt");

        //act
        var solution = await DayOneFirstHalfSolver.SolveSecretEntrance(lines);

        //assert
        solution.Should().Be(995);
    }
}
