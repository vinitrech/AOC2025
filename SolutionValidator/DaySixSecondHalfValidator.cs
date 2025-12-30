using DaySixSecondHalf;
using FluentAssertions;

namespace SolutionValidator;

public class DaySixSecondHalfValidator
{
    [Fact]
    public static async Task On_Sucess_Should_Validate_DaySixSecondHalfSolver_Default_Scenario()
    {
        //arrange
        var input = new string[] { "123 328  51 64 ", "45 64  387 23", "6 98  215 314", "*   +   *   +  " };

        //act 
        var result = DaySixSecondHalfSolver.SolveTrashCompactor(input);

        //assert
        result.Should().Be(3263827L);
    }

    // [Fact]
    // public static async Task On_Sucess_Should_Validate_DaySixSecondHalfSolver()
    // {
    //     //arrange
    //     var input = await File.ReadAllLinesAsync("Inputs/DaySix/Input.txt");
    //
    //     //act
    //     var result = DaySixSecondHalfSolver.SolveTrashCompactor(input);
    //
    //     //assert
    //     result.Should().Be(5335495999141L);
    // }
}
