using DaySixFirstHalf;
using FluentAssertions;

namespace SolutionValidator;

public class DaySixFirstHalfValidator
{
    [Fact]
    public static async Task On_Sucess_Should_Validate_DaySixFirstHalfSolver_Default_Scenario()
    {
        //arrange
        var input = new string[] { "123 328  51 64 ", "45 64  387 23", "6 98  215 314", "*   +   *   +  " };

        //act 
        var result = DaySixFirstHalfSolver.SolveTrashCompactor(input);

        //assert
        result.Should().Be(3);
    }

    [Fact]
    public static async Task On_Sucess_Should_Validate_DaySixFirstHalfSolver()
    {
        //arrange
        var input = await File.ReadAllLinesAsync("Inputs/DaySix/Input.txt");

        //act
        var result = DaySixFirstHalfSolver.SolveTrashCompactor(input);

        //assert
        result.Should().Be(707);
    }
}
